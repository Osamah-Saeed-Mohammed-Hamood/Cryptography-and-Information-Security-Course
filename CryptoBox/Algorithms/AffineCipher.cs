using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoBox.Algorithms
{
    internal class AffineCipher
    {
        static string alphabet = "ابتثجحخدذرزسشصضطظعغفقكلمنهويأإىؤئء" +
                                 "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz" +
                                 "0123456789 .,!?@#$%^&*()-_=+;:'\"/\\<>[]{}";

        public static string Encrypt(string input, int a, int b)
        {
            string result = "";
            int m = alphabet.Length;
            foreach (char c in input)
            {
                int idx = alphabet.IndexOf(c);
                if (idx == -1) result += c;
                else result += alphabet[(a * idx + b) % m];
            }
            return result;
        }

        public static string Decrypt(string input, int a, int b)
        {
            int m = alphabet.Length;
            int a_inv = MultiplicativeInverse(a, m);
            string result = "";
            foreach (char c in input)
            {
                int idx = alphabet.IndexOf(c);
                if (idx == -1) result += c;
                else result += alphabet[(a_inv * (idx - b + m)) % m];
            }
            return result;
        }

        private static int MultiplicativeInverse(int a, int m)
        {
            for (int i = 1; i < m; i++)
                if ((a * i) % m == 1) return i;
            throw new Exception("No multiplicative inverse for a = " + a);
        }
    }
}
