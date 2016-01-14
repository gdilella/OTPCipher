using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTPCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OTPCipher by Gianmarco Di Lella CC-BY-SA");
            Console.WriteLine("C: Cipher | D: Decipher");
            Console.WriteLine("Choose mode:");
            string mode = Console.ReadLine();
            if(mode == "c" || mode == "C")
            {
                Console.WriteLine("Insert plaintext: ");
                Vernam v = new Vernam();
                v.Plaintext = Console.ReadLine();
                v.GenerateKey();
                Console.WriteLine("KEY: " + v.Key);
                v.Cipher();
                Console.WriteLine("CIPHERTEXT: " + v.Ciphertext);
            }
            else if(mode == "d" || mode == "D")
            {

            }

            Console.ReadLine();
        }
    }
}
