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
            bool quit = false;
            Console.WriteLine("OTPCipher by Gianmarco Di Lella CC-BY-SA");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            while (!quit)
            {
                Console.WriteLine("C: Cipher | D: Decipher | Q: Quit\n");
                Console.WriteLine("Choose mode:");
                string mode = Console.ReadLine();
                if (mode == "c" || mode == "C")
                {
                    Console.WriteLine("\nInsert Plaintext: ");
                    Vernam v = new Vernam();
                    v.Plaintext = Console.ReadLine();
                    v.GenerateKey();
                    Console.WriteLine("KEY: " + v.Key);
                    v.Cipher();
                    Console.WriteLine("CIPHERTEXT: " + v.Ciphertext);
                }
                else if (mode == "d" || mode == "D")
                {
                    Console.WriteLine("\nInsert Ciphertext:");
                    Vernam v = new Vernam();
                    v.Ciphertext = Console.ReadLine();
                    Console.WriteLine("Insert Key:");
                    v.Key = Console.ReadLine();
                    v.Decipher();
                    Console.WriteLine("PLAINTEXT: " + v.Plaintext);
                }
                else if (mode == "q" || mode == "Q")
                {
                    quit = true;
                }
            }
        }
    }
}
