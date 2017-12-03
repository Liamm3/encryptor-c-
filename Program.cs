using System;

namespace Encryption
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Message msg = new Message("hallo welt");

            msg.Encrypt("baum");
            msg.Decrypt("baum");

            Console.WriteLine(msg.message);
        }
    }
}
