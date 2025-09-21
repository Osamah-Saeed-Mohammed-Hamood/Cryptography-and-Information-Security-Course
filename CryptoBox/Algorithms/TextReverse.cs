using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CryptoBox.Algorithms
{
    internal class TextReverse
    {
        public static string Encrypt(string input)
        {
            char[] arr = input.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        public static string Decrypt(string input)
        {
            return Encrypt(input); // عكس النص مرة أخرى
        }
    }
}

