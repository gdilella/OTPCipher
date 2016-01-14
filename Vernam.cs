using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OTPCipher
{
    class Vernam
    {
        char[] plaintext;
        char[] key;
        char[] ciphertext;

        public string Plaintext
        {
            get
            {
                return new String(plaintext);
            }

            set
            {
                Regex rgx = new Regex("[^a-zA-Z0-9 -]");
                plaintext = rgx.Replace(value, "").ToLower().Replace(" ", "").ToCharArray();
            }
        }

        public string Key
        {
            get
            {
                return new String(key);
            }

            set
            {
                key = value.ToCharArray();
            }
        }

        public string Ciphertext
        {
            get
            {
                return new string(ciphertext);
            }

            set
            {
                ciphertext = value.ToCharArray();
            }
        }

        /// <summary>
        /// Get the Ciphertext
        /// </summary>
        public void Cipher()
        {
            ciphertext = new char[key.Length];

            for(int i = 0; i < key.Length; i++)
            {
                ciphertext[i] = ConvertIntToChar(CircularAdding(ConvertCharToInt(plaintext[i]),ConvertCharToInt(key[i])));
            }
        }

        /// <summary>
        /// Get the plaintext
        /// </summary>
        public void Decipher()
        {
            plaintext = new char[key.Length];

            for(int i = 0; i < key.Length; i++)
            {
                plaintext[i] = ConvertIntToChar(CircularAdding(ConvertCharToInt(ciphertext[i]) - ConvertCharToInt(key[i]),26));
            }
        }

        /// <summary>
        /// Generate a random key
        /// </summary>
        public void GenerateKey()
        {
            Random r = new Random();
            key = new char[plaintext.Length];

            for(int i = 0; i < plaintext.Length; i++)
            {
               key[i] = ConvertIntToChar(r.Next(0, 36));
            }
        }

        /// <summary>
        /// Convert a interger to a character
        /// </summary>
        /// <param name="n">Number to convert</param>
        /// <returns></returns>
        char ConvertIntToChar(int n)
        {
            switch (n)
            {
                case 0:
                    return 'a';
                case 1:
                    return 'b';
                case 2:
                    return 'c';
                case 3:
                    return 'd';
                case 4:
                    return 'e';
                case 5:
                    return 'f';
                case 6:
                    return 'g';
                case 7:
                    return 'h';
                case 8:
                    return 'i';
                case 9:
                    return 'j';
                case 10:
                    return 'k';
                case 11:
                    return 'l';
                case 12:
                    return 'm';
                case 13:
                    return 'n';
                case 14:
                    return 'o';
                case 15:
                    return 'p';
                case 16:
                    return 'q';
                case 17:
                    return 'r';
                case 18:
                    return 's';
                case 19:
                    return 't';
                case 20:
                    return 'u';
                case 21:
                    return 'v';
                case 22:
                    return 'w';
                case 23:
                    return 'x';
                case 24:
                    return 'y';
                case 25:
                    return 'z';
                default:
                    return 'a';
            }
        }

        /// <summary>
        /// Convert a character to a interger
        /// </summary>
        /// <param name="c">Character to convert</param>
        /// <returns></returns>
        int ConvertCharToInt(char c)
        {
            switch (c)
            {
                case 'a':
                    return 0;
                case 'b':
                    return 1;
                case 'c':
                    return 2;
                case 'd':
                    return 3;
                case 'e':
                    return 4;
                case 'f':
                    return 5;
                case 'g':
                    return 6;
                case 'h':
                    return 7;
                case 'i':
                    return 8;
                case 'j':
                    return 9;
                case 'k':
                    return 10;
                case 'l':
                    return 11;
                case 'm':
                    return 12;
                case 'n':
                    return 13;
                case 'o':
                    return 14;
                case 'p':
                    return 15;
                case 'q':
                    return 16;
                case 'r':
                    return 17;
                case 's':
                    return 18;
                case 't':
                    return 19;
                case 'u':
                    return 20;
                case 'v':
                    return 21;
                case 'w':
                    return 22;
                case 'x':
                    return 23;
                case 'y':
                    return 24;
                case 'z':
                    return 25;
                default:
                    return 26;
            }
        }

        /// <summary>
        /// Circular add two number
        /// </summary>
        /// <param name="x">Frist addend</param>
        /// <param name="y">Second addend</param>
        /// <returns></returns>
        int CircularAdding(int x, int y)
        {
            int z = x + y;
            if(z > 26)
            {
                z -= 26;
            }

            return z;
        }
    }
}
