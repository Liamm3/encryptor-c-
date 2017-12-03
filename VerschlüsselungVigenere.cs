using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar
{
    class VerschlüsselungVigenere
    {
        public static string EncodeVigenere(string message, string key)
        {
            string result = "";
            string abc = "abcdefghijklmnopqrstuvwxyz";

            for (int i = 0; i < message.Length; i++)
            {
                if (abc.IndexOf(message[i]) == -1)
                {
                    result += message[i];
                }
                else
                {
                    int messageIndex = abc.IndexOf(message[i]);
                    int keyIndex = abc.IndexOf(key[i % key.Length]);
                    result += abc[(messageIndex + keyIndex) % abc.Length];
                }
            }
            return result;
        }
    }
}
