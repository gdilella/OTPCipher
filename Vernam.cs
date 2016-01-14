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
                plaintext = rgx.Replace(value, "").ToLower().Replace(" ","").ToCharArray();
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

        public void Cipher() { }

        public void Decipher() { }

        public void GenerateKey()
        {
            Random r = new Random();
            key = new char[plaintext.Length - 1];

            for(int i = 0; i < plaintext.Length; i++)
            {
                
            }
        }
    }
}
