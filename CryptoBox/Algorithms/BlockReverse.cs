using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoBox.Algorithms
{
    internal class BlocksReverse
    {
        public static string Encrypt(string input, int blockSize)
        {
            List<string> blocks = new List<string>();
            for (int i = 0; i < input.Length; i += blockSize)
            {
                string block = input.Substring(i, Math.Min(blockSize, input.Length - i));
                blocks.Add(new string(block.Reverse().ToArray()));
            }
            return string.Join("", blocks);
        }

        public static string Decrypt(string input, int blockSize)
        {
            return Encrypt(input, blockSize); // نفس العملية
        }
    }
}
