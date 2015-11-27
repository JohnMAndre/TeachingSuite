<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits ComponentFactory.Krypton.Toolkit.KryptonForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.KryptonPanel = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.KryptonPanel1 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.splitOverall = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer()
        Me.KryptonSplitContainer3 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer()
        Me.lstClassGroups = New ComponentFactory.Krypton.Toolkit.KryptonListBox()
        Me.KryptonPalette1 = New ComponentFactory.Krypton.Toolkit.KryptonPalette(Me.components)
        Me.llblRemoveClassGroup = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.llblEditClassGroup = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.llblAddClassGroup = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.KryptonLabel11 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonSplitContainer1 = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer()
        Me.llblRemoveClass = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.btnEditClass = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.lstClasses = New ComponentFactory.Krypton.Toolkit.KryptonListBox()
        Me.ctxmnuClasses = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditClassToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteClassToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator()
        Me.StatisticsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HiddenStudentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VisibleStudentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator14 = New System.Windows.Forms.ToolStripSeparator()
        Me.RemoveAllStudentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmailclassToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnAddClass = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.KryptonLabel10 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.llblRemoveAssignment = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.llblEditAssignment = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.llblAddAssignment = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.lstAssignments = New ComponentFactory.Krypton.Toolkit.KryptonListBox()
        Me.ctxmnuAssignment = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopyAssignmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteNewAssignmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CreateNewAssignmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditSelectedAssignmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteSelectedAssignmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.CloseAssignmentToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseAssignment1stToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseAssignment2ndToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseAssignment3rdToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.AssignmentMoveUpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AssignmentMoveDownToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KryptonLabel1 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblStudentCount = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblRenumberAdminResetNumber = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblRenumberAdminCurrent = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.lblRenumberAdminCurrentLabel = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.splitStudentsSchedule = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer()
        Me.olvStudents = New BrightIdeasSoftware.ObjectListView()
        Me.OlvColumn4 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn11 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn1 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn2 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn3 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn5 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn6 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn8 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn7 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn9 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn18 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn10 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn20 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn12 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn13 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn14 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn15 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn19 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn21 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn22 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn23 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn24 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn25 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn26 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn27 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn28 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.ctxmnuStudents = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditStudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MeritToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DemeritToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ProcessExamForStudent = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProcessExamRedoForStudent = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProcessExam2ndReDoForStudent = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.EmailstudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScheduleNotesSplitter = New ComponentFactory.Krypton.Toolkit.KryptonSplitContainer()
        Me.olvSchedule = New BrightIdeasSoftware.ObjectListView()
        Me.OlvColumn29 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn30 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn16 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn31 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn33 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn32 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn17 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn34 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn35 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.OlvColumn36 = CType(New BrightIdeasSoftware.OLVColumn(), BrightIdeasSoftware.OLVColumn)
        Me.ctxmnuActualSessions = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SkipActualSessionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TakeAttendanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadClassToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.llblClearNotes = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.lblStopwatchDuration = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.llblStartPauseStopwatch = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.picStudent = New System.Windows.Forms.PictureBox()
        Me.KryptonPanel2 = New ComponentFactory.Krypton.Toolkit.KryptonPanel()
        Me.llblScheduleNextClassDay = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.llblScheduleNextUnprepped = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.lblScheduleDay = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.llblScheduleForwardOneDay = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.llblScheduleBackOneDay = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.dtpScheduleDate = New ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker()
        Me.llblRefreshSchedule = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.btnRemoveStudent = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.llblRemoveStudent = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.btnEditStudent = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.txtStudentFilter = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.btnSelectRandomStudent = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.llblMoveStudent = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.llblClearFilter = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.llblAddStudent = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.KryptonLabel2 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonGroup1 = New ComponentFactory.Krypton.Toolkit.KryptonGroup()
        Me.llblLoadFutureOneSemester = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.llblLoadPreviousOneSemester = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.llblLoadLatestSemester = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.KryptonLabel7 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel8 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel9 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.dtpSemesterEndCurrent = New ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker()
        Me.dtpSemesterStartCurrent = New ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker()
        Me.KryptonLabel6 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.btnLoadSemester = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.llblCloseSemesterPanel = New ComponentFactory.Krypton.Toolkit.KryptonLinkLabel()
        Me.KryptonLabel5 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.KryptonLabel4 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.dtpSemesterEnd = New ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker()
        Me.dtpSemesterStart = New ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker()
        Me.KryptonLabel3 = New ComponentFactory.Krypton.Toolkit.KryptonLabel()
        Me.cboSemester = New ComponentFactory.Krypton.Toolkit.KryptonComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadSemesterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitWithoutSavingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClassSelectorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewScheduleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentphotoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TakeAttendenceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExamToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExamRedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Exam2ndRedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.MarkSelectedAssignmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmailAssignmentResultsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SendBulkEmailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmailOnlineQuizResultsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormGroupsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator15 = New System.Windows.Forms.ToolStripSeparator()
        Me.BatchSaveMarkingSheetsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FirstTryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SecondTryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThirdTryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToggleHiddenForSelectedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetGendermaleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetGenderfemaleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearStudentFilterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExcuseMostRecentAbsenceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FilterForSelectedGroupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearTagsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseAssignmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FirstSubmissionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SecondSubmissionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ThirdSubmissionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.HideStudentsWhoPassedAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReorderAdminNumbersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageImprovementItemsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EitherOrToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveAllStudentsFromSelectedClassToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentAttendanceErrorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AssignmentResultsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModuleResultsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FailedoutcomesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModuleFeedbackCheckToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentOutcomeResultsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SessionprepStatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AssignmentProcessingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScheduledSessionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentQualityToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentGradesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SemesterStatisticsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExcessiveAbsencesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportClassToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportStudentsFromTextToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportStudentsFromOtherSemesterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportAttendanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportEmailAddressesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportStudentAssignmentScoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportImprovementItemsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExportAttendanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportModuleResultsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportMarkingResultsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportMarkingResultsFirstSubmitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportMarkingResultsSecondSubmitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportMarkingResultsThirdSubmitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportMarkingResultsIsolatedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportMarkingResultsIsolatedFirstSubmitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportMarkingResultsIsolatedSecondSubmitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportMarkingResultsIsolatedThirdSubmitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportStudentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportStudentGradesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportScheduleAsICalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.UpdateEmailAddressToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FindDuplicateStudentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FindhistoricalStudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProcessAddDropStudentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckForupdatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator16 = New System.Windows.Forms.ToolStripSeparator()
        Me.ViewLogFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.KryptonManager = New ComponentFactory.Krypton.Toolkit.KryptonManager(Me.components)
        Me.kryptonPalette2 = New ComponentFactory.Krypton.Toolkit.KryptonPalette()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.tmrFilterStudents = New System.Windows.Forms.Timer(Me.components)
        Me.KryptonContextMenuItems2 = New ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems()
        Me.KryptonContextMenuItems3 = New ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ctxmnuTray = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SelectRandomStudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmrAutoSave = New System.Windows.Forms.Timer(Me.components)
        Me.ctxmnuNewAssignment = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NewBTECAssignmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewNormalAssignmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmrStopwatch = New System.Windows.Forms.Timer(Me.components)
        Me.UpgradeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel1.SuspendLayout()
        CType(Me.splitOverall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.splitOverall.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitOverall.Panel1.SuspendLayout()
        CType(Me.splitOverall.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitOverall.Panel2.SuspendLayout()
        Me.splitOverall.SuspendLayout()
        CType(Me.KryptonSplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer3.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer3.Panel1.SuspendLayout()
        CType(Me.KryptonSplitContainer3.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer3.Panel2.SuspendLayout()
        Me.KryptonSplitContainer3.SuspendLayout()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel1.SuspendLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonSplitContainer1.Panel2.SuspendLayout()
        Me.KryptonSplitContainer1.SuspendLayout()
        Me.ctxmnuClasses.SuspendLayout()
        Me.ctxmnuAssignment.SuspendLayout()
        CType(Me.splitStudentsSchedule, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.splitStudentsSchedule.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitStudentsSchedule.Panel1.SuspendLayout()
        CType(Me.splitStudentsSchedule.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitStudentsSchedule.Panel2.SuspendLayout()
        Me.splitStudentsSchedule.SuspendLayout()
        CType(Me.olvStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ctxmnuStudents.SuspendLayout()
        CType(Me.ScheduleNotesSplitter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ScheduleNotesSplitter.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ScheduleNotesSplitter.Panel1.SuspendLayout()
        CType(Me.ScheduleNotesSplitter.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ScheduleNotesSplitter.Panel2.SuspendLayout()
        Me.ScheduleNotesSplitter.SuspendLayout()
        CType(Me.olvSchedule, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ctxmnuActualSessions.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.picStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonPanel2.SuspendLayout()
        CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.KryptonGroup1.Panel.SuspendLayout()
        Me.KryptonGroup1.SuspendLayout()
        CType(Me.cboSemester, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.ctxmnuTray.SuspendLayout()
        Me.ctxmnuNewAssignment.SuspendLayout()
        Me.SuspendLayout()
        '
        'KryptonPanel
        '
        Me.KryptonPanel.Controls.Add(Me.ToolStripContainer1)
        Me.KryptonPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel.Name = "KryptonPanel"
        Me.KryptonPanel.Palette = Me.KryptonPalette1
        Me.KryptonPanel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.KryptonPanel.Size = New System.Drawing.Size(1164, 558)
        Me.KryptonPanel.TabIndex = 0
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.KryptonPanel1)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.KryptonGroup1)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(1164, 534)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(1164, 558)
        Me.ToolStripContainer1.TabIndex = 10
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.MenuStrip1)
        '
        'KryptonPanel1
        '
        Me.KryptonPanel1.Controls.Add(Me.splitOverall)
        Me.KryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonPanel1.Location = New System.Drawing.Point(0, 59)
        Me.KryptonPanel1.Name = "KryptonPanel1"
        Me.KryptonPanel1.Size = New System.Drawing.Size(1164, 475)
        Me.KryptonPanel1.TabIndex = 9
        '
        'splitOverall
        '
        Me.splitOverall.Cursor = System.Windows.Forms.Cursors.Default
        Me.splitOverall.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitOverall.Location = New System.Drawing.Point(0, 0)
        Me.splitOverall.Name = "splitOverall"
        '
        'splitOverall.Panel1
        '
        Me.splitOverall.Panel1.Controls.Add(Me.KryptonSplitContainer3)
        '
        'splitOverall.Panel2
        '
        Me.splitOverall.Panel2.Controls.Add(Me.lblStudentCount)
        Me.splitOverall.Panel2.Controls.Add(Me.lblRenumberAdminResetNumber)
        Me.splitOverall.Panel2.Controls.Add(Me.lblRenumberAdminCurrent)
        Me.splitOverall.Panel2.Controls.Add(Me.lblRenumberAdminCurrentLabel)
        Me.splitOverall.Panel2.Controls.Add(Me.splitStudentsSchedule)
        Me.splitOverall.Panel2.Controls.Add(Me.btnRemoveStudent)
        Me.splitOverall.Panel2.Controls.Add(Me.llblRemoveStudent)
        Me.splitOverall.Panel2.Controls.Add(Me.btnEditStudent)
        Me.splitOverall.Panel2.Controls.Add(Me.txtStudentFilter)
        Me.splitOverall.Panel2.Controls.Add(Me.btnSelectRandomStudent)
        Me.splitOverall.Panel2.Controls.Add(Me.llblMoveStudent)
        Me.splitOverall.Panel2.Controls.Add(Me.llblClearFilter)
        Me.splitOverall.Panel2.Controls.Add(Me.llblAddStudent)
        Me.splitOverall.Panel2.Controls.Add(Me.KryptonLabel2)
        Me.splitOverall.Size = New System.Drawing.Size(1164, 475)
        Me.splitOverall.SplitterDistance = 196
        Me.splitOverall.TabIndex = 28
        '
        'KryptonSplitContainer3
        '
        Me.KryptonSplitContainer3.Cursor = System.Windows.Forms.Cursors.Default
        Me.KryptonSplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonSplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.KryptonSplitContainer3.Name = "KryptonSplitContainer3"
        Me.KryptonSplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'KryptonSplitContainer3.Panel1
        '
        Me.KryptonSplitContainer3.Panel1.Controls.Add(Me.lstClassGroups)
        Me.KryptonSplitContainer3.Panel1.Controls.Add(Me.llblRemoveClassGroup)
        Me.KryptonSplitContainer3.Panel1.Controls.Add(Me.llblEditClassGroup)
        Me.KryptonSplitContainer3.Panel1.Controls.Add(Me.llblAddClassGroup)
        Me.KryptonSplitContainer3.Panel1.Controls.Add(Me.KryptonLabel11)
        '
        'KryptonSplitContainer3.Panel2
        '
        Me.KryptonSplitContainer3.Panel2.Controls.Add(Me.KryptonSplitContainer1)
        Me.KryptonSplitContainer3.Size = New System.Drawing.Size(196, 475)
        Me.KryptonSplitContainer3.SplitterDistance = 157
        Me.KryptonSplitContainer3.TabIndex = 28
        '
        'lstClassGroups
        '
        Me.lstClassGroups.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstClassGroups.Location = New System.Drawing.Point(0, 20)
        Me.lstClassGroups.Name = "lstClassGroups"
        Me.lstClassGroups.Palette = Me.KryptonPalette1
        Me.lstClassGroups.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.lstClassGroups.Size = New System.Drawing.Size(196, 137)
        Me.lstClassGroups.TabIndex = 28
        '
        'llblRemoveClassGroup
        '
        Me.llblRemoveClassGroup.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.llblRemoveClassGroup.Location = New System.Drawing.Point(171, 3)
        Me.llblRemoveClassGroup.Name = "llblRemoveClassGroup"
        Me.llblRemoveClassGroup.Size = New System.Drawing.Size(22, 18)
        Me.llblRemoveClassGroup.TabIndex = 27
        Me.ToolTip1.SetToolTip(Me.llblRemoveClassGroup, "Delete selected class")
        Me.llblRemoveClassGroup.Values.Image = Global.Teaching.My.Resources.Resources.remove_icon_16
        Me.llblRemoveClassGroup.Values.Text = ""
        '
        'llblEditClassGroup
        '
        Me.llblEditClassGroup.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.llblEditClassGroup.Location = New System.Drawing.Point(115, 3)
        Me.llblEditClassGroup.Name = "llblEditClassGroup"
        Me.llblEditClassGroup.Size = New System.Drawing.Size(22, 18)
        Me.llblEditClassGroup.TabIndex = 26
        Me.ToolTip1.SetToolTip(Me.llblEditClassGroup, "Edit selected class")
        Me.llblEditClassGroup.Values.Image = Global.Teaching.My.Resources.Resources.AutoText_16
        Me.llblEditClassGroup.Values.Text = ""
        '
        'llblAddClassGroup
        '
        Me.llblAddClassGroup.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.llblAddClassGroup.Location = New System.Drawing.Point(143, 3)
        Me.llblAddClassGroup.Name = "llblAddClassGroup"
        Me.llblAddClassGroup.Size = New System.Drawing.Size(22, 18)
        Me.llblAddClassGroup.TabIndex = 25
        Me.ToolTip1.SetToolTip(Me.llblAddClassGroup, "Add new class")
        Me.llblAddClassGroup.Values.Image = Global.Teaching.My.Resources.Resources.add_icon_16
        Me.llblAddClassGroup.Values.Text = ""
        '
        'KryptonLabel11
        '
        Me.KryptonLabel11.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonLabel11.Location = New System.Drawing.Point(0, 0)
        Me.KryptonLabel11.Name = "KryptonLabel11"
        Me.KryptonLabel11.Palette = Me.KryptonPalette1
        Me.KryptonLabel11.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.KryptonLabel11.Size = New System.Drawing.Size(196, 20)
        Me.KryptonLabel11.TabIndex = 3
        Me.KryptonLabel11.Values.Text = "Module"
        '
        'KryptonSplitContainer1
        '
        Me.KryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.KryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KryptonSplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonSplitContainer1.Name = "KryptonSplitContainer1"
        Me.KryptonSplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'KryptonSplitContainer1.Panel1
        '
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.llblRemoveClass)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.btnEditClass)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.lstClasses)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.btnAddClass)
        Me.KryptonSplitContainer1.Panel1.Controls.Add(Me.KryptonLabel10)
        '
        'KryptonSplitContainer1.Panel2
        '
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.llblRemoveAssignment)
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.llblEditAssignment)
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.llblAddAssignment)
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.lstAssignments)
        Me.KryptonSplitContainer1.Panel2.Controls.Add(Me.KryptonLabel1)
        Me.KryptonSplitContainer1.Size = New System.Drawing.Size(196, 313)
        Me.KryptonSplitContainer1.SplitterDistance = 139
        Me.KryptonSplitContainer1.TabIndex = 27
        '
        'llblRemoveClass
        '
        Me.llblRemoveClass.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.llblRemoveClass.Location = New System.Drawing.Point(173, 0)
        Me.llblRemoveClass.Name = "llblRemoveClass"
        Me.llblRemoveClass.Size = New System.Drawing.Size(22, 18)
        Me.llblRemoveClass.TabIndex = 24
        Me.ToolTip1.SetToolTip(Me.llblRemoveClass, "Delete selected class")
        Me.llblRemoveClass.Values.Image = Global.Teaching.My.Resources.Resources.remove_icon_16
        Me.llblRemoveClass.Values.Text = ""
        '
        'btnEditClass
        '
        Me.btnEditClass.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditClass.Location = New System.Drawing.Point(117, 0)
        Me.btnEditClass.Name = "btnEditClass"
        Me.btnEditClass.Size = New System.Drawing.Size(22, 18)
        Me.btnEditClass.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.btnEditClass, "Edit selected class")
        Me.btnEditClass.Values.Image = Global.Teaching.My.Resources.Resources.AutoText_16
        Me.btnEditClass.Values.Text = ""
        '
        'lstClasses
        '
        Me.lstClasses.ContextMenuStrip = Me.ctxmnuClasses
        Me.lstClasses.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstClasses.Location = New System.Drawing.Point(0, 20)
        Me.lstClasses.Name = "lstClasses"
        Me.lstClasses.Palette = Me.KryptonPalette1
        Me.lstClasses.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.lstClasses.Size = New System.Drawing.Size(196, 119)
        Me.lstClasses.TabIndex = 0
        '
        'ctxmnuClasses
        '
        Me.ctxmnuClasses.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ctxmnuClasses.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditClassToolStripMenuItem, Me.DeleteClassToolStripMenuItem, Me.ToolStripSeparator13, Me.StatisticsToolStripMenuItem, Me.EmailclassToolStripMenuItem})
        Me.ctxmnuClasses.Name = "ctxmnuStudents"
        Me.ctxmnuClasses.Size = New System.Drawing.Size(141, 98)
        '
        'EditClassToolStripMenuItem
        '
        Me.EditClassToolStripMenuItem.Name = "EditClassToolStripMenuItem"
        Me.EditClassToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.EditClassToolStripMenuItem.Text = "&Edit class..."
        '
        'DeleteClassToolStripMenuItem
        '
        Me.DeleteClassToolStripMenuItem.Image = Global.Teaching.My.Resources.Resources.erase_16
        Me.DeleteClassToolStripMenuItem.Name = "DeleteClassToolStripMenuItem"
        Me.DeleteClassToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.DeleteClassToolStripMenuItem.Text = "&Delete class"
        '
        'ToolStripSeparator13
        '
        Me.ToolStripSeparator13.Name = "ToolStripSeparator13"
        Me.ToolStripSeparator13.Size = New System.Drawing.Size(137, 6)
        '
        'StatisticsToolStripMenuItem
        '
        Me.StatisticsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StudentsToolStripMenuItem, Me.HiddenStudentsToolStripMenuItem, Me.VisibleStudentsToolStripMenuItem, Me.ToolStripSeparator14, Me.RemoveAllStudentsToolStripMenuItem})
        Me.StatisticsToolStripMenuItem.Name = "StatisticsToolStripMenuItem"
        Me.StatisticsToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.StatisticsToolStripMenuItem.Text = "&Statistics"
        '
        'StudentsToolStripMenuItem
        '
        Me.StudentsToolStripMenuItem.Name = "StudentsToolStripMenuItem"
        Me.StudentsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.StudentsToolStripMenuItem.Text = "Total students: "
        '
        'HiddenStudentsToolStripMenuItem
        '
        Me.HiddenStudentsToolStripMenuItem.Name = "HiddenStudentsToolStripMenuItem"
        Me.HiddenStudentsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.HiddenStudentsToolStripMenuItem.Text = "Hidden students:"
        '
        'VisibleStudentsToolStripMenuItem
        '
        Me.VisibleStudentsToolStripMenuItem.Name = "VisibleStudentsToolStripMenuItem"
        Me.VisibleStudentsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.VisibleStudentsToolStripMenuItem.Text = "Visible students:"
        '
        'ToolStripSeparator14
        '
        Me.ToolStripSeparator14.Name = "ToolStripSeparator14"
        Me.ToolStripSeparator14.Size = New System.Drawing.Size(177, 6)
        '
        'RemoveAllStudentsToolStripMenuItem
        '
        Me.RemoveAllStudentsToolStripMenuItem.Name = "RemoveAllStudentsToolStripMenuItem"
        Me.RemoveAllStudentsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RemoveAllStudentsToolStripMenuItem.Text = "Remove all students"
        '
        'EmailclassToolStripMenuItem
        '
        Me.EmailclassToolStripMenuItem.Image = Global.Teaching.My.Resources.Resources.e_mail_16
        Me.EmailclassToolStripMenuItem.Name = "EmailclassToolStripMenuItem"
        Me.EmailclassToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
        Me.EmailclassToolStripMenuItem.Text = "Email &class..."
        '
        'btnAddClass
        '
        Me.btnAddClass.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddClass.Location = New System.Drawing.Point(145, 0)
        Me.btnAddClass.Name = "btnAddClass"
        Me.btnAddClass.Size = New System.Drawing.Size(22, 18)
        Me.btnAddClass.TabIndex = 21
        Me.ToolTip1.SetToolTip(Me.btnAddClass, "Add new class")
        Me.btnAddClass.Values.Image = Global.Teaching.My.Resources.Resources.add_icon_16
        Me.btnAddClass.Values.Text = ""
        '
        'KryptonLabel10
        '
        Me.KryptonLabel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonLabel10.Location = New System.Drawing.Point(0, 0)
        Me.KryptonLabel10.Name = "KryptonLabel10"
        Me.KryptonLabel10.Palette = Me.KryptonPalette1
        Me.KryptonLabel10.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.KryptonLabel10.Size = New System.Drawing.Size(196, 20)
        Me.KryptonLabel10.TabIndex = 2
        Me.KryptonLabel10.Values.Text = "Classes"
        '
        'llblRemoveAssignment
        '
        Me.llblRemoveAssignment.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.llblRemoveAssignment.Location = New System.Drawing.Point(171, 2)
        Me.llblRemoveAssignment.Name = "llblRemoveAssignment"
        Me.llblRemoveAssignment.Size = New System.Drawing.Size(22, 18)
        Me.llblRemoveAssignment.TabIndex = 27
        Me.ToolTip1.SetToolTip(Me.llblRemoveAssignment, "Delete selected asignment")
        Me.llblRemoveAssignment.Values.Image = Global.Teaching.My.Resources.Resources.remove_icon_16
        Me.llblRemoveAssignment.Values.Text = ""
        '
        'llblEditAssignment
        '
        Me.llblEditAssignment.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.llblEditAssignment.Location = New System.Drawing.Point(115, 2)
        Me.llblEditAssignment.Name = "llblEditAssignment"
        Me.llblEditAssignment.Size = New System.Drawing.Size(22, 18)
        Me.llblEditAssignment.TabIndex = 26
        Me.ToolTip1.SetToolTip(Me.llblEditAssignment, "Edit selected assignment")
        Me.llblEditAssignment.Values.Image = Global.Teaching.My.Resources.Resources.AutoText_16
        Me.llblEditAssignment.Values.Text = ""
        '
        'llblAddAssignment
        '
        Me.llblAddAssignment.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.llblAddAssignment.Location = New System.Drawing.Point(143, 2)
        Me.llblAddAssignment.Name = "llblAddAssignment"
        Me.llblAddAssignment.Size = New System.Drawing.Size(22, 18)
        Me.llblAddAssignment.TabIndex = 25
        Me.ToolTip1.SetToolTip(Me.llblAddAssignment, "Add new assignment")
        Me.llblAddAssignment.Values.Image = Global.Teaching.My.Resources.Resources.add_icon_16
        Me.llblAddAssignment.Values.Text = ""
        '
        'lstAssignments
        '
        Me.lstAssignments.ContextMenuStrip = Me.ctxmnuAssignment
        Me.lstAssignments.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstAssignments.Location = New System.Drawing.Point(0, 20)
        Me.lstAssignments.Name = "lstAssignments"
        Me.lstAssignments.Palette = Me.KryptonPalette1
        Me.lstAssignments.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.lstAssignments.Size = New System.Drawing.Size(196, 149)
        Me.lstAssignments.TabIndex = 4
        '
        'ctxmnuAssignment
        '
        Me.ctxmnuAssignment.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ctxmnuAssignment.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyAssignmentToolStripMenuItem, Me.PasteNewAssignmentToolStripMenuItem, Me.ToolStripSeparator1, Me.CreateNewAssignmentToolStripMenuItem, Me.EditSelectedAssignmentToolStripMenuItem, Me.DeleteSelectedAssignmentToolStripMenuItem, Me.ToolStripSeparator10, Me.CloseAssignmentToolStripMenuItem1, Me.ToolStripSeparator12, Me.AssignmentMoveUpToolStripMenuItem, Me.AssignmentMoveDownToolStripMenuItem})
        Me.ctxmnuAssignment.Name = "ctxmnuClass"
        Me.ctxmnuAssignment.Size = New System.Drawing.Size(198, 198)
        '
        'CopyAssignmentToolStripMenuItem
        '
        Me.CopyAssignmentToolStripMenuItem.Name = "CopyAssignmentToolStripMenuItem"
        Me.CopyAssignmentToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.CopyAssignmentToolStripMenuItem.Text = "&Copy assignment"
        '
        'PasteNewAssignmentToolStripMenuItem
        '
        Me.PasteNewAssignmentToolStripMenuItem.Name = "PasteNewAssignmentToolStripMenuItem"
        Me.PasteNewAssignmentToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.PasteNewAssignmentToolStripMenuItem.Text = "&Paste new assignment"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(194, 6)
        '
        'CreateNewAssignmentToolStripMenuItem
        '
        Me.CreateNewAssignmentToolStripMenuItem.Name = "CreateNewAssignmentToolStripMenuItem"
        Me.CreateNewAssignmentToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.CreateNewAssignmentToolStripMenuItem.Text = "Create new assignment"
        '
        'EditSelectedAssignmentToolStripMenuItem
        '
        Me.EditSelectedAssignmentToolStripMenuItem.Name = "EditSelectedAssignmentToolStripMenuItem"
        Me.EditSelectedAssignmentToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.EditSelectedAssignmentToolStripMenuItem.Text = "Edit assignment"
        '
        'DeleteSelectedAssignmentToolStripMenuItem
        '
        Me.DeleteSelectedAssignmentToolStripMenuItem.Name = "DeleteSelectedAssignmentToolStripMenuItem"
        Me.DeleteSelectedAssignmentToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.DeleteSelectedAssignmentToolStripMenuItem.Text = "Delete assignment"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(194, 6)
        '
        'CloseAssignmentToolStripMenuItem1
        '
        Me.CloseAssignmentToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseAssignment1stToolStripMenuItem, Me.CloseAssignment2ndToolStripMenuItem, Me.CloseAssignment3rdToolStripMenuItem})
        Me.CloseAssignmentToolStripMenuItem1.Name = "CloseAssignmentToolStripMenuItem1"
        Me.CloseAssignmentToolStripMenuItem1.Size = New System.Drawing.Size(197, 22)
        Me.CloseAssignmentToolStripMenuItem1.Text = "Close assignment"
        '
        'CloseAssignment1stToolStripMenuItem
        '
        Me.CloseAssignment1stToolStripMenuItem.Name = "CloseAssignment1stToolStripMenuItem"
        Me.CloseAssignment1stToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.CloseAssignment1stToolStripMenuItem.Text = "&First submission"
        '
        'CloseAssignment2ndToolStripMenuItem
        '
        Me.CloseAssignment2ndToolStripMenuItem.Name = "CloseAssignment2ndToolStripMenuItem"
        Me.CloseAssignment2ndToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.CloseAssignment2ndToolStripMenuItem.Text = "&Second submission"
        '
        'CloseAssignment3rdToolStripMenuItem
        '
        Me.CloseAssignment3rdToolStripMenuItem.Name = "CloseAssignment3rdToolStripMenuItem"
        Me.CloseAssignment3rdToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.CloseAssignment3rdToolStripMenuItem.Text = "&Third submission"
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(194, 6)
        '
        'AssignmentMoveUpToolStripMenuItem
        '
        Me.AssignmentMoveUpToolStripMenuItem.Name = "AssignmentMoveUpToolStripMenuItem"
        Me.AssignmentMoveUpToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.AssignmentMoveUpToolStripMenuItem.Text = "Move &up"
        '
        'AssignmentMoveDownToolStripMenuItem
        '
        Me.AssignmentMoveDownToolStripMenuItem.Name = "AssignmentMoveDownToolStripMenuItem"
        Me.AssignmentMoveDownToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.AssignmentMoveDownToolStripMenuItem.Text = "Move &down"
        '
        'KryptonLabel1
        '
        Me.KryptonLabel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonLabel1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonLabel1.Name = "KryptonLabel1"
        Me.KryptonLabel1.Palette = Me.KryptonPalette1
        Me.KryptonLabel1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.KryptonLabel1.Size = New System.Drawing.Size(196, 20)
        Me.KryptonLabel1.TabIndex = 3
        Me.KryptonLabel1.Values.Text = "Assignments"
        '
        'lblStudentCount
        '
        Me.lblStudentCount.Location = New System.Drawing.Point(221, 0)
        Me.lblStudentCount.Name = "lblStudentCount"
        Me.lblStudentCount.Palette = Me.KryptonPalette1
        Me.lblStudentCount.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.lblStudentCount.Size = New System.Drawing.Size(6, 2)
        Me.lblStudentCount.TabIndex = 32
        Me.lblStudentCount.Values.Text = ""
        '
        'lblRenumberAdminResetNumber
        '
        Me.lblRenumberAdminResetNumber.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRenumberAdminResetNumber.Location = New System.Drawing.Point(617, 0)
        Me.lblRenumberAdminResetNumber.Name = "lblRenumberAdminResetNumber"
        Me.lblRenumberAdminResetNumber.Palette = Me.KryptonPalette1
        Me.lblRenumberAdminResetNumber.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.lblRenumberAdminResetNumber.Size = New System.Drawing.Size(94, 20)
        Me.lblRenumberAdminResetNumber.TabIndex = 31
        Me.lblRenumberAdminResetNumber.Values.Text = "Reset all to 999"
        Me.lblRenumberAdminResetNumber.Visible = False
        '
        'lblRenumberAdminCurrent
        '
        Me.lblRenumberAdminCurrent.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRenumberAdminCurrent.Location = New System.Drawing.Point(557, 0)
        Me.lblRenumberAdminCurrent.Name = "lblRenumberAdminCurrent"
        Me.lblRenumberAdminCurrent.Palette = Me.KryptonPalette1
        Me.lblRenumberAdminCurrent.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.lblRenumberAdminCurrent.Size = New System.Drawing.Size(54, 20)
        Me.lblRenumberAdminCurrent.TabIndex = 30
        Me.lblRenumberAdminCurrent.Values.Text = "Current:"
        Me.lblRenumberAdminCurrent.Visible = False
        '
        'lblRenumberAdminCurrentLabel
        '
        Me.lblRenumberAdminCurrentLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblRenumberAdminCurrentLabel.Location = New System.Drawing.Point(504, -1)
        Me.lblRenumberAdminCurrentLabel.Name = "lblRenumberAdminCurrentLabel"
        Me.lblRenumberAdminCurrentLabel.Palette = Me.KryptonPalette1
        Me.lblRenumberAdminCurrentLabel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.lblRenumberAdminCurrentLabel.Size = New System.Drawing.Size(54, 20)
        Me.lblRenumberAdminCurrentLabel.TabIndex = 29
        Me.lblRenumberAdminCurrentLabel.Values.Text = "Current:"
        Me.lblRenumberAdminCurrentLabel.Visible = False
        '
        'splitStudentsSchedule
        '
        Me.splitStudentsSchedule.Cursor = System.Windows.Forms.Cursors.Default
        Me.splitStudentsSchedule.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitStudentsSchedule.Location = New System.Drawing.Point(0, 20)
        Me.splitStudentsSchedule.Name = "splitStudentsSchedule"
        Me.splitStudentsSchedule.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitStudentsSchedule.Panel1
        '
        Me.splitStudentsSchedule.Panel1.Controls.Add(Me.olvStudents)
        '
        'splitStudentsSchedule.Panel2
        '
        Me.splitStudentsSchedule.Panel2.Controls.Add(Me.ScheduleNotesSplitter)
        Me.splitStudentsSchedule.Panel2.Controls.Add(Me.KryptonPanel2)
        Me.splitStudentsSchedule.Size = New System.Drawing.Size(963, 455)
        Me.splitStudentsSchedule.SplitterDistance = 230
        Me.splitStudentsSchedule.TabIndex = 28
        '
        'olvStudents
        '
        Me.olvStudents.AllColumns.Add(Me.OlvColumn4)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn11)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn1)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn2)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn3)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn5)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn6)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn8)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn7)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn9)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn18)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn10)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn20)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn12)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn13)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn14)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn15)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn19)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn21)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn22)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn23)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn24)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn25)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn26)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn27)
        Me.olvStudents.AllColumns.Add(Me.OlvColumn28)
        Me.olvStudents.AllowColumnReorder = True
        Me.olvStudents.AlternateRowBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.olvStudents.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick
        Me.olvStudents.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumn4, Me.OlvColumn11, Me.OlvColumn1, Me.OlvColumn2, Me.OlvColumn3, Me.OlvColumn5, Me.OlvColumn6, Me.OlvColumn8, Me.OlvColumn7, Me.OlvColumn9, Me.OlvColumn18, Me.OlvColumn10, Me.OlvColumn20, Me.OlvColumn12, Me.OlvColumn13, Me.OlvColumn14, Me.OlvColumn15, Me.OlvColumn19, Me.OlvColumn21, Me.OlvColumn22, Me.OlvColumn23, Me.OlvColumn24, Me.OlvColumn25, Me.OlvColumn26, Me.OlvColumn27, Me.OlvColumn28})
        Me.olvStudents.ContextMenuStrip = Me.ctxmnuStudents
        Me.olvStudents.CopySelectionOnControlC = False
        Me.olvStudents.CopySelectionOnControlCUsesDragSource = False
        Me.olvStudents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.olvStudents.EmptyListMsg = "This class is empty"
        Me.olvStudents.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.olvStudents.FullRowSelect = True
        Me.olvStudents.GridLines = True
        Me.olvStudents.HideSelection = False
        Me.olvStudents.Location = New System.Drawing.Point(0, 0)
        Me.olvStudents.Name = "olvStudents"
        Me.olvStudents.OwnerDraw = True
        Me.olvStudents.SelectAllOnControlA = False
        Me.olvStudents.ShowCommandMenuOnRightClick = True
        Me.olvStudents.ShowGroups = False
        Me.olvStudents.ShowImagesOnSubItems = True
        Me.olvStudents.ShowItemCountOnGroups = True
        Me.olvStudents.Size = New System.Drawing.Size(963, 230)
        Me.olvStudents.TabIndex = 3
        Me.olvStudents.UseAlternatingBackColors = True
        Me.olvStudents.UseCompatibleStateImageBehavior = False
        Me.olvStudents.UseFiltering = True
        Me.olvStudents.UseSubItemCheckBoxes = True
        Me.olvStudents.View = System.Windows.Forms.View.Details
        '
        'OlvColumn4
        '
        Me.OlvColumn4.AspectName = "AdminNumber"
        Me.OlvColumn4.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn4.Text = "Admin"
        Me.OlvColumn4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OlvColumn11
        '
        Me.OlvColumn11.AspectName = "AltNumber"
        Me.OlvColumn11.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn11.Text = "Alt"
        Me.OlvColumn11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn11.ToolTipText = "Alternate number"
        '
        'OlvColumn1
        '
        Me.OlvColumn1.AspectName = "LocalName"
        Me.OlvColumn1.Text = "Name"
        Me.OlvColumn1.Width = 150
        '
        'OlvColumn2
        '
        Me.OlvColumn2.AspectName = "Nickname"
        Me.OlvColumn2.Text = "Nickname"
        Me.OlvColumn2.Width = 108
        '
        'OlvColumn3
        '
        Me.OlvColumn3.AspectName = "StudentID"
        Me.OlvColumn3.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn3.Text = "Student ID"
        Me.OlvColumn3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn3.Width = 90
        '
        'OlvColumn5
        '
        Me.OlvColumn5.AspectName = "MeritPoints"
        Me.OlvColumn5.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn5.Text = "Merit"
        Me.OlvColumn5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn5.Width = 50
        '
        'OlvColumn6
        '
        Me.OlvColumn6.AspectName = "CurrentAbsences"
        Me.OlvColumn6.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn6.IsEditable = False
        Me.OlvColumn6.Text = "Abs"
        Me.OlvColumn6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn6.ToolTipText = "Absences for current period"
        Me.OlvColumn6.Width = 50
        '
        'OlvColumn8
        '
        Me.OlvColumn8.AspectName = "TotalAbsences"
        Me.OlvColumn8.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn8.IsEditable = False
        Me.OlvColumn8.Text = "Total"
        Me.OlvColumn8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn8.ToolTipText = "Total absences for semester"
        Me.OlvColumn8.Width = 50
        '
        'OlvColumn7
        '
        Me.OlvColumn7.AspectName = "Hidden"
        Me.OlvColumn7.CheckBoxes = True
        Me.OlvColumn7.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn7.IsEditable = False
        Me.OlvColumn7.Text = "Hid"
        Me.OlvColumn7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn7.Width = 40
        '
        'OlvColumn9
        '
        Me.OlvColumn9.AspectName = "PresentationQuality"
        Me.OlvColumn9.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn9.Text = "Pres"
        Me.OlvColumn9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OlvColumn18
        '
        Me.OlvColumn18.AspectName = "WritingQuality"
        Me.OlvColumn18.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn18.Text = "Write"
        Me.OlvColumn18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OlvColumn10
        '
        Me.OlvColumn10.AspectName = "AssignmentCount"
        Me.OlvColumn10.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn10.IsEditable = False
        Me.OlvColumn10.Text = "Asmt"
        Me.OlvColumn10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn10.ToolTipText = "Number of assignments"
        Me.OlvColumn10.Width = 50
        '
        'OlvColumn20
        '
        Me.OlvColumn20.AspectName = "ProcessedAssignments"
        Me.OlvColumn20.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn20.IsEditable = False
        Me.OlvColumn20.Text = "P.Asmts"
        Me.OlvColumn20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn20.Width = 80
        '
        'OlvColumn12
        '
        Me.OlvColumn12.AspectName = "LatestAttendenceStatus"
        Me.OlvColumn12.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn12.Text = "Status"
        Me.OlvColumn12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn12.Width = 100
        '
        'OlvColumn13
        '
        Me.OlvColumn13.AspectName = "Tags"
        Me.OlvColumn13.Text = "Tags"
        '
        'OlvColumn14
        '
        Me.OlvColumn14.AspectName = "EmailAddress"
        Me.OlvColumn14.IsEditable = False
        Me.OlvColumn14.Text = "Email"
        Me.OlvColumn14.ToolTipText = "Student's email address"
        '
        'OlvColumn15
        '
        Me.OlvColumn15.AspectName = "LocalNameLatinLetters"
        Me.OlvColumn15.IsEditable = False
        Me.OlvColumn15.Text = "Standard"
        Me.OlvColumn15.Width = 150
        '
        'OlvColumn19
        '
        Me.OlvColumn19.AspectName = "SchoolClass.Name"
        Me.OlvColumn19.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn19.IsEditable = False
        Me.OlvColumn19.Text = "Class"
        Me.OlvColumn19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn19.Width = 120
        '
        'OlvColumn21
        '
        Me.OlvColumn21.AspectName = "ExtStudentID"
        Me.OlvColumn21.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn21.Text = "Ext ID"
        Me.OlvColumn21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn21.ToolTipText = "External ID (extra ID)"
        '
        'OlvColumn22
        '
        Me.OlvColumn22.AspectName = "PlagiarismSeverity"
        Me.OlvColumn22.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn22.Text = "Plag"
        Me.OlvColumn22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OlvColumn23
        '
        Me.OlvColumn23.AspectName = "TotalExcused"
        Me.OlvColumn23.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn23.IsEditable = False
        Me.OlvColumn23.Text = "Excu"
        Me.OlvColumn23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn23.ToolTipText = "Total excused absences"
        '
        'OlvColumn24
        '
        Me.OlvColumn24.AspectName = "Gender"
        Me.OlvColumn24.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn24.Text = "Gender"
        Me.OlvColumn24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OlvColumn25
        '
        Me.OlvColumn25.AspectName = "StudentGroup"
        Me.OlvColumn25.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn25.Text = "Group"
        Me.OlvColumn25.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn25.ToolTipText = "Student group is used for scheduling purposes"
        '
        'OlvColumn26
        '
        Me.OlvColumn26.AspectName = "DraftsChecked"
        Me.OlvColumn26.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn26.Text = "Drafts"
        Me.OlvColumn26.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn26.ToolTipText = "Number of drafts checked"
        '
        'OlvColumn27
        '
        Me.OlvColumn27.AspectName = "OfficeHoursVisited"
        Me.OlvColumn27.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn27.Text = "OfficeHrs"
        Me.OlvColumn27.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn27.ToolTipText = "Number of times student attended office hours"
        '
        'OlvColumn28
        '
        Me.OlvColumn28.AspectName = "ResearchQuality"
        Me.OlvColumn28.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn28.Text = "Research"
        Me.OlvColumn28.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn28.ToolTipText = "Research quality of student"
        '
        'ctxmnuStudents
        '
        Me.ctxmnuStudents.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ctxmnuStudents.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditStudentToolStripMenuItem, Me.MeritToolStripMenuItem, Me.DemeritToolStripMenuItem, Me.ToolStripSeparator2, Me.ProcessExamForStudent, Me.ProcessExamRedoForStudent, Me.ProcessExam2ndReDoForStudent, Me.ToolStripSeparator8, Me.EmailstudentToolStripMenuItem})
        Me.ctxmnuStudents.Name = "ctxmnuStudents"
        Me.ctxmnuStudents.Size = New System.Drawing.Size(194, 170)
        '
        'EditStudentToolStripMenuItem
        '
        Me.EditStudentToolStripMenuItem.Name = "EditStudentToolStripMenuItem"
        Me.EditStudentToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.EditStudentToolStripMenuItem.Text = "&Edit student..."
        '
        'MeritToolStripMenuItem
        '
        Me.MeritToolStripMenuItem.Name = "MeritToolStripMenuItem"
        Me.MeritToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.MeritToolStripMenuItem.Text = "&Merit"
        '
        'DemeritToolStripMenuItem
        '
        Me.DemeritToolStripMenuItem.Name = "DemeritToolStripMenuItem"
        Me.DemeritToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.DemeritToolStripMenuItem.Text = "&Demerit"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(190, 6)
        '
        'ProcessExamForStudent
        '
        Me.ProcessExamForStudent.Name = "ProcessExamForStudent"
        Me.ProcessExamForStudent.Size = New System.Drawing.Size(193, 22)
        Me.ProcessExamForStudent.Text = "Mar&k Assignment (1st)"
        '
        'ProcessExamRedoForStudent
        '
        Me.ProcessExamRedoForStudent.Name = "ProcessExamRedoForStudent"
        Me.ProcessExamRedoForStudent.Size = New System.Drawing.Size(193, 22)
        Me.ProcessExamRedoForStudent.Text = "Mark &Rework"
        '
        'ProcessExam2ndReDoForStudent
        '
        Me.ProcessExam2ndReDoForStudent.Name = "ProcessExam2ndReDoForStudent"
        Me.ProcessExam2ndReDoForStudent.Size = New System.Drawing.Size(193, 22)
        Me.ProcessExam2ndReDoForStudent.Text = "Mark &2nd Rework"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(190, 6)
        '
        'EmailstudentToolStripMenuItem
        '
        Me.EmailstudentToolStripMenuItem.Image = Global.Teaching.My.Resources.Resources.e_mail_16
        Me.EmailstudentToolStripMenuItem.Name = "EmailstudentToolStripMenuItem"
        Me.EmailstudentToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.EmailstudentToolStripMenuItem.Text = "Email &student"
        '
        'ScheduleNotesSplitter
        '
        Me.ScheduleNotesSplitter.Cursor = System.Windows.Forms.Cursors.Default
        Me.ScheduleNotesSplitter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ScheduleNotesSplitter.Location = New System.Drawing.Point(96, 0)
        Me.ScheduleNotesSplitter.Name = "ScheduleNotesSplitter"
        '
        'ScheduleNotesSplitter.Panel1
        '
        Me.ScheduleNotesSplitter.Panel1.Controls.Add(Me.olvSchedule)
        '
        'ScheduleNotesSplitter.Panel2
        '
        Me.ScheduleNotesSplitter.Panel2.Controls.Add(Me.Panel1)
        Me.ScheduleNotesSplitter.Panel2.Controls.Add(Me.picStudent)
        Me.ScheduleNotesSplitter.Size = New System.Drawing.Size(867, 220)
        Me.ScheduleNotesSplitter.SplitterDistance = 632
        Me.ScheduleNotesSplitter.TabIndex = 45
        '
        'olvSchedule
        '
        Me.olvSchedule.AllColumns.Add(Me.OlvColumn29)
        Me.olvSchedule.AllColumns.Add(Me.OlvColumn30)
        Me.olvSchedule.AllColumns.Add(Me.OlvColumn16)
        Me.olvSchedule.AllColumns.Add(Me.OlvColumn31)
        Me.olvSchedule.AllColumns.Add(Me.OlvColumn33)
        Me.olvSchedule.AllColumns.Add(Me.OlvColumn32)
        Me.olvSchedule.AllColumns.Add(Me.OlvColumn17)
        Me.olvSchedule.AllColumns.Add(Me.OlvColumn34)
        Me.olvSchedule.AllColumns.Add(Me.OlvColumn35)
        Me.olvSchedule.AllColumns.Add(Me.OlvColumn36)
        Me.olvSchedule.AllowColumnReorder = True
        Me.olvSchedule.AlternateRowBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.olvSchedule.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick
        Me.olvSchedule.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumn29, Me.OlvColumn30, Me.OlvColumn16, Me.OlvColumn31, Me.OlvColumn33, Me.OlvColumn32, Me.OlvColumn17, Me.OlvColumn34, Me.OlvColumn35, Me.OlvColumn36})
        Me.olvSchedule.ContextMenuStrip = Me.ctxmnuActualSessions
        Me.olvSchedule.CopySelectionOnControlC = False
        Me.olvSchedule.CopySelectionOnControlCUsesDragSource = False
        Me.olvSchedule.Dock = System.Windows.Forms.DockStyle.Fill
        Me.olvSchedule.EmptyListMsg = "Nothing scheduled for this day"
        Me.olvSchedule.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.olvSchedule.FullRowSelect = True
        Me.olvSchedule.GridLines = True
        Me.olvSchedule.HasCollapsibleGroups = False
        Me.olvSchedule.HideSelection = False
        Me.olvSchedule.Location = New System.Drawing.Point(0, 0)
        Me.olvSchedule.MultiSelect = False
        Me.olvSchedule.Name = "olvSchedule"
        Me.olvSchedule.OwnerDraw = True
        Me.olvSchedule.SelectAllOnControlA = False
        Me.olvSchedule.ShowGroups = False
        Me.olvSchedule.ShowImagesOnSubItems = True
        Me.olvSchedule.ShowItemCountOnGroups = True
        Me.olvSchedule.Size = New System.Drawing.Size(632, 220)
        Me.olvSchedule.TabIndex = 4
        Me.olvSchedule.UseAlternatingBackColors = True
        Me.olvSchedule.UseCompatibleStateImageBehavior = False
        Me.olvSchedule.UseFiltering = True
        Me.olvSchedule.UseSubItemCheckBoxes = True
        Me.olvSchedule.View = System.Windows.Forms.View.Details
        '
        'OlvColumn29
        '
        Me.OlvColumn29.AspectName = "StartDateTime.DayOfWeek"
        Me.OlvColumn29.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn29.Text = "Day"
        Me.OlvColumn29.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OlvColumn30
        '
        Me.OlvColumn30.AspectName = "StartDateTime"
        Me.OlvColumn30.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn30.Text = "Starts"
        Me.OlvColumn30.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn30.Width = 150
        '
        'OlvColumn16
        '
        Me.OlvColumn16.AspectName = "SchoolClass.ClassGroup.Name"
        Me.OlvColumn16.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn16.Text = "Module"
        Me.OlvColumn16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn16.Width = 100
        '
        'OlvColumn31
        '
        Me.OlvColumn31.AspectName = "SchoolClass"
        Me.OlvColumn31.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn31.Text = "Class"
        Me.OlvColumn31.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn31.Width = 117
        '
        'OlvColumn33
        '
        Me.OlvColumn33.AspectName = "SessionNumber"
        Me.OlvColumn33.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn33.Text = "Session"
        Me.OlvColumn33.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OlvColumn32
        '
        Me.OlvColumn32.AspectName = "Topic"
        Me.OlvColumn32.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn32.Text = "Topic"
        Me.OlvColumn32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn32.Width = 124
        '
        'OlvColumn17
        '
        Me.OlvColumn17.AspectName = "Location"
        Me.OlvColumn17.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn17.Text = "Location"
        Me.OlvColumn17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn17.Width = 75
        '
        'OlvColumn34
        '
        Me.OlvColumn34.AspectName = "Notes"
        Me.OlvColumn34.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn34.Text = "Notes"
        Me.OlvColumn34.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OlvColumn35
        '
        Me.OlvColumn35.AspectName = "Prepped"
        Me.OlvColumn35.CheckBoxes = True
        Me.OlvColumn35.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn35.Text = "Prepped"
        Me.OlvColumn35.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OlvColumn36
        '
        Me.OlvColumn36.AspectName = "StudentsEmailed"
        Me.OlvColumn36.CheckBoxes = True
        Me.OlvColumn36.HeaderTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.OlvColumn36.Text = "Sent"
        Me.OlvColumn36.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ctxmnuActualSessions
        '
        Me.ctxmnuActualSessions.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ctxmnuActualSessions.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SkipActualSessionToolStripMenuItem, Me.TakeAttendanceToolStripMenuItem, Me.LoadClassToolStripMenuItem})
        Me.ctxmnuActualSessions.Name = "ctxmnuPlannedSchedule"
        Me.ctxmnuActualSessions.Size = New System.Drawing.Size(184, 70)
        '
        'SkipActualSessionToolStripMenuItem
        '
        Me.SkipActualSessionToolStripMenuItem.Image = Global.Teaching.My.Resources.Resources.remove_icon_16
        Me.SkipActualSessionToolStripMenuItem.Name = "SkipActualSessionToolStripMenuItem"
        Me.SkipActualSessionToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.SkipActualSessionToolStripMenuItem.Text = "Skip selected session"
        '
        'TakeAttendanceToolStripMenuItem
        '
        Me.TakeAttendanceToolStripMenuItem.Name = "TakeAttendanceToolStripMenuItem"
        Me.TakeAttendanceToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.TakeAttendanceToolStripMenuItem.Text = "Take &attendance"
        '
        'LoadClassToolStripMenuItem
        '
        Me.LoadClassToolStripMenuItem.Name = "LoadClassToolStripMenuItem"
        Me.LoadClassToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.LoadClassToolStripMenuItem.Text = "Load &class"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.llblClearNotes)
        Me.Panel1.Controls.Add(Me.lblStopwatchDuration)
        Me.Panel1.Controls.Add(Me.llblStartPauseStopwatch)
        Me.Panel1.Controls.Add(Me.txtNotes)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(230, 220)
        Me.Panel1.TabIndex = 46
        '
        'llblClearNotes
        '
        Me.llblClearNotes.Location = New System.Drawing.Point(3, 11)
        Me.llblClearNotes.Name = "llblClearNotes"
        Me.llblClearNotes.Size = New System.Drawing.Size(22, 18)
        Me.llblClearNotes.TabIndex = 46
        Me.ToolTip1.SetToolTip(Me.llblClearNotes, "Clear filter")
        Me.llblClearNotes.Values.Image = Global.Teaching.My.Resources.Resources.simpleX_16
        Me.llblClearNotes.Values.Text = ""
        '
        'lblStopwatchDuration
        '
        Me.lblStopwatchDuration.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStopwatchDuration.LabelStyle = ComponentFactory.Krypton.Toolkit.LabelStyle.TitleControl
        Me.lblStopwatchDuration.Location = New System.Drawing.Point(147, 4)
        Me.lblStopwatchDuration.Name = "lblStopwatchDuration"
        Me.lblStopwatchDuration.Palette = Me.KryptonPalette1
        Me.lblStopwatchDuration.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.lblStopwatchDuration.Size = New System.Drawing.Size(76, 29)
        Me.lblStopwatchDuration.TabIndex = 45
        Me.lblStopwatchDuration.Values.Text = "0:00:00"
        '
        'llblStartPauseStopwatch
        '
        Me.llblStartPauseStopwatch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.llblStartPauseStopwatch.Location = New System.Drawing.Point(104, 1)
        Me.llblStartPauseStopwatch.Name = "llblStartPauseStopwatch"
        Me.llblStartPauseStopwatch.Size = New System.Drawing.Size(38, 34)
        Me.llblStartPauseStopwatch.TabIndex = 33
        Me.ToolTip1.SetToolTip(Me.llblStartPauseStopwatch, "Delete selected student from this class")
        Me.llblStartPauseStopwatch.Values.Image = Global.Teaching.My.Resources.Resources.play_32
        Me.llblStartPauseStopwatch.Values.Text = ""
        '
        'txtNotes
        '
        Me.txtNotes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNotes.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNotes.Location = New System.Drawing.Point(1, 35)
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNotes.Size = New System.Drawing.Size(230, 182)
        Me.txtNotes.TabIndex = 45
        Me.ToolTip1.SetToolTip(Me.txtNotes, "Notes")
        '
        'picStudent
        '
        Me.picStudent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picStudent.Location = New System.Drawing.Point(0, 0)
        Me.picStudent.Name = "picStudent"
        Me.picStudent.Size = New System.Drawing.Size(230, 220)
        Me.picStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picStudent.TabIndex = 44
        Me.picStudent.TabStop = False
        Me.picStudent.Visible = False
        '
        'KryptonPanel2
        '
        Me.KryptonPanel2.Controls.Add(Me.llblScheduleNextClassDay)
        Me.KryptonPanel2.Controls.Add(Me.llblScheduleNextUnprepped)
        Me.KryptonPanel2.Controls.Add(Me.lblScheduleDay)
        Me.KryptonPanel2.Controls.Add(Me.llblScheduleForwardOneDay)
        Me.KryptonPanel2.Controls.Add(Me.llblScheduleBackOneDay)
        Me.KryptonPanel2.Controls.Add(Me.dtpScheduleDate)
        Me.KryptonPanel2.Controls.Add(Me.llblRefreshSchedule)
        Me.KryptonPanel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.KryptonPanel2.Location = New System.Drawing.Point(0, 0)
        Me.KryptonPanel2.Name = "KryptonPanel2"
        Me.KryptonPanel2.Size = New System.Drawing.Size(96, 220)
        Me.KryptonPanel2.TabIndex = 5
        '
        'llblScheduleNextClassDay
        '
        Me.llblScheduleNextClassDay.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.llblScheduleNextClassDay.Location = New System.Drawing.Point(3, 108)
        Me.llblScheduleNextClassDay.Name = "llblScheduleNextClassDay"
        Me.llblScheduleNextClassDay.Size = New System.Drawing.Size(98, 19)
        Me.llblScheduleNextClassDay.TabIndex = 34
        Me.ToolTip1.SetToolTip(Me.llblScheduleNextClassDay, "Advance to next day with class")
        Me.llblScheduleNextClassDay.Values.ImageTransparentColor = System.Drawing.Color.White
        Me.llblScheduleNextClassDay.Values.Text = "Next class day"
        '
        'llblScheduleNextUnprepped
        '
        Me.llblScheduleNextUnprepped.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.llblScheduleNextUnprepped.Location = New System.Drawing.Point(3, 134)
        Me.llblScheduleNextUnprepped.Name = "llblScheduleNextUnprepped"
        Me.llblScheduleNextUnprepped.Size = New System.Drawing.Size(84, 19)
        Me.llblScheduleNextUnprepped.TabIndex = 33
        Me.ToolTip1.SetToolTip(Me.llblScheduleNextUnprepped, "Advance to next day with unprepped class")
        Me.llblScheduleNextUnprepped.Values.ImageTransparentColor = System.Drawing.Color.White
        Me.llblScheduleNextUnprepped.Values.Text = "Next unprep"
        '
        'lblScheduleDay
        '
        Me.lblScheduleDay.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblScheduleDay.Location = New System.Drawing.Point(20, 39)
        Me.lblScheduleDay.Name = "lblScheduleDay"
        Me.lblScheduleDay.Palette = Me.KryptonPalette1
        Me.lblScheduleDay.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.lblScheduleDay.Size = New System.Drawing.Size(6, 2)
        Me.lblScheduleDay.TabIndex = 32
        Me.lblScheduleDay.Values.Text = ""
        '
        'llblScheduleForwardOneDay
        '
        Me.llblScheduleForwardOneDay.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.llblScheduleForwardOneDay.Location = New System.Drawing.Point(62, 157)
        Me.llblScheduleForwardOneDay.Name = "llblScheduleForwardOneDay"
        Me.llblScheduleForwardOneDay.Size = New System.Drawing.Size(26, 19)
        Me.llblScheduleForwardOneDay.TabIndex = 31
        Me.ToolTip1.SetToolTip(Me.llblScheduleForwardOneDay, "Advance one day")
        Me.llblScheduleForwardOneDay.Values.ImageTransparentColor = System.Drawing.Color.White
        Me.llblScheduleForwardOneDay.Values.Text = ">>"
        '
        'llblScheduleBackOneDay
        '
        Me.llblScheduleBackOneDay.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.llblScheduleBackOneDay.Location = New System.Drawing.Point(3, 157)
        Me.llblScheduleBackOneDay.Name = "llblScheduleBackOneDay"
        Me.llblScheduleBackOneDay.Size = New System.Drawing.Size(26, 19)
        Me.llblScheduleBackOneDay.TabIndex = 30
        Me.ToolTip1.SetToolTip(Me.llblScheduleBackOneDay, "Go back one day")
        Me.llblScheduleBackOneDay.Values.ImageTransparentColor = System.Drawing.Color.White
        Me.llblScheduleBackOneDay.Values.Text = "<<"
        '
        'dtpScheduleDate
        '
        Me.dtpScheduleDate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpScheduleDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpScheduleDate.Location = New System.Drawing.Point(3, 12)
        Me.dtpScheduleDate.Name = "dtpScheduleDate"
        Me.dtpScheduleDate.Palette = Me.KryptonPalette1
        Me.dtpScheduleDate.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.dtpScheduleDate.Size = New System.Drawing.Size(90, 21)
        Me.dtpScheduleDate.TabIndex = 29
        '
        'llblRefreshSchedule
        '
        Me.llblRefreshSchedule.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.llblRefreshSchedule.Location = New System.Drawing.Point(23, 189)
        Me.llblRefreshSchedule.Name = "llblRefreshSchedule"
        Me.llblRefreshSchedule.Size = New System.Drawing.Size(58, 19)
        Me.llblRefreshSchedule.TabIndex = 28
        Me.ToolTip1.SetToolTip(Me.llblRefreshSchedule, "Refresh schedule for selected date")
        Me.llblRefreshSchedule.Values.ImageTransparentColor = System.Drawing.Color.White
        Me.llblRefreshSchedule.Values.Text = "Refresh"
        '
        'btnRemoveStudent
        '
        Me.btnRemoveStudent.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRemoveStudent.Location = New System.Drawing.Point(797, 2)
        Me.btnRemoveStudent.Name = "btnRemoveStudent"
        Me.btnRemoveStudent.Size = New System.Drawing.Size(22, 18)
        Me.btnRemoveStudent.TabIndex = 27
        Me.ToolTip1.SetToolTip(Me.btnRemoveStudent, "Mark selected student 'removed'")
        Me.btnRemoveStudent.Values.Image = Global.Teaching.My.Resources.Resources.anchor_16
        Me.btnRemoveStudent.Values.ImageTransparentColor = System.Drawing.Color.White
        Me.btnRemoveStudent.Values.Text = ""
        '
        'llblRemoveStudent
        '
        Me.llblRemoveStudent.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.llblRemoveStudent.Location = New System.Drawing.Point(934, 2)
        Me.llblRemoveStudent.Name = "llblRemoveStudent"
        Me.llblRemoveStudent.Size = New System.Drawing.Size(22, 18)
        Me.llblRemoveStudent.TabIndex = 16
        Me.ToolTip1.SetToolTip(Me.llblRemoveStudent, "Delete selected student from this class")
        Me.llblRemoveStudent.Values.Image = Global.Teaching.My.Resources.Resources.remove_icon_16
        Me.llblRemoveStudent.Values.Text = ""
        '
        'btnEditStudent
        '
        Me.btnEditStudent.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditStudent.Location = New System.Drawing.Point(853, 2)
        Me.btnEditStudent.Name = "btnEditStudent"
        Me.btnEditStudent.Size = New System.Drawing.Size(22, 18)
        Me.btnEditStudent.TabIndex = 23
        Me.ToolTip1.SetToolTip(Me.btnEditStudent, "Edit selected student")
        Me.btnEditStudent.Values.Image = Global.Teaching.My.Resources.Resources.AutoText_16
        Me.btnEditStudent.Values.Text = ""
        '
        'txtStudentFilter
        '
        Me.txtStudentFilter.Location = New System.Drawing.Point(62, 0)
        Me.txtStudentFilter.Name = "txtStudentFilter"
        Me.txtStudentFilter.Palette = Me.KryptonPalette1
        Me.txtStudentFilter.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.txtStudentFilter.Size = New System.Drawing.Size(117, 20)
        Me.txtStudentFilter.TabIndex = 25
        Me.ToolTip1.SetToolTip(Me.txtStudentFilter, "Student filter")
        '
        'btnSelectRandomStudent
        '
        Me.btnSelectRandomStudent.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelectRandomStudent.Location = New System.Drawing.Point(825, 2)
        Me.btnSelectRandomStudent.Name = "btnSelectRandomStudent"
        Me.btnSelectRandomStudent.Size = New System.Drawing.Size(22, 18)
        Me.btnSelectRandomStudent.TabIndex = 26
        Me.ToolTip1.SetToolTip(Me.btnSelectRandomStudent, "Select random student from list")
        Me.btnSelectRandomStudent.Values.Image = Global.Teaching.My.Resources.Resources.userprofile_16
        Me.btnSelectRandomStudent.Values.ImageTransparentColor = System.Drawing.Color.White
        Me.btnSelectRandomStudent.Values.Text = ""
        '
        'llblMoveStudent
        '
        Me.llblMoveStudent.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.llblMoveStudent.Location = New System.Drawing.Point(881, 2)
        Me.llblMoveStudent.Name = "llblMoveStudent"
        Me.llblMoveStudent.Size = New System.Drawing.Size(22, 18)
        Me.llblMoveStudent.TabIndex = 20
        Me.ToolTip1.SetToolTip(Me.llblMoveStudent, "Move selected student to another class")
        Me.llblMoveStudent.Values.Image = Global.Teaching.My.Resources.Resources.Arrow_left_16
        Me.llblMoveStudent.Values.Text = ""
        '
        'llblClearFilter
        '
        Me.llblClearFilter.Location = New System.Drawing.Point(180, 1)
        Me.llblClearFilter.Name = "llblClearFilter"
        Me.llblClearFilter.Size = New System.Drawing.Size(22, 18)
        Me.llblClearFilter.TabIndex = 23
        Me.ToolTip1.SetToolTip(Me.llblClearFilter, "Clear filter")
        Me.llblClearFilter.Values.Image = Global.Teaching.My.Resources.Resources.simpleX_16
        Me.llblClearFilter.Values.Text = ""
        '
        'llblAddStudent
        '
        Me.llblAddStudent.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.llblAddStudent.Location = New System.Drawing.Point(906, 2)
        Me.llblAddStudent.Name = "llblAddStudent"
        Me.llblAddStudent.Size = New System.Drawing.Size(22, 18)
        Me.llblAddStudent.TabIndex = 17
        Me.ToolTip1.SetToolTip(Me.llblAddStudent, "Add student to this class")
        Me.llblAddStudent.Values.Image = Global.Teaching.My.Resources.Resources.add_icon_16
        Me.llblAddStudent.Values.Text = ""
        '
        'KryptonLabel2
        '
        Me.KryptonLabel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonLabel2.Location = New System.Drawing.Point(0, 0)
        Me.KryptonLabel2.Name = "KryptonLabel2"
        Me.KryptonLabel2.Palette = Me.KryptonPalette1
        Me.KryptonLabel2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.KryptonLabel2.Size = New System.Drawing.Size(963, 20)
        Me.KryptonLabel2.TabIndex = 4
        Me.KryptonLabel2.Values.Text = "Students:"
        '
        'KryptonGroup1
        '
        Me.KryptonGroup1.Dock = System.Windows.Forms.DockStyle.Top
        Me.KryptonGroup1.Location = New System.Drawing.Point(0, 0)
        Me.KryptonGroup1.Name = "KryptonGroup1"
        Me.KryptonGroup1.Palette = Me.KryptonPalette1
        Me.KryptonGroup1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        '
        'KryptonGroup1.Panel
        '
        Me.KryptonGroup1.Panel.Controls.Add(Me.llblLoadFutureOneSemester)
        Me.KryptonGroup1.Panel.Controls.Add(Me.llblLoadPreviousOneSemester)
        Me.KryptonGroup1.Panel.Controls.Add(Me.llblLoadLatestSemester)
        Me.KryptonGroup1.Panel.Controls.Add(Me.KryptonLabel7)
        Me.KryptonGroup1.Panel.Controls.Add(Me.KryptonLabel8)
        Me.KryptonGroup1.Panel.Controls.Add(Me.KryptonLabel9)
        Me.KryptonGroup1.Panel.Controls.Add(Me.dtpSemesterEndCurrent)
        Me.KryptonGroup1.Panel.Controls.Add(Me.dtpSemesterStartCurrent)
        Me.KryptonGroup1.Panel.Controls.Add(Me.KryptonLabel6)
        Me.KryptonGroup1.Panel.Controls.Add(Me.btnLoadSemester)
        Me.KryptonGroup1.Panel.Controls.Add(Me.llblCloseSemesterPanel)
        Me.KryptonGroup1.Panel.Controls.Add(Me.KryptonLabel5)
        Me.KryptonGroup1.Panel.Controls.Add(Me.KryptonLabel4)
        Me.KryptonGroup1.Panel.Controls.Add(Me.dtpSemesterEnd)
        Me.KryptonGroup1.Panel.Controls.Add(Me.dtpSemesterStart)
        Me.KryptonGroup1.Panel.Controls.Add(Me.KryptonLabel3)
        Me.KryptonGroup1.Panel.Controls.Add(Me.cboSemester)
        Me.KryptonGroup1.Size = New System.Drawing.Size(1164, 59)
        Me.KryptonGroup1.TabIndex = 8
        '
        'llblLoadFutureOneSemester
        '
        Me.llblLoadFutureOneSemester.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.llblLoadFutureOneSemester.Location = New System.Drawing.Point(340, 29)
        Me.llblLoadFutureOneSemester.Name = "llblLoadFutureOneSemester"
        Me.llblLoadFutureOneSemester.Size = New System.Drawing.Size(26, 19)
        Me.llblLoadFutureOneSemester.TabIndex = 33
        Me.ToolTip1.SetToolTip(Me.llblLoadFutureOneSemester, "Advance one semester")
        Me.llblLoadFutureOneSemester.Values.ImageTransparentColor = System.Drawing.Color.White
        Me.llblLoadFutureOneSemester.Values.Text = ">>"
        '
        'llblLoadPreviousOneSemester
        '
        Me.llblLoadPreviousOneSemester.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.llblLoadPreviousOneSemester.Location = New System.Drawing.Point(171, 29)
        Me.llblLoadPreviousOneSemester.Name = "llblLoadPreviousOneSemester"
        Me.llblLoadPreviousOneSemester.Size = New System.Drawing.Size(26, 19)
        Me.llblLoadPreviousOneSemester.TabIndex = 32
        Me.ToolTip1.SetToolTip(Me.llblLoadPreviousOneSemester, "Go back one semester")
        Me.llblLoadPreviousOneSemester.Values.ImageTransparentColor = System.Drawing.Color.White
        Me.llblLoadPreviousOneSemester.Values.Text = "<<"
        '
        'llblLoadLatestSemester
        '
        Me.llblLoadLatestSemester.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.llblLoadLatestSemester.Location = New System.Drawing.Point(231, 29)
        Me.llblLoadLatestSemester.Name = "llblLoadLatestSemester"
        Me.llblLoadLatestSemester.Size = New System.Drawing.Size(81, 19)
        Me.llblLoadLatestSemester.TabIndex = 29
        Me.ToolTip1.SetToolTip(Me.llblLoadLatestSemester, "Most recent semester")
        Me.llblLoadLatestSemester.Values.ImageTransparentColor = System.Drawing.Color.White
        Me.llblLoadLatestSemester.Values.Text = "Most recent"
        '
        'KryptonLabel7
        '
        Me.KryptonLabel7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonLabel7.Location = New System.Drawing.Point(656, 30)
        Me.KryptonLabel7.Name = "KryptonLabel7"
        Me.KryptonLabel7.Palette = Me.KryptonPalette1
        Me.KryptonLabel7.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.KryptonLabel7.Size = New System.Drawing.Size(54, 20)
        Me.KryptonLabel7.TabIndex = 28
        Me.KryptonLabel7.Values.Text = "Current:"
        '
        'KryptonLabel8
        '
        Me.KryptonLabel8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonLabel8.Location = New System.Drawing.Point(916, 30)
        Me.KryptonLabel8.Name = "KryptonLabel8"
        Me.KryptonLabel8.Palette = Me.KryptonPalette1
        Me.KryptonLabel8.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.KryptonLabel8.Size = New System.Drawing.Size(34, 20)
        Me.KryptonLabel8.TabIndex = 27
        Me.KryptonLabel8.Values.Text = "End:"
        '
        'KryptonLabel9
        '
        Me.KryptonLabel9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonLabel9.Location = New System.Drawing.Point(713, 30)
        Me.KryptonLabel9.Name = "KryptonLabel9"
        Me.KryptonLabel9.Palette = Me.KryptonPalette1
        Me.KryptonLabel9.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.KryptonLabel9.Size = New System.Drawing.Size(39, 20)
        Me.KryptonLabel9.TabIndex = 26
        Me.KryptonLabel9.Values.Text = "Start:"
        '
        'dtpSemesterEndCurrent
        '
        Me.dtpSemesterEndCurrent.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpSemesterEndCurrent.CalendarTodayDate = New Date(2012, 10, 5, 0, 0, 0, 0)
        Me.dtpSemesterEndCurrent.Enabled = False
        Me.dtpSemesterEndCurrent.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpSemesterEndCurrent.Location = New System.Drawing.Point(961, 30)
        Me.dtpSemesterEndCurrent.Name = "dtpSemesterEndCurrent"
        Me.dtpSemesterEndCurrent.Palette = Me.KryptonPalette1
        Me.dtpSemesterEndCurrent.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.dtpSemesterEndCurrent.Size = New System.Drawing.Size(127, 21)
        Me.dtpSemesterEndCurrent.TabIndex = 25
        '
        'dtpSemesterStartCurrent
        '
        Me.dtpSemesterStartCurrent.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpSemesterStartCurrent.CalendarTodayDate = New Date(2012, 10, 5, 0, 0, 0, 0)
        Me.dtpSemesterStartCurrent.Enabled = False
        Me.dtpSemesterStartCurrent.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpSemesterStartCurrent.Location = New System.Drawing.Point(758, 29)
        Me.dtpSemesterStartCurrent.Name = "dtpSemesterStartCurrent"
        Me.dtpSemesterStartCurrent.Palette = Me.KryptonPalette1
        Me.dtpSemesterStartCurrent.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.dtpSemesterStartCurrent.Size = New System.Drawing.Size(127, 21)
        Me.dtpSemesterStartCurrent.TabIndex = 24
        '
        'KryptonLabel6
        '
        Me.KryptonLabel6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonLabel6.Location = New System.Drawing.Point(656, 4)
        Me.KryptonLabel6.Name = "KryptonLabel6"
        Me.KryptonLabel6.Palette = Me.KryptonPalette1
        Me.KryptonLabel6.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.KryptonLabel6.Size = New System.Drawing.Size(51, 20)
        Me.KryptonLabel6.TabIndex = 23
        Me.KryptonLabel6.Values.Text = "Overall:"
        '
        'btnLoadSemester
        '
        Me.btnLoadSemester.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLoadSemester.Enabled = False
        Me.btnLoadSemester.Location = New System.Drawing.Point(628, 4)
        Me.btnLoadSemester.Name = "btnLoadSemester"
        Me.btnLoadSemester.Size = New System.Drawing.Size(22, 18)
        Me.btnLoadSemester.TabIndex = 22
        Me.btnLoadSemester.Values.Image = Global.Teaching.My.Resources.Resources.checkmark_16
        Me.btnLoadSemester.Values.Text = ""
        '
        'llblCloseSemesterPanel
        '
        Me.llblCloseSemesterPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.llblCloseSemesterPanel.Location = New System.Drawing.Point(1137, 1)
        Me.llblCloseSemesterPanel.Name = "llblCloseSemesterPanel"
        Me.llblCloseSemesterPanel.Size = New System.Drawing.Size(22, 18)
        Me.llblCloseSemesterPanel.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.llblCloseSemesterPanel, "Close semester panel")
        Me.llblCloseSemesterPanel.Values.Image = Global.Teaching.My.Resources.Resources.simpleX_16
        Me.llblCloseSemesterPanel.Values.Text = ""
        '
        'KryptonLabel5
        '
        Me.KryptonLabel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonLabel5.Location = New System.Drawing.Point(916, 4)
        Me.KryptonLabel5.Name = "KryptonLabel5"
        Me.KryptonLabel5.Palette = Me.KryptonPalette1
        Me.KryptonLabel5.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.KryptonLabel5.Size = New System.Drawing.Size(34, 20)
        Me.KryptonLabel5.TabIndex = 14
        Me.KryptonLabel5.Values.Text = "End:"
        '
        'KryptonLabel4
        '
        Me.KryptonLabel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KryptonLabel4.Location = New System.Drawing.Point(713, 4)
        Me.KryptonLabel4.Name = "KryptonLabel4"
        Me.KryptonLabel4.Palette = Me.KryptonPalette1
        Me.KryptonLabel4.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.KryptonLabel4.Size = New System.Drawing.Size(39, 20)
        Me.KryptonLabel4.TabIndex = 13
        Me.KryptonLabel4.Values.Text = "Start:"
        '
        'dtpSemesterEnd
        '
        Me.dtpSemesterEnd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpSemesterEnd.CalendarTodayDate = New Date(2012, 10, 5, 0, 0, 0, 0)
        Me.dtpSemesterEnd.Enabled = False
        Me.dtpSemesterEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpSemesterEnd.Location = New System.Drawing.Point(961, 4)
        Me.dtpSemesterEnd.Name = "dtpSemesterEnd"
        Me.dtpSemesterEnd.Palette = Me.KryptonPalette1
        Me.dtpSemesterEnd.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.dtpSemesterEnd.Size = New System.Drawing.Size(127, 21)
        Me.dtpSemesterEnd.TabIndex = 12
        '
        'dtpSemesterStart
        '
        Me.dtpSemesterStart.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpSemesterStart.CalendarTodayDate = New Date(2012, 10, 5, 0, 0, 0, 0)
        Me.dtpSemesterStart.Enabled = False
        Me.dtpSemesterStart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpSemesterStart.Location = New System.Drawing.Point(758, 3)
        Me.dtpSemesterStart.Name = "dtpSemesterStart"
        Me.dtpSemesterStart.Palette = Me.KryptonPalette1
        Me.dtpSemesterStart.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.dtpSemesterStart.Size = New System.Drawing.Size(127, 21)
        Me.dtpSemesterStart.TabIndex = 11
        '
        'KryptonLabel3
        '
        Me.KryptonLabel3.Location = New System.Drawing.Point(3, 2)
        Me.KryptonLabel3.Name = "KryptonLabel3"
        Me.KryptonLabel3.Palette = Me.KryptonPalette1
        Me.KryptonLabel3.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.KryptonLabel3.Size = New System.Drawing.Size(64, 20)
        Me.KryptonLabel3.TabIndex = 5
        Me.KryptonLabel3.Values.Text = "Semester:"
        '
        'cboSemester
        '
        Me.cboSemester.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSemester.DropDownWidth = 121
        Me.cboSemester.Location = New System.Drawing.Point(73, 1)
        Me.cboSemester.Name = "cboSemester"
        Me.cboSemester.Palette = Me.KryptonPalette1
        Me.cboSemester.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.cboSemester.Size = New System.Drawing.Size(549, 21)
        Me.cboSemester.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ViewToolStripMenuItem, Me.ActionsToolStripMenuItem, Me.StudentToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.DataToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1164, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadSemesterToolStripMenuItem, Me.SaveToolStripMenuItem, Me.ToolStripSeparator5, Me.ExitToolStripMenuItem, Me.QuitWithoutSavingToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'LoadSemesterToolStripMenuItem
        '
        Me.LoadSemesterToolStripMenuItem.Name = "LoadSemesterToolStripMenuItem"
        Me.LoadSemesterToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.LoadSemesterToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.LoadSemesterToolStripMenuItem.Text = "&Load semester"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.SaveToolStripMenuItem.Text = "&Save"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(187, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'QuitWithoutSavingToolStripMenuItem
        '
        Me.QuitWithoutSavingToolStripMenuItem.Name = "QuitWithoutSavingToolStripMenuItem"
        Me.QuitWithoutSavingToolStripMenuItem.Size = New System.Drawing.Size(190, 22)
        Me.QuitWithoutSavingToolStripMenuItem.Text = "Quit without saving"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClassSelectorsToolStripMenuItem, Me.ViewScheduleToolStripMenuItem, Me.StudentphotoToolStripMenuItem, Me.NotesToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "&View"
        '
        'ClassSelectorsToolStripMenuItem
        '
        Me.ClassSelectorsToolStripMenuItem.Name = "ClassSelectorsToolStripMenuItem"
        Me.ClassSelectorsToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.ClassSelectorsToolStripMenuItem.Text = "Class selectors"
        '
        'ViewScheduleToolStripMenuItem
        '
        Me.ViewScheduleToolStripMenuItem.Checked = True
        Me.ViewScheduleToolStripMenuItem.CheckOnClick = True
        Me.ViewScheduleToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ViewScheduleToolStripMenuItem.Name = "ViewScheduleToolStripMenuItem"
        Me.ViewScheduleToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.ViewScheduleToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.ViewScheduleToolStripMenuItem.Text = "&Schedule"
        '
        'StudentphotoToolStripMenuItem
        '
        Me.StudentphotoToolStripMenuItem.CheckOnClick = True
        Me.StudentphotoToolStripMenuItem.Name = "StudentphotoToolStripMenuItem"
        Me.StudentphotoToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.StudentphotoToolStripMenuItem.Text = "Student &photo"
        Me.StudentphotoToolStripMenuItem.Visible = False
        '
        'NotesToolStripMenuItem
        '
        Me.NotesToolStripMenuItem.Checked = True
        Me.NotesToolStripMenuItem.CheckOnClick = True
        Me.NotesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.NotesToolStripMenuItem.Name = "NotesToolStripMenuItem"
        Me.NotesToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NotesToolStripMenuItem.Size = New System.Drawing.Size(164, 22)
        Me.NotesToolStripMenuItem.Text = "Notes"
        '
        'ActionsToolStripMenuItem
        '
        Me.ActionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TakeAttendenceToolStripMenuItem, Me.ToolStripSeparator3, Me.ExamToolStripMenuItem, Me.ExamRedoToolStripMenuItem, Me.Exam2ndRedoToolStripMenuItem, Me.ToolStripSeparator4, Me.MarkSelectedAssignmentToolStripMenuItem, Me.EmailAssignmentResultsToolStripMenuItem, Me.SendBulkEmailToolStripMenuItem, Me.EmailOnlineQuizResultsToolStripMenuItem, Me.FormGroupsToolStripMenuItem, Me.ToolStripSeparator15, Me.BatchSaveMarkingSheetsToolStripMenuItem})
        Me.ActionsToolStripMenuItem.Name = "ActionsToolStripMenuItem"
        Me.ActionsToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ActionsToolStripMenuItem.Text = "&Actions"
        '
        'TakeAttendenceToolStripMenuItem
        '
        Me.TakeAttendenceToolStripMenuItem.Name = "TakeAttendenceToolStripMenuItem"
        Me.TakeAttendenceToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.TakeAttendenceToolStripMenuItem.Size = New System.Drawing.Size(265, 22)
        Me.TakeAttendenceToolStripMenuItem.Text = "&Attendence..."
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(262, 6)
        '
        'ExamToolStripMenuItem
        '
        Me.ExamToolStripMenuItem.Name = "ExamToolStripMenuItem"
        Me.ExamToolStripMenuItem.Size = New System.Drawing.Size(265, 22)
        Me.ExamToolStripMenuItem.Text = "Oral &Exam (1st)..."
        '
        'ExamRedoToolStripMenuItem
        '
        Me.ExamRedoToolStripMenuItem.Name = "ExamRedoToolStripMenuItem"
        Me.ExamRedoToolStripMenuItem.Size = New System.Drawing.Size(265, 22)
        Me.ExamRedoToolStripMenuItem.Text = "Oral Exam &Redo..."
        '
        'Exam2ndRedoToolStripMenuItem
        '
        Me.Exam2ndRedoToolStripMenuItem.Name = "Exam2ndRedoToolStripMenuItem"
        Me.Exam2ndRedoToolStripMenuItem.Size = New System.Drawing.Size(265, 22)
        Me.Exam2ndRedoToolStripMenuItem.Text = "Oral Exam 2nd Redo..."
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(262, 6)
        '
        'MarkSelectedAssignmentToolStripMenuItem
        '
        Me.MarkSelectedAssignmentToolStripMenuItem.Name = "MarkSelectedAssignmentToolStripMenuItem"
        Me.MarkSelectedAssignmentToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.MarkSelectedAssignmentToolStripMenuItem.Size = New System.Drawing.Size(265, 22)
        Me.MarkSelectedAssignmentToolStripMenuItem.Text = "Mark selected assignment..."
        '
        'EmailAssignmentResultsToolStripMenuItem
        '
        Me.EmailAssignmentResultsToolStripMenuItem.Name = "EmailAssignmentResultsToolStripMenuItem"
        Me.EmailAssignmentResultsToolStripMenuItem.Size = New System.Drawing.Size(265, 22)
        Me.EmailAssignmentResultsToolStripMenuItem.Text = "Email module &results..."
        '
        'SendBulkEmailToolStripMenuItem
        '
        Me.SendBulkEmailToolStripMenuItem.Name = "SendBulkEmailToolStripMenuItem"
        Me.SendBulkEmailToolStripMenuItem.Size = New System.Drawing.Size(265, 22)
        Me.SendBulkEmailToolStripMenuItem.Text = "Send &bulk email..."
        '
        'EmailOnlineQuizResultsToolStripMenuItem
        '
        Me.EmailOnlineQuizResultsToolStripMenuItem.Name = "EmailOnlineQuizResultsToolStripMenuItem"
        Me.EmailOnlineQuizResultsToolStripMenuItem.Size = New System.Drawing.Size(265, 22)
        Me.EmailOnlineQuizResultsToolStripMenuItem.Text = "Email online &quiz results..."
        '
        'FormGroupsToolStripMenuItem
        '
        Me.FormGroupsToolStripMenuItem.Name = "FormGroupsToolStripMenuItem"
        Me.FormGroupsToolStripMenuItem.Size = New System.Drawing.Size(265, 22)
        Me.FormGroupsToolStripMenuItem.Text = "Form groups..."
        '
        'ToolStripSeparator15
        '
        Me.ToolStripSeparator15.Name = "ToolStripSeparator15"
        Me.ToolStripSeparator15.Size = New System.Drawing.Size(262, 6)
        '
        'BatchSaveMarkingSheetsToolStripMenuItem
        '
        Me.BatchSaveMarkingSheetsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FirstTryToolStripMenuItem, Me.SecondTryToolStripMenuItem, Me.ThirdTryToolStripMenuItem})
        Me.BatchSaveMarkingSheetsToolStripMenuItem.Name = "BatchSaveMarkingSheetsToolStripMenuItem"
        Me.BatchSaveMarkingSheetsToolStripMenuItem.Size = New System.Drawing.Size(265, 22)
        Me.BatchSaveMarkingSheetsToolStripMenuItem.Text = "Batch save marking sheets"
        '
        'FirstTryToolStripMenuItem
        '
        Me.FirstTryToolStripMenuItem.Name = "FirstTryToolStripMenuItem"
        Me.FirstTryToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.FirstTryToolStripMenuItem.Text = "First try"
        '
        'SecondTryToolStripMenuItem
        '
        Me.SecondTryToolStripMenuItem.Name = "SecondTryToolStripMenuItem"
        Me.SecondTryToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.SecondTryToolStripMenuItem.Text = "Second try"
        '
        'ThirdTryToolStripMenuItem
        '
        Me.ThirdTryToolStripMenuItem.Name = "ThirdTryToolStripMenuItem"
        Me.ThirdTryToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.ThirdTryToolStripMenuItem.Text = "Third try"
        '
        'StudentToolStripMenuItem
        '
        Me.StudentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToggleHiddenForSelectedToolStripMenuItem, Me.SetGendermaleToolStripMenuItem, Me.SetGenderfemaleToolStripMenuItem, Me.ClearStudentFilterToolStripMenuItem, Me.ExcuseMostRecentAbsenceToolStripMenuItem, Me.FilterForSelectedGroupToolStripMenuItem, Me.ClearTagsToolStripMenuItem})
        Me.StudentToolStripMenuItem.Name = "StudentToolStripMenuItem"
        Me.StudentToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.StudentToolStripMenuItem.Text = "&Student"
        '
        'ToggleHiddenForSelectedToolStripMenuItem
        '
        Me.ToggleHiddenForSelectedToolStripMenuItem.Name = "ToggleHiddenForSelectedToolStripMenuItem"
        Me.ToggleHiddenForSelectedToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.ToggleHiddenForSelectedToolStripMenuItem.Size = New System.Drawing.Size(273, 22)
        Me.ToggleHiddenForSelectedToolStripMenuItem.Text = "Toggle &hidden for selected"
        '
        'SetGendermaleToolStripMenuItem
        '
        Me.SetGendermaleToolStripMenuItem.Name = "SetGendermaleToolStripMenuItem"
        Me.SetGendermaleToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.SetGendermaleToolStripMenuItem.Size = New System.Drawing.Size(273, 22)
        Me.SetGendermaleToolStripMenuItem.Text = "Set gender=male"
        '
        'SetGenderfemaleToolStripMenuItem
        '
        Me.SetGenderfemaleToolStripMenuItem.Name = "SetGenderfemaleToolStripMenuItem"
        Me.SetGenderfemaleToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.SetGenderfemaleToolStripMenuItem.Size = New System.Drawing.Size(273, 22)
        Me.SetGenderfemaleToolStripMenuItem.Text = "Set gender=female"
        '
        'ClearStudentFilterToolStripMenuItem
        '
        Me.ClearStudentFilterToolStripMenuItem.Name = "ClearStudentFilterToolStripMenuItem"
        Me.ClearStudentFilterToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.ClearStudentFilterToolStripMenuItem.Size = New System.Drawing.Size(273, 22)
        Me.ClearStudentFilterToolStripMenuItem.Text = "&Clear student filter"
        '
        'ExcuseMostRecentAbsenceToolStripMenuItem
        '
        Me.ExcuseMostRecentAbsenceToolStripMenuItem.Name = "ExcuseMostRecentAbsenceToolStripMenuItem"
        Me.ExcuseMostRecentAbsenceToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.ExcuseMostRecentAbsenceToolStripMenuItem.Size = New System.Drawing.Size(273, 22)
        Me.ExcuseMostRecentAbsenceToolStripMenuItem.Text = "&Excuse most recent absence"
        '
        'FilterForSelectedGroupToolStripMenuItem
        '
        Me.FilterForSelectedGroupToolStripMenuItem.Name = "FilterForSelectedGroupToolStripMenuItem"
        Me.FilterForSelectedGroupToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.FilterForSelectedGroupToolStripMenuItem.Size = New System.Drawing.Size(273, 22)
        Me.FilterForSelectedGroupToolStripMenuItem.Text = "Filter for selected group"
        '
        'ClearTagsToolStripMenuItem
        '
        Me.ClearTagsToolStripMenuItem.Name = "ClearTagsToolStripMenuItem"
        Me.ClearTagsToolStripMenuItem.Size = New System.Drawing.Size(273, 22)
        Me.ClearTagsToolStripMenuItem.Text = "Clear tags for these students"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseAssignmentToolStripMenuItem, Me.ReorderAdminNumbersToolStripMenuItem, Me.ManageImprovementItemsToolStripMenuItem, Me.EitherOrToolStripMenuItem, Me.RemoveAllStudentsFromSelectedClassToolStripMenuItem, Me.ToolStripSeparator11, Me.OptionsToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.ToolsToolStripMenuItem.Text = "&Tools"
        '
        'CloseAssignmentToolStripMenuItem
        '
        Me.CloseAssignmentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FirstSubmissionToolStripMenuItem, Me.SecondSubmissionToolStripMenuItem, Me.ThirdSubmissionToolStripMenuItem, Me.ToolStripSeparator9, Me.HideStudentsWhoPassedAllToolStripMenuItem})
        Me.CloseAssignmentToolStripMenuItem.Name = "CloseAssignmentToolStripMenuItem"
        Me.CloseAssignmentToolStripMenuItem.Size = New System.Drawing.Size(283, 22)
        Me.CloseAssignmentToolStripMenuItem.Text = "&Close assignment"
        '
        'FirstSubmissionToolStripMenuItem
        '
        Me.FirstSubmissionToolStripMenuItem.Name = "FirstSubmissionToolStripMenuItem"
        Me.FirstSubmissionToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.FirstSubmissionToolStripMenuItem.Text = "&First submission"
        '
        'SecondSubmissionToolStripMenuItem
        '
        Me.SecondSubmissionToolStripMenuItem.Name = "SecondSubmissionToolStripMenuItem"
        Me.SecondSubmissionToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.SecondSubmissionToolStripMenuItem.Text = "&Second submission"
        '
        'ThirdSubmissionToolStripMenuItem
        '
        Me.ThirdSubmissionToolStripMenuItem.Name = "ThirdSubmissionToolStripMenuItem"
        Me.ThirdSubmissionToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.ThirdSubmissionToolStripMenuItem.Text = "&Third submission"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(224, 6)
        '
        'HideStudentsWhoPassedAllToolStripMenuItem
        '
        Me.HideStudentsWhoPassedAllToolStripMenuItem.Name = "HideStudentsWhoPassedAllToolStripMenuItem"
        Me.HideStudentsWhoPassedAllToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.HideStudentsWhoPassedAllToolStripMenuItem.Text = "&Hide students who passed all"
        '
        'ReorderAdminNumbersToolStripMenuItem
        '
        Me.ReorderAdminNumbersToolStripMenuItem.CheckOnClick = True
        Me.ReorderAdminNumbersToolStripMenuItem.Name = "ReorderAdminNumbersToolStripMenuItem"
        Me.ReorderAdminNumbersToolStripMenuItem.Size = New System.Drawing.Size(283, 22)
        Me.ReorderAdminNumbersToolStripMenuItem.Text = "Reorder admin numbers"
        '
        'ManageImprovementItemsToolStripMenuItem
        '
        Me.ManageImprovementItemsToolStripMenuItem.Name = "ManageImprovementItemsToolStripMenuItem"
        Me.ManageImprovementItemsToolStripMenuItem.Size = New System.Drawing.Size(283, 22)
        Me.ManageImprovementItemsToolStripMenuItem.Text = "Manage improvement items..."
        '
        'EitherOrToolStripMenuItem
        '
        Me.EitherOrToolStripMenuItem.Name = "EitherOrToolStripMenuItem"
        Me.EitherOrToolStripMenuItem.Size = New System.Drawing.Size(283, 22)
        Me.EitherOrToolStripMenuItem.Text = "Either or..."
        Me.EitherOrToolStripMenuItem.ToolTipText = "Allow students to be in one session or the other to get attendance for both"
        '
        'RemoveAllStudentsFromSelectedClassToolStripMenuItem
        '
        Me.RemoveAllStudentsFromSelectedClassToolStripMenuItem.Name = "RemoveAllStudentsFromSelectedClassToolStripMenuItem"
        Me.RemoveAllStudentsFromSelectedClassToolStripMenuItem.Size = New System.Drawing.Size(283, 22)
        Me.RemoveAllStudentsFromSelectedClassToolStripMenuItem.Text = "Remove all students from selected class"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(280, 6)
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(283, 22)
        Me.OptionsToolStripMenuItem.Text = "&Options..."
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StudentAttendanceErrorsToolStripMenuItem, Me.AssignmentResultsToolStripMenuItem, Me.ModuleResultsToolStripMenuItem, Me.FailedoutcomesToolStripMenuItem, Me.ModuleFeedbackCheckToolStripMenuItem, Me.StudentOutcomeResultsToolStripMenuItem, Me.SessionprepStatusToolStripMenuItem, Me.AssignmentProcessingToolStripMenuItem, Me.ScheduledSessionsToolStripMenuItem, Me.StudentQualityToolStripMenuItem, Me.StudentGradesToolStripMenuItem, Me.SemesterStatisticsToolStripMenuItem, Me.ExcessiveAbsencesToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ReportsToolStripMenuItem.Text = "&Reports"
        '
        'StudentAttendanceErrorsToolStripMenuItem
        '
        Me.StudentAttendanceErrorsToolStripMenuItem.Name = "StudentAttendanceErrorsToolStripMenuItem"
        Me.StudentAttendanceErrorsToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.StudentAttendanceErrorsToolStripMenuItem.Text = "Student &Attendance Errors..."
        '
        'AssignmentResultsToolStripMenuItem
        '
        Me.AssignmentResultsToolStripMenuItem.Name = "AssignmentResultsToolStripMenuItem"
        Me.AssignmentResultsToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.AssignmentResultsToolStripMenuItem.Text = "Assignment &Results..."
        '
        'ModuleResultsToolStripMenuItem
        '
        Me.ModuleResultsToolStripMenuItem.Name = "ModuleResultsToolStripMenuItem"
        Me.ModuleResultsToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.ModuleResultsToolStripMenuItem.Text = "&Module Results..."
        '
        'FailedoutcomesToolStripMenuItem
        '
        Me.FailedoutcomesToolStripMenuItem.Name = "FailedoutcomesToolStripMenuItem"
        Me.FailedoutcomesToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.FailedoutcomesToolStripMenuItem.Text = "Failed &outcomes..."
        '
        'ModuleFeedbackCheckToolStripMenuItem
        '
        Me.ModuleFeedbackCheckToolStripMenuItem.Name = "ModuleFeedbackCheckToolStripMenuItem"
        Me.ModuleFeedbackCheckToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.ModuleFeedbackCheckToolStripMenuItem.Text = "Module &Feedback Check..."
        '
        'StudentOutcomeResultsToolStripMenuItem
        '
        Me.StudentOutcomeResultsToolStripMenuItem.Name = "StudentOutcomeResultsToolStripMenuItem"
        Me.StudentOutcomeResultsToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.StudentOutcomeResultsToolStripMenuItem.Text = "Student outcome results..."
        '
        'SessionprepStatusToolStripMenuItem
        '
        Me.SessionprepStatusToolStripMenuItem.Name = "SessionprepStatusToolStripMenuItem"
        Me.SessionprepStatusToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.SessionprepStatusToolStripMenuItem.Text = "Session &prep status"
        '
        'AssignmentProcessingToolStripMenuItem
        '
        Me.AssignmentProcessingToolStripMenuItem.Name = "AssignmentProcessingToolStripMenuItem"
        Me.AssignmentProcessingToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.AssignmentProcessingToolStripMenuItem.Text = "Assignment processing"
        '
        'ScheduledSessionsToolStripMenuItem
        '
        Me.ScheduledSessionsToolStripMenuItem.Name = "ScheduledSessionsToolStripMenuItem"
        Me.ScheduledSessionsToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.ScheduledSessionsToolStripMenuItem.Text = "Scheduled sessions..."
        '
        'StudentQualityToolStripMenuItem
        '
        Me.StudentQualityToolStripMenuItem.Name = "StudentQualityToolStripMenuItem"
        Me.StudentQualityToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.StudentQualityToolStripMenuItem.Text = "Student quality..."
        '
        'StudentGradesToolStripMenuItem
        '
        Me.StudentGradesToolStripMenuItem.Name = "StudentGradesToolStripMenuItem"
        Me.StudentGradesToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.StudentGradesToolStripMenuItem.Text = "Student grades..."
        '
        'SemesterStatisticsToolStripMenuItem
        '
        Me.SemesterStatisticsToolStripMenuItem.Name = "SemesterStatisticsToolStripMenuItem"
        Me.SemesterStatisticsToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.SemesterStatisticsToolStripMenuItem.Text = "Semester statistics..."
        '
        'ExcessiveAbsencesToolStripMenuItem
        '
        Me.ExcessiveAbsencesToolStripMenuItem.Name = "ExcessiveAbsencesToolStripMenuItem"
        Me.ExcessiveAbsencesToolStripMenuItem.Size = New System.Drawing.Size(221, 22)
        Me.ExcessiveAbsencesToolStripMenuItem.Text = "Excessive absences..."
        '
        'DataToolStripMenuItem
        '
        Me.DataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImportClassToolStripMenuItem, Me.ImportSToolStripMenuItem, Me.ImportAttendanceToolStripMenuItem, Me.ImportEmailAddressesToolStripMenuItem, Me.ImportStudentAssignmentScoresToolStripMenuItem, Me.ImportImprovementItemsToolStripMenuItem, Me.ToolStripSeparator6, Me.ExportAttendanceToolStripMenuItem, Me.ExportModuleResultsToolStripMenuItem, Me.ExportMarkingResultsToolStripMenuItem, Me.ExportMarkingResultsIsolatedToolStripMenuItem, Me.ExportStudentsToolStripMenuItem, Me.ExportStudentGradesToolStripMenuItem, Me.ExportScheduleAsICalToolStripMenuItem, Me.ToolStripSeparator7, Me.UpdateEmailAddressToolStripMenuItem, Me.FindDuplicateStudentsToolStripMenuItem, Me.FindhistoricalStudentToolStripMenuItem, Me.ProcessAddDropStudentsToolStripMenuItem})
        Me.DataToolStripMenuItem.Name = "DataToolStripMenuItem"
        Me.DataToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.DataToolStripMenuItem.Text = "&Data"
        '
        'ImportClassToolStripMenuItem
        '
        Me.ImportClassToolStripMenuItem.Name = "ImportClassToolStripMenuItem"
        Me.ImportClassToolStripMenuItem.Size = New System.Drawing.Size(270, 22)
        Me.ImportClassToolStripMenuItem.Text = "Import &class"
        '
        'ImportSToolStripMenuItem
        '
        Me.ImportSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImportStudentsFromTextToolStripMenuItem, Me.ImportStudentsFromOtherSemesterToolStripMenuItem})
        Me.ImportSToolStripMenuItem.Name = "ImportSToolStripMenuItem"
        Me.ImportSToolStripMenuItem.Size = New System.Drawing.Size(270, 22)
        Me.ImportSToolStripMenuItem.Text = "Import &students"
        '
        'ImportStudentsFromTextToolStripMenuItem
        '
        Me.ImportStudentsFromTextToolStripMenuItem.Name = "ImportStudentsFromTextToolStripMenuItem"
        Me.ImportStudentsFromTextToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.ImportStudentsFromTextToolStripMenuItem.Text = "From &Spreadsheet..."
        '
        'ImportStudentsFromOtherSemesterToolStripMenuItem
        '
        Me.ImportStudentsFromOtherSemesterToolStripMenuItem.Name = "ImportStudentsFromOtherSemesterToolStripMenuItem"
        Me.ImportStudentsFromOtherSemesterToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.ImportStudentsFromOtherSemesterToolStripMenuItem.Text = "From &Other Semester..."
        '
        'ImportAttendanceToolStripMenuItem
        '
        Me.ImportAttendanceToolStripMenuItem.Name = "ImportAttendanceToolStripMenuItem"
        Me.ImportAttendanceToolStripMenuItem.Size = New System.Drawing.Size(270, 22)
        Me.ImportAttendanceToolStripMenuItem.Text = "Import &attendance..."
        '
        'ImportEmailAddressesToolStripMenuItem
        '
        Me.ImportEmailAddressesToolStripMenuItem.Name = "ImportEmailAddressesToolStripMenuItem"
        Me.ImportEmailAddressesToolStripMenuItem.Size = New System.Drawing.Size(270, 22)
        Me.ImportEmailAddressesToolStripMenuItem.Text = "Import additional student &data..."
        '
        'ImportStudentAssignmentScoresToolStripMenuItem
        '
        Me.ImportStudentAssignmentScoresToolStripMenuItem.Name = "ImportStudentAssignmentScoresToolStripMenuItem"
        Me.ImportStudentAssignmentScoresToolStripMenuItem.Size = New System.Drawing.Size(270, 22)
        Me.ImportStudentAssignmentScoresToolStripMenuItem.Text = "Import student assignment scores..."
        '
        'ImportImprovementItemsToolStripMenuItem
        '
        Me.ImportImprovementItemsToolStripMenuItem.Name = "ImportImprovementItemsToolStripMenuItem"
        Me.ImportImprovementItemsToolStripMenuItem.Size = New System.Drawing.Size(270, 22)
        Me.ImportImprovementItemsToolStripMenuItem.Text = "Import improvement items"
        Me.ImportImprovementItemsToolStripMenuItem.ToolTipText = "Import improvement items from other semester"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(267, 6)
        '
        'ExportAttendanceToolStripMenuItem
        '
        Me.ExportAttendanceToolStripMenuItem.Name = "ExportAttendanceToolStripMenuItem"
        Me.ExportAttendanceToolStripMenuItem.Size = New System.Drawing.Size(270, 22)
        Me.ExportAttendanceToolStripMenuItem.Text = "Export a&ttendance..."
        '
        'ExportModuleResultsToolStripMenuItem
        '
        Me.ExportModuleResultsToolStripMenuItem.Name = "ExportModuleResultsToolStripMenuItem"
        Me.ExportModuleResultsToolStripMenuItem.Size = New System.Drawing.Size(270, 22)
        Me.ExportModuleResultsToolStripMenuItem.Text = "Export &module results..."
        '
        'ExportMarkingResultsToolStripMenuItem
        '
        Me.ExportMarkingResultsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportMarkingResultsFirstSubmitToolStripMenuItem, Me.ExportMarkingResultsSecondSubmitToolStripMenuItem, Me.ExportMarkingResultsThirdSubmitToolStripMenuItem})
        Me.ExportMarkingResultsToolStripMenuItem.Name = "ExportMarkingResultsToolStripMenuItem"
        Me.ExportMarkingResultsToolStripMenuItem.Size = New System.Drawing.Size(270, 22)
        Me.ExportMarkingResultsToolStripMenuItem.Text = "Export marking results (cumulative)..."
        Me.ExportMarkingResultsToolStripMenuItem.ToolTipText = "Export will contain outcomes processed for this and earlier submissions"
        '
        'ExportMarkingResultsFirstSubmitToolStripMenuItem
        '
        Me.ExportMarkingResultsFirstSubmitToolStripMenuItem.Name = "ExportMarkingResultsFirstSubmitToolStripMenuItem"
        Me.ExportMarkingResultsFirstSubmitToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.ExportMarkingResultsFirstSubmitToolStripMenuItem.Text = "&First submit"
        '
        'ExportMarkingResultsSecondSubmitToolStripMenuItem
        '
        Me.ExportMarkingResultsSecondSubmitToolStripMenuItem.Name = "ExportMarkingResultsSecondSubmitToolStripMenuItem"
        Me.ExportMarkingResultsSecondSubmitToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.ExportMarkingResultsSecondSubmitToolStripMenuItem.Text = "&Second submit"
        '
        'ExportMarkingResultsThirdSubmitToolStripMenuItem
        '
        Me.ExportMarkingResultsThirdSubmitToolStripMenuItem.Name = "ExportMarkingResultsThirdSubmitToolStripMenuItem"
        Me.ExportMarkingResultsThirdSubmitToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.ExportMarkingResultsThirdSubmitToolStripMenuItem.Text = "&Third submit"
        '
        'ExportMarkingResultsIsolatedToolStripMenuItem
        '
        Me.ExportMarkingResultsIsolatedToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportMarkingResultsIsolatedFirstSubmitToolStripMenuItem, Me.ExportMarkingResultsIsolatedSecondSubmitToolStripMenuItem, Me.ExportMarkingResultsIsolatedThirdSubmitToolStripMenuItem})
        Me.ExportMarkingResultsIsolatedToolStripMenuItem.Name = "ExportMarkingResultsIsolatedToolStripMenuItem"
        Me.ExportMarkingResultsIsolatedToolStripMenuItem.Size = New System.Drawing.Size(270, 22)
        Me.ExportMarkingResultsIsolatedToolStripMenuItem.Text = "Export marking results (isolated)..."
        Me.ExportMarkingResultsIsolatedToolStripMenuItem.ToolTipText = "Export will only contain outcomes processed for the submission"
        '
        'ExportMarkingResultsIsolatedFirstSubmitToolStripMenuItem
        '
        Me.ExportMarkingResultsIsolatedFirstSubmitToolStripMenuItem.Name = "ExportMarkingResultsIsolatedFirstSubmitToolStripMenuItem"
        Me.ExportMarkingResultsIsolatedFirstSubmitToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.ExportMarkingResultsIsolatedFirstSubmitToolStripMenuItem.Text = "&First submit"
        '
        'ExportMarkingResultsIsolatedSecondSubmitToolStripMenuItem
        '
        Me.ExportMarkingResultsIsolatedSecondSubmitToolStripMenuItem.Name = "ExportMarkingResultsIsolatedSecondSubmitToolStripMenuItem"
        Me.ExportMarkingResultsIsolatedSecondSubmitToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.ExportMarkingResultsIsolatedSecondSubmitToolStripMenuItem.Text = "&Second submit"
        '
        'ExportMarkingResultsIsolatedThirdSubmitToolStripMenuItem
        '
        Me.ExportMarkingResultsIsolatedThirdSubmitToolStripMenuItem.Name = "ExportMarkingResultsIsolatedThirdSubmitToolStripMenuItem"
        Me.ExportMarkingResultsIsolatedThirdSubmitToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.ExportMarkingResultsIsolatedThirdSubmitToolStripMenuItem.Text = "&Third submit"
        '
        'ExportStudentsToolStripMenuItem
        '
        Me.ExportStudentsToolStripMenuItem.Name = "ExportStudentsToolStripMenuItem"
        Me.ExportStudentsToolStripMenuItem.Size = New System.Drawing.Size(270, 22)
        Me.ExportStudentsToolStripMenuItem.Text = "Export st&udents..."
        '
        'ExportStudentGradesToolStripMenuItem
        '
        Me.ExportStudentGradesToolStripMenuItem.Name = "ExportStudentGradesToolStripMenuItem"
        Me.ExportStudentGradesToolStripMenuItem.Size = New System.Drawing.Size(270, 22)
        Me.ExportStudentGradesToolStripMenuItem.Text = "Export student grades..."
        '
        'ExportScheduleAsICalToolStripMenuItem
        '
        Me.ExportScheduleAsICalToolStripMenuItem.Name = "ExportScheduleAsICalToolStripMenuItem"
        Me.ExportScheduleAsICalToolStripMenuItem.Size = New System.Drawing.Size(270, 22)
        Me.ExportScheduleAsICalToolStripMenuItem.Text = "Export schedule as iCalendar..."
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(267, 6)
        '
        'UpdateEmailAddressToolStripMenuItem
        '
        Me.UpdateEmailAddressToolStripMenuItem.Name = "UpdateEmailAddressToolStripMenuItem"
        Me.UpdateEmailAddressToolStripMenuItem.Size = New System.Drawing.Size(270, 22)
        Me.UpdateEmailAddressToolStripMenuItem.Text = "Update Email Address..."
        '
        'FindDuplicateStudentsToolStripMenuItem
        '
        Me.FindDuplicateStudentsToolStripMenuItem.Name = "FindDuplicateStudentsToolStripMenuItem"
        Me.FindDuplicateStudentsToolStripMenuItem.Size = New System.Drawing.Size(270, 22)
        Me.FindDuplicateStudentsToolStripMenuItem.Text = "Find duplicate students..."
        '
        'FindhistoricalStudentToolStripMenuItem
        '
        Me.FindhistoricalStudentToolStripMenuItem.Name = "FindhistoricalStudentToolStripMenuItem"
        Me.FindhistoricalStudentToolStripMenuItem.Size = New System.Drawing.Size(270, 22)
        Me.FindhistoricalStudentToolStripMenuItem.Text = "Find &historical student..."
        '
        'ProcessAddDropStudentsToolStripMenuItem
        '
        Me.ProcessAddDropStudentsToolStripMenuItem.Name = "ProcessAddDropStudentsToolStripMenuItem"
        Me.ProcessAddDropStudentsToolStripMenuItem.Size = New System.Drawing.Size(270, 22)
        Me.ProcessAddDropStudentsToolStripMenuItem.Text = "Process add / drop students..."
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CheckForupdatesToolStripMenuItem, Me.UpgradeToolStripMenuItem, Me.ToolStripSeparator16, Me.ViewLogFileToolStripMenuItem, Me.AboutToolStripMenuItem, Me.ToolStripMenuItem2})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'CheckForupdatesToolStripMenuItem
        '
        Me.CheckForupdatesToolStripMenuItem.Name = "CheckForupdatesToolStripMenuItem"
        Me.CheckForupdatesToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.CheckForupdatesToolStripMenuItem.Text = "Check for &updates"
        '
        'ToolStripSeparator16
        '
        Me.ToolStripSeparator16.Name = "ToolStripSeparator16"
        Me.ToolStripSeparator16.Size = New System.Drawing.Size(167, 6)
        '
        'ViewLogFileToolStripMenuItem
        '
        Me.ViewLogFileToolStripMenuItem.Name = "ViewLogFileToolStripMenuItem"
        Me.ViewLogFileToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.ViewLogFileToolStripMenuItem.Text = "&View log file"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(170, 22)
        Me.ToolStripMenuItem2.Text = "???"
        Me.ToolStripMenuItem2.Visible = False
        '
        'KryptonManager
        '
        '
        'kryptonPalette2
        '
        Me.kryptonPalette2.Common.StateCommon.Content.ShortText.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KryptonManager.GlobalPalette = Me.kryptonPalette2
        Me.KryptonManager.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Custom
        '
        'tmrFilterStudents
        '
        Me.tmrFilterStudents.Interval = 200
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.ContextMenuStrip = Me.ctxmnuTray
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Teaching"
        Me.NotifyIcon1.Visible = True
        '
        'ctxmnuTray
        '
        Me.ctxmnuTray.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ctxmnuTray.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectRandomStudentToolStripMenuItem})
        Me.ctxmnuTray.Name = "ctxmnuTray"
        Me.ctxmnuTray.Size = New System.Drawing.Size(194, 26)
        '
        'SelectRandomStudentToolStripMenuItem
        '
        Me.SelectRandomStudentToolStripMenuItem.Name = "SelectRandomStudentToolStripMenuItem"
        Me.SelectRandomStudentToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.SelectRandomStudentToolStripMenuItem.Text = "&Select random student"
        '
        'tmrAutoSave
        '
        Me.tmrAutoSave.Interval = 10000
        '
        'ctxmnuNewAssignment
        '
        Me.ctxmnuNewAssignment.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ctxmnuNewAssignment.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewBTECAssignmentToolStripMenuItem, Me.NewNormalAssignmentToolStripMenuItem})
        Me.ctxmnuNewAssignment.Name = "ctxmnuStudents"
        Me.ctxmnuNewAssignment.Size = New System.Drawing.Size(204, 48)
        '
        'NewBTECAssignmentToolStripMenuItem
        '
        Me.NewBTECAssignmentToolStripMenuItem.Name = "NewBTECAssignmentToolStripMenuItem"
        Me.NewBTECAssignmentToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.NewBTECAssignmentToolStripMenuItem.Text = "New &BTEC assignment"
        '
        'NewNormalAssignmentToolStripMenuItem
        '
        Me.NewNormalAssignmentToolStripMenuItem.Name = "NewNormalAssignmentToolStripMenuItem"
        Me.NewNormalAssignmentToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.NewNormalAssignmentToolStripMenuItem.Text = "New normal assignment"
        '
        'tmrStopwatch
        '
        Me.tmrStopwatch.Interval = 1000
        '
        'UpgradeToolStripMenuItem
        '
        Me.UpgradeToolStripMenuItem.Name = "UpgradeToolStripMenuItem"
        Me.UpgradeToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.UpgradeToolStripMenuItem.Text = "&Upgrade..."
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1164, 558)
        Me.Controls.Add(Me.KryptonPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Palette = Me.KryptonPalette1
        Me.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom
        Me.Text = "Teaching"
        CType(Me.KryptonPanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        CType(Me.KryptonPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel1.ResumeLayout(False)
        CType(Me.splitOverall.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitOverall.Panel1.ResumeLayout(False)
        CType(Me.splitOverall.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitOverall.Panel2.ResumeLayout(False)
        Me.splitOverall.Panel2.PerformLayout()
        CType(Me.splitOverall, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitOverall.ResumeLayout(False)
        CType(Me.KryptonSplitContainer3.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer3.Panel1.ResumeLayout(False)
        Me.KryptonSplitContainer3.Panel1.PerformLayout()
        CType(Me.KryptonSplitContainer3.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.KryptonSplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer3.ResumeLayout(False)
        CType(Me.KryptonSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel1.ResumeLayout(False)
        Me.KryptonSplitContainer1.Panel1.PerformLayout()
        CType(Me.KryptonSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.Panel2.ResumeLayout(False)
        Me.KryptonSplitContainer1.Panel2.PerformLayout()
        CType(Me.KryptonSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonSplitContainer1.ResumeLayout(False)
        Me.ctxmnuClasses.ResumeLayout(False)
        Me.ctxmnuAssignment.ResumeLayout(False)
        CType(Me.splitStudentsSchedule.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitStudentsSchedule.Panel1.ResumeLayout(False)
        CType(Me.splitStudentsSchedule.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitStudentsSchedule.Panel2.ResumeLayout(False)
        CType(Me.splitStudentsSchedule, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitStudentsSchedule.ResumeLayout(False)
        CType(Me.olvStudents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ctxmnuStudents.ResumeLayout(False)
        CType(Me.ScheduleNotesSplitter.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ScheduleNotesSplitter.Panel1.ResumeLayout(False)
        CType(Me.ScheduleNotesSplitter.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ScheduleNotesSplitter.Panel2.ResumeLayout(False)
        CType(Me.ScheduleNotesSplitter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ScheduleNotesSplitter.ResumeLayout(False)
        CType(Me.olvSchedule, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ctxmnuActualSessions.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picStudent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KryptonPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonPanel2.ResumeLayout(False)
        Me.KryptonPanel2.PerformLayout()
        CType(Me.KryptonGroup1.Panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup1.Panel.ResumeLayout(False)
        Me.KryptonGroup1.Panel.PerformLayout()
        CType(Me.KryptonGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.KryptonGroup1.ResumeLayout(False)
        CType(Me.cboSemester, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ctxmnuTray.ResumeLayout(False)
        Me.ctxmnuNewAssignment.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KryptonPanel As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents KryptonManager As ComponentFactory.Krypton.Toolkit.KryptonManager

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents KryptonPalette1 As ComponentFactory.Krypton.Toolkit.KryptonPalette
    Friend WithEvents lstClasses As ComponentFactory.Krypton.Toolkit.KryptonListBox
    Friend WithEvents KryptonLabel2 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents OlvColumn1 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn2 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn3 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents olvStudents As BrightIdeasSoftware.ObjectListView
    Friend WithEvents KryptonPanel1 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents llblAddStudent As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents llblRemoveStudent As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents llblMoveStudent As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents btnAddClass As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents btnEditStudent As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents btnEditClass As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ActionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TakeAttendenceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OlvColumn4 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents llblRemoveClass As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents txtStudentFilter As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents tmrFilterStudents As System.Windows.Forms.Timer
    Friend WithEvents ctxmnuStudents As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditStudentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MeritToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DemeritToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OlvColumn5 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents KryptonContextMenuItems2 As ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems
    Friend WithEvents KryptonContextMenuItems3 As ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadSemesterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KryptonGroup1 As ComponentFactory.Krypton.Toolkit.KryptonGroup
    Friend WithEvents btnLoadSemester As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents llblCloseSemesterPanel As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents KryptonLabel5 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel4 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtpSemesterEnd As ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker
    Friend WithEvents dtpSemesterStart As ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker
    Friend WithEvents KryptonLabel3 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents cboSemester As ComponentFactory.Krypton.Toolkit.KryptonComboBox
    Friend WithEvents llblClearFilter As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents btnSelectRandomStudent As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OlvColumn6 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn7 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents KryptonLabel7 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel8 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel9 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents dtpSemesterEndCurrent As ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker
    Friend WithEvents dtpSemesterStartCurrent As ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker
    Friend WithEvents KryptonLabel6 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents splitOverall As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents KryptonSplitContainer1 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents KryptonLabel10 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents KryptonLabel1 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lstAssignments As ComponentFactory.Krypton.Toolkit.KryptonListBox
    Friend WithEvents llblRemoveAssignment As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents llblEditAssignment As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents llblAddAssignment As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents ctxmnuAssignment As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents PasteNewAssignmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreateNewAssignmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteSelectedAssignmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditSelectedAssignmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyAssignmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExamToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExamRedoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Exam2ndRedoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ProcessExamForStudent As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProcessExamRedoForStudent As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProcessExam2ndReDoForStudent As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OlvColumn8 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents KryptonSplitContainer3 As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents lstClassGroups As ComponentFactory.Krypton.Toolkit.KryptonListBox
    Friend WithEvents llblRemoveClassGroup As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents llblEditClassGroup As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents llblAddClassGroup As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents KryptonLabel11 As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StudentAttendanceErrorsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OlvColumn9 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn10 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn11 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents AssignmentResultsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuitWithoutSavingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModuleResultsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OlvColumn12 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClassSelectorsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnRemoveStudent As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents OlvColumn13 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn14 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FormGroupsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModuleFeedbackCheckToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImportAttendanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImportEmailAddressesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportAttendanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExportModuleResultsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImportSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImportStudentsFromTextToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImportStudentsFromOtherSemesterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents splitStudentsSchedule As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents ViewScheduleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents olvSchedule As BrightIdeasSoftware.ObjectListView
    Friend WithEvents OlvColumn29 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn30 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn31 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn33 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn32 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn34 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn35 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn36 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents KryptonPanel2 As ComponentFactory.Krypton.Toolkit.KryptonPanel
    Friend WithEvents dtpScheduleDate As ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker
    Friend WithEvents llblRefreshSchedule As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents llblScheduleForwardOneDay As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents llblScheduleBackOneDay As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents ctxmnuActualSessions As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SkipActualSessionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblScheduleDay As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ExportStudentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UpdateEmailAddressToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ctxmnuTray As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SelectRandomStudentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EmailstudentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OlvColumn15 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents FailedoutcomesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OlvColumn16 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents llblScheduleNextUnprepped As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents llblScheduleNextClassDay As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents ImportClassToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReorderAdminNumbersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblRenumberAdminResetNumber As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblRenumberAdminCurrent As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents lblRenumberAdminCurrentLabel As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents TakeAttendanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StudentOutcomeResultsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OlvColumn17 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents CloseAssignmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FirstSubmissionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SecondSubmissionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ThirdSubmissionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents HideStudentsWhoPassedAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OlvColumn18 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents StudentphotoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents picStudent As System.Windows.Forms.PictureBox
    Friend WithEvents MarkSelectedAssignmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StudentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToggleHiddenForSelectedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmrAutoSave As System.Windows.Forms.Timer
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CloseAssignmentToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseAssignment1stToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseAssignment2ndToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseAssignment3rdToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SessionprepStatusToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AssignmentProcessingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OlvColumn19 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents ExportScheduleAsICalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents OlvColumn20 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents ClearStudentFilterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OlvColumn21 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents ViewLogFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExcuseMostRecentAbsenceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FindDuplicateStudentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmailOnlineQuizResultsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FindhistoricalStudentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents llblLoadFutureOneSemester As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents llblLoadPreviousOneSemester As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents llblLoadLatestSemester As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents ScheduledSessionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator12 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AssignmentMoveUpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AssignmentMoveDownToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SendBulkEmailToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManageImprovementItemsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmailAssignmentResultsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EitherOrToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OlvColumn22 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn23 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents ExportMarkingResultsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportMarkingResultsFirstSubmitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportMarkingResultsSecondSubmitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportMarkingResultsThirdSubmitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StudentQualityToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OlvColumn24 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents SetGendermaleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetGenderfemaleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearTagsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OlvColumn25 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents ctxmnuClasses As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditClassToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmailclassToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteClassToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator13 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents StatisticsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StudentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HiddenStudentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VisibleStudentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ctxmnuNewAssignment As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NewBTECAssignmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewNormalAssignmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImportImprovementItemsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImportStudentAssignmentScoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StudentGradesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SemesterStatisticsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblStudentCount As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents ExportStudentGradesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProcessAddDropStudentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator14 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RemoveAllStudentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemoveAllStudentsFromSelectedClassToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OlvColumn26 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn27 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn28 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents ScheduleNotesSplitter As ComponentFactory.Krypton.Toolkit.KryptonSplitContainer
    Friend WithEvents txtNotes As System.Windows.Forms.TextBox
    Friend WithEvents NotesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblStopwatchDuration As ComponentFactory.Krypton.Toolkit.KryptonLabel
    Friend WithEvents llblStartPauseStopwatch As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents tmrStopwatch As System.Windows.Forms.Timer
    Friend WithEvents llblClearNotes As ComponentFactory.Krypton.Toolkit.KryptonLinkLabel
    Friend WithEvents FilterForSelectedGroupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExcessiveAbsencesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator15 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BatchSaveMarkingSheetsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FirstTryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SecondTryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ThirdTryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadClassToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportMarkingResultsIsolatedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportMarkingResultsIsolatedFirstSubmitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportMarkingResultsIsolatedSecondSubmitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExportMarkingResultsIsolatedThirdSubmitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CheckForupdatesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator16 As ToolStripSeparator
    Friend WithEvents UpgradeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents kryptonPalette2 As ComponentFactory.Krypton.Toolkit.KryptonPalette
End Class
