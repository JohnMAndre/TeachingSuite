using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Crypto
    {
        /// <summary>
        /// Generates an alphanumeric string of the desired length using a crypto RNG
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        public static string GenerateAlphanumericString(int length)
        {
            while (true)
            {
                int i;
                byte[] buffer1 = new byte[length];
                char[] chPassword = new char[length];
                char[] chPunctuation = "!@@$%^^*()_-+=[{]};:>|./?".ToCharArray();
                System.Security.Cryptography.RNGCryptoServiceProvider rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
                rng.GetBytes(buffer1);
                for (i = 0; i < length; i++)
                {
                    int rndChar = (buffer1[i] % 62);
                    if (rndChar < 10)
                        chPassword[i] = Convert.ToChar(Convert.ToUInt16(48 + rndChar));
                    else if (rndChar < 36)
                        chPassword[i] = Convert.ToChar(Convert.ToUInt16(65 + rndChar) - 10);
                    else if (rndChar < 62)
                        chPassword[i] = Convert.ToChar(Convert.ToUInt16(97 + rndChar) - 36);
                    else
                        chPassword[i] = chPunctuation[rndChar - 62];
                }

                return new string(chPassword);
            }
        }

    }
