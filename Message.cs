using System;
using System.Text;

namespace Encryption
{
    public class Message
    {
        public string message { get; private set; }
        private const string alphabet = "abcdefghijklmnopqrstuvwxyz";
        private const string encode = "encode";
        private const string decode = "decode";

        public Message()
        {
            message = "";
        }

        public Message(string message) 
        {
            this.message = message;
        }

        private char ShiftChar(char c, int shift)
        {
            if (alphabet.IndexOf(c) == -1)
            {
                return c;
            }

            if (shift < 0)
            {
                return alphabet[(alphabet.IndexOf(c) - (shift * -1) + alphabet.Length) % alphabet.Length];
            }

            return alphabet[(alphabet.IndexOf(c) + shift) % alphabet.Length];
        }

        public void Encrypt(int number)
        {
            message = ByNumber(number, encode);
        }

        public void Encrypt(string key)
        {
            message = ByKey(key, encode);
        }

        public void Decrypt(int number) 
        {
            message = ByNumber(number, decode);
        }

        public void Decrypt(string key)
        {
            message = ByKey(key, decode);
        }

        private string ByNumber(int number, string variation)
        {
            string result = "";

            for (int i = 0; i < message.Length; i++)
            {
                int index = number;

                if (variation == decode)
                {
                    index *= -1;
                }

                char cipher = ShiftChar(message[i], index);
                result += cipher;
            }

            return result.ToString();
        }

        private string ByKey(string key, string variation)
        {
            string result = "";

            for (int i = 0; i < message.Length; i++)
            {
                int keyIndex = alphabet.IndexOf(key[i % key.Length]);

                if (variation == decode)
                {
                    keyIndex *= -1;
                }


                char cipher = ShiftChar(message[i], keyIndex);
                result += cipher;
            }

            return result.ToString();
        }
    }
}
