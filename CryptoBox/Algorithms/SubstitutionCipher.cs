using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoBox.Algorithms
{
    internal class SubstitutionCipher
    {
        static string alphabet = "ابتثجحخدذرزسشصضطظعغفقكلمنهويأإىؤئء" +
                                 "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz" +
                                 "0123456789 .,!?@#$%^&*()-_=+;:'\"/\\<>[]{}";

        public static string Encrypt(string input, string keyAlphabet)
        {
            if (keyAlphabet.Length != alphabet.Length)
                throw new Exception("طول الأبجدية البديلة غير مطابق.");

            string result = "";
            foreach (char c in input)
            {
                int idx = alphabet.IndexOf(c);
                result += (idx == -1) ? c : keyAlphabet[idx];
            }
            return result;
        }

        public static string Decrypt(string input, string keyAlphabet)
        {
            if (keyAlphabet.Length != alphabet.Length)
                throw new Exception("طول الأبجدية البديلة غير مطابق.");

            string result = "";
            foreach (char c in input)
            {
                int idx = keyAlphabet.IndexOf(c);
                result += (idx == -1) ? c : alphabet[idx];
            }
            return result;
        }
    }
}
