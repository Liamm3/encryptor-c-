using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a message:");
            string message = Console.ReadLine();
            Console.WriteLine("Please enter the value of shift:");
            int shift = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine("Your encoded message (Caesar): " + VerschlüsselungCaesar.EncodeCaesar(message, shift));

            Console.WriteLine("Please enter a key:");
            string key = Console.ReadLine();

            Console.WriteLine("Your encoded message (Vigenère): " + VerschlüsselungVigenere.EncodeVigenere(message, key));
        }
    }
}
