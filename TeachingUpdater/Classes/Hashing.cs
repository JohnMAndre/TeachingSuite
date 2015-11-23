using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;

    class Hashing
    {
        public static byte[] GetFileHash(string filename)
        {
            using (SHA512Managed sha = new SHA512Managed())
            {
                FileStream fs = File.OpenRead(filename);
                byte[] hash = sha.ComputeHash(fs);
                fs.Close();
                return hash;
            }
        }

        public static bool HashMatches(string hash1, byte[] hash2)
        {
            byte[] hashA = Convert.FromBase64String(hash1);
            return ArraysMatch(hashA, hash2);
        }

        private static bool ArraysMatch(byte[] a, byte[] b)
        {
            if (a.Length != b.Length)
                return false;
            else
            {
                bool boolReturn = true;// assume they match

                int intCounterMax = a.Length - 1;
                for (int intCounter = 0; intCounter < intCounterMax; intCounter++)
                {
                    if (a[intCounter] != b[intCounter])
                    {
                        // first non-match kicks us out of the loop
                        boolReturn = false;
                        break;
                    }

                }
                return boolReturn;
            }
        }
    }
