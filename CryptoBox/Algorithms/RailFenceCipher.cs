using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoBox.Algorithms
{
    internal class RailFenceCipher
    {
        public static string Encrypt(string text, int rails)
        {
            if (rails <= 1) return text;

            string[] rail = new string[rails];
            for (int i = 0; i < rails; i++) rail[i] = "";

            int dir = 1, row = 0;
            foreach (char c in text)
            {
                rail[row] += c;
                row += dir;
                if (row == 0 || row == rails - 1) dir *= -1;
            }

            return string.Join("", rail);
        }

        public static string Decrypt(string cipher, int rails)
        {
            if (rails <= 1) return cipher;

            bool[,] mark = new bool[rails, cipher.Length];
            int dir = 1, row = 0;

            for (int i = 0; i < cipher.Length; i++)
            {
                mark[row, i] = true;
                row += dir;
                if (row == 0 || row == rails - 1) dir *= -1;
            }

            char[,] matrix = new char[rails, cipher.Length];
            int index = 0;

            for (int r = 0; r < rails; r++)
                for (int c = 0; c < cipher.Length; c++)
                    if (mark[r, c] && index < cipher.Length)
                        matrix[r, c] = cipher[index++];

            string result = "";
            row = 0; dir = 1;
            for (int i = 0; i < cipher.Length; i++)
            {
                result += matrix[row, i];
                row += dir;
                if (row == 0 || row == rails - 1) dir *= -1;
            }

            return result;
        }
    }
}
