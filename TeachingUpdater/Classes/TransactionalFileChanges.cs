using System;
using System.Collections.Generic;
using System.IO;

class TransactionalFileChanges : IDisposable
{
    private class TransactionalFileDetails
    {
        public enum TransactionalFileActionEnum { Copy, Move, Delete }
        /// <summary>
        /// The full path to the file new version of the file which was manipulated (will never be blank)
        /// </summary>
        public string TargetFilename { get; set; }
        /// <summary>
        /// The full path to the backup copy of the file which was replaced, deleted, etc. (will be blank for create, when we add that). Backup files are generated in user's temp folder
        /// </summary>
        public string BackupFilename { get; set; }
        /// <summary>
        /// The full path to the original file being copied or moved to the Target filename (will be blank for delete action)
        /// </summary>
        public string SourceFilename { get; set; }
        /// <summary>
        /// The type of action (copy, move, delete, ect.)
        /// </summary>
        public TransactionalFileActionEnum ActionType { get; private set; }

        public TransactionalFileDetails(TransactionalFileActionEnum actionType)
        {
            ActionType = actionType;
        }
        /// <summary>
        /// Rolls back the file changes to the file system
        /// </summary>
        public void Rollback()
        {
            switch (ActionType)
            {
                case TransactionalFileActionEnum.Delete:
                    if (File.Exists(BackupFilename))
                        File.Move(BackupFilename, TargetFilename);
                    break;
                case TransactionalFileActionEnum.Copy:
                    // delete the copied file and restore the backup
                    //  but only if the backup exists (or we never changed anything)
                    //  but if the backup file is empty then we did not overwrite anything (must have been a new file)
                    if (BackupFilename != null)
                    { 
                        if (File.Exists(BackupFilename))
                        {
                            // We overwrote something so remove what we wrote then restore the backup
                            File.Delete(TargetFilename);
                            File.Move(BackupFilename, TargetFilename);
                        }
                        else
                        {
                            // The backup never happened so we assume copy also did not happen
                            // this means we do nothing here
                        }
                    }
                    else
                    {
                        // We did not overwrite anything, so just delete the target
                        File.Delete(TargetFilename);
                    }

                    break;
                case TransactionalFileActionEnum.Move:
                    // Restore the source file, then restore the backup
                    if (BackupFilename != null)
                    {
                        if (File.Exists(BackupFilename))
                        {
                            // We overwrote something so remove what we wrote then restore the backup
                            File.Move(TargetFilename, SourceFilename);
                            File.Move(BackupFilename, TargetFilename);
                        }
                        else
                        {
                            // The backup never happened so we assume copy also did not happen
                            // this means we do nothing here
                        }
                    }
                    else
                    {
                        // We did not overwrite anything, so just restore the target to the source file
                        File.Move(TargetFilename, SourceFilename);
                    }

                    break;

            }

        }
        /// <summary>
        /// Commits changes to the file system (removing backups, etc.)
        /// </summary>
        public void Commit()
        {
            switch (ActionType)
            {
                // All cases have the same result, delete the backup copy
                case TransactionalFileActionEnum.Copy:
                case TransactionalFileActionEnum.Move:
                case TransactionalFileActionEnum.Delete:
                    if(File.Exists(BackupFilename))
                        File.Delete(BackupFilename);
                    break;
            }
        }

    }

    private List<TransactionalFileDetails> _lstFileActions; // to keep track of everything that needs to be rolledback or committed

    public TransactionalFileChanges()
    {
        _lstFileActions = new List<TransactionalFileDetails>();
    }

    #region IDisposable Support
    private bool disposedValue = false; // To detect redundant calls

    protected virtual void Dispose(bool disposing)
    {
        if (!disposedValue)
        {
            if (disposing)
            {
                // TODO: dispose managed state (managed objects).
            }

            // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
            // TODO: set large fields to null.

            disposedValue = true;
        }
    }

    // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
    // ~TransactionalFileChanges() {
    //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
    //   Dispose(false);
    // }

    // This code added to correctly implement the disposable pattern.
    public void Dispose()
    {
        // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        Dispose(true);
        // TODO: uncomment the following line if the finalizer is overridden above.
        // GC.SuppressFinalize(this);
    }
    #endregion

