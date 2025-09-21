using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CryptoBox.Algorithms
{
    internal class PlayfairCipher
    {
        static string alphabet = "ابتثجحخدذرزسشصضطظعغفقكلمنهويأإىؤئء" +
                                 "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz" +
                                 "0123456789 .,!?@#$%^&*()-_=+;:'\"/\\<>[]{}";

        public static string Encrypt(string input, string key)
        {
            int shift = key.Length % alphabet.Length;
            return CaesarCipher.Encrypt(input, shift);
        }

        public static string Decrypt(string input, string key)
        {
            int shift = key.Length % alphabet.Length;
            return CaesarCipher.Decrypt(input, shift);
        }
    }
}
