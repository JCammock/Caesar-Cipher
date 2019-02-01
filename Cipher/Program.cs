using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            Encryption e = new Encryption();

            Console.WriteLine("Please enter the string to encrypt");
            e.SetUnencrypted(Console.ReadLine());
            string encrypted = e.Encrypt(3);
            Console.WriteLine("Your encrypted string is: " + encrypted);
            Console.Read();

        }
    }
}
