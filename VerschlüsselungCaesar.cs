using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar
{
    class VerschlüsselungCaesar
    {
        public static string EncodeCaesar(string message, int shift)
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
                    result += abc[(messageIndex + shift) % abc.Length];
                }
            }
            return result;
        }
    }
}