    public void CommitTransaction()
    {
        // for each item in the list, commit it (for example, remove the backup file)
        try
        {
            foreach(TransactionalFileDetails transFile in _lstFileActions)
                transFile.Commit();

            // Clear the list of transFiles allowing caller to re-use the transaction
            //  but anything committed cannot be rolledback 
            _lstFileActions.Clear();
        }
        catch (Exception ex)
        {
            Exception exOuter = new Exception("Error during commit.", ex);
            throw exOuter;
        }
    }
    public void RollbackTransaction()
    {
        // For each item in the list, roll it back (for example, delete the copied file and restore the backup file)
        try
        {
            foreach (TransactionalFileDetails transFile in _lstFileActions)
                transFile.Rollback();
        }
        catch (Exception ex)
        {
            Exception exOuter = new Exception("Error during rollback.", ex);
            throw exOuter;
        }
    }

    #region TransactionalOperations
    /// <summary>
    /// Copies a file to a new location within the transaction.
    /// </summary>
    /// <param name="sourceFilename"></param>
    /// <param name="destinationFilename"></param>
    public void CopyFile(string sourceFilename, string destinationFilename )
    {
        try
        {
            TransactionalFileDetails transFile = new TransactionalFileDetails(TransactionalFileDetails.TransactionalFileActionEnum.Copy);
            _lstFileActions.Add(transFile);

            transFile.TargetFilename = destinationFilename;
            transFile.SourceFilename = sourceFilename;

            // We only need a backup file if the copy will overwrite something
            if (File.Exists(destinationFilename))
                transFile.BackupFilename = GetTempFileName();

            // prepare for rollback
            File.Move(transFile.TargetFilename, transFile.BackupFilename);

            // Perform the desired copy
            File.Copy(transFile.SourceFilename, transFile.TargetFilename);
        }
        catch (Exception ex)
        {
            RollbackTransaction();
            Exception exOuter = new Exception("Error in CopyFile.", ex);
            throw exOuter;
        }
    }
    /// <summary>
    /// Moves a file to a new location within the transaction. If rolledback, the file will be returned to its original location.
    /// </summary>
    /// <param name="sourceFilename"></param>
    /// <param name="destinationFilename"></param>
    public void MoveFile(string sourceFilename, string destinationFilename)
    {
        try
        {
            TransactionalFileDetails transFile = new TransactionalFileDetails(TransactionalFileDetails.TransactionalFileActionEnum.Move);
            _lstFileActions.Add(transFile);

            transFile.TargetFilename = destinationFilename;
            transFile.SourceFilename = sourceFilename;

            // We only need a backup file if the copy will overwrite something
            if (File.Exists(destinationFilename))
                transFile.BackupFilename = GetTempFileName();

            // prepare for rollback
            File.Move(transFile.TargetFilename, transFile.BackupFilename);

            // Perform the desired move
            File.Move(transFile.SourceFilename, transFile.TargetFilename);
        }
        catch (Exception ex)
        {
            RollbackTransaction();
            Exception exOuter = new Exception("Error in MoveFile.", ex);
            throw exOuter;
        }
        

    }
    /// <summary>
    /// Deletes a file within the transaction.
    /// </summary>
    /// <param name="filename"></param>
    public void DeleteFile(string filename)
    {
        try
        {
            TransactionalFileDetails transFile = new TransactionalFileDetails(TransactionalFileDetails.TransactionalFileActionEnum.Delete);
            _lstFileActions.Add(transFile);

            transFile.TargetFilename = filename;

            // We only need a backup file if the copy will overwrite something
            if (File.Exists(filename))
                transFile.BackupFilename = GetTempFileName();

            // prepare for rollback and delete in one operation (move instead of copy+delete)
            File.Move(transFile.TargetFilename, transFile.BackupFilename);
        }
        catch (Exception ex)
        {
            RollbackTransaction();
            Exception exOuter = new Exception("Error in MoveFile.", ex);
            throw exOuter;
        }

    }
    #endregion

    #region SupportRoutines
    private static readonly string TempPath = Path.Combine(Path.GetTempPath(), "TransFileChanges");
    /// <summary>
    /// Returns a unique temporary file name.
    /// </summary>
    /// <param name="extension"></param>
    /// <returns></returns>
    public static string GetTempFileName()
    {
        const string EXTENSION = ".tmp";
        string filename = Crypto.GenerateAlphanumericString(14);
        string strReturn = Path.Combine(TempPath, filename) + EXTENSION;

        return strReturn;
    }
        
    #endregion
}

