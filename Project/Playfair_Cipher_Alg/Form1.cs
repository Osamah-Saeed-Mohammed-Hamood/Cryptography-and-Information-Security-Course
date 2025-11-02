using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Playfair_Cipher_Alg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            string plaintext = txtInput.Text.Replace(" ", "");
            if (plaintext.Length % 2 != 0)
                plaintext += "س";
            string keyword = txtKey.Text.Replace(" ", "");
            string ciphertext = EncryptPlayfair(plaintext, keyword, true);
            txtResult.Text = ciphertext;
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string ciphertext = txtInput.Text.Replace(" ", "");
            string keyword = txtKey.Text.Replace(" ", "");

            string decryptedText = EncryptPlayfair(ciphertext, keyword, false);
            txtResult.Text = decryptedText;
        }

        private string EncryptPlayfair(string plaintext, string keyword, bool b)
        {
            char[,] matrix = GenerateMatrix(keyword);
            return ProcessText(plaintext, matrix, b); // true for encryption 
        }

        private string DecryptPlayfair(string ciphertext, string keyword)
        {
            char[,] matrix = GenerateMatrix(keyword);
            return ProcessText(ciphertext, matrix, false); // false for decryption 
        }

        private string ProcessText(string text, char[,] matrix, bool encrypt)
        {
            string result = "";

            // 1. Prepare the text by pairing letters and handling duplicates/odd 
            for (int i = 0; i < text.Length; i += 2)
            {
                if (i + 1 >= text.Length)
                    text += "س";

                if (i + 1 >= text.Length || text[i] == text[i + 1])
                {
                    text = text.Insert(i + 1, "X");
                }

                char a = text[i];
                char b = text[i + 1];

                (int row1, int col1) = FindPosition(matrix, a);
                (int row2, int col2) = FindPosition(matrix, b);

                // 2. Apply Playfair rules 
                if (row1 == row2) // Same row 
                {
                    int direction = encrypt ? 1 : 5;
                    result += matrix[row1, (col1 + direction) % 6];
                    result += matrix[row2, (col2 + direction) % 6];
                }
                else if (col1 == col2) // Same column 
                {
                    int direction = encrypt ? 1 : 5;
                    result += matrix[(row1 + direction) % 6, col1];
                    result += matrix[(row2 + direction) % 6, col2];
                }
                else // Rectangle 
                {
                    result += matrix[row2, col1];
                    result += matrix[row1, col2];
                }
            }
            return result;
        }

        private char[,] GenerateMatrix(string keyword)
        {
            char[,] matrix = new char[6, 6];
            string usedChars = "";

            string alphabet = "ابتثجحخدذرزسشصضطظعغفقكلمنهويؤءئىة+-* ";

            foreach (char c in keyword)
            {
                if (!usedChars.Contains(c))
                {
                    usedChars += c;
                }
            }

            foreach (char c in alphabet)
            {
                if (!usedChars.Contains(c))
                {
                    usedChars += c;
                }
            }

            int index = 0;
            for (int row = 0; row < 6; row++)
            {
                for (int col = 0; col < 6; col++)
                {
                    matrix[row, col] = usedChars[index++];
                }
            }

            return matrix;
        }


        private (int, int) FindPosition(char[,] matrix, char c)
        {
            for (int row = 0; row < 6; row++)
            {
                for (int col = 0; col < 6; col++)
                {
                    if (matrix[row, col] == c)
                    {
                        return (row, col);
                    }
                }
            }
            return (-1, -1);
        }
    }
}
