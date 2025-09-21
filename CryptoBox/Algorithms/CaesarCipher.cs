using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoBox.Algorithms
{
    internal class CaesarCipher
    {
        static string alphabet = "ابتثجحخدذرزسشصضطظعغفقكلمنهويأإىؤئء" +  // العربية
                                 "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz" + // الإنجليزية
                                 "0123456789 .,!?@#$%^&*()-_=+;:'\"/\\<>[]{}"; // أرقام وعلامات

        CaesarCipher()
        {

        }
        public static string Encrypt(string input, int key)
        {
            string result = "";
            int len = alphabet.Length;

            foreach (char c in input)
            {
                int idx = alphabet.IndexOf(c);
                if (idx == -1) 
                {
                    result += c;
                }
                else
                {
                    int newIndex = (idx + key) % len;
                    if (newIndex < 0) newIndex += len;
                    result += alphabet[newIndex];
                }
            }
            return result;
        }

        public static string Decrypt(string input, int key)
        {
            return Encrypt(input, -key); 
        }
    }
}
