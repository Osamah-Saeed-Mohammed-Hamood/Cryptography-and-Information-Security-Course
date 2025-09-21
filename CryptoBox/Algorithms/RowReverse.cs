using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace CryptoBox.Algorithms
{
    internal class RowReverse
    {
        public static string Encrypt(string input)
        {
            string[] lines = input.Split('\n');
            for (int i = 0; i < lines.Length; i++)
                lines[i] = new string(lines[i].Reverse().ToArray());
            return string.Join("\n", lines);
        }

        public static string Decrypt(string input)
        {
            return Encrypt(input); // نفس العملية
        }
    }
}

