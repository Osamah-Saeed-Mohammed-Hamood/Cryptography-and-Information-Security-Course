using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoBox.Algorithms
{
    internal class HillCipher
    {
        static string alphabet = "ابتثجحخدذرزسشصضطظعغفقكلمنهويأإىؤئء" +
                                 "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz" +
                                 "0123456789 .,!?@#$%^&*()-_=+;:'\"/\\<>[]{}";

        public static string Encrypt(string input, int[,] keyMatrix)
        {
            int n = keyMatrix.GetLength(0);
            if (keyMatrix.GetLength(1) != n)
                throw new Exception("مصفوفة المفاتيح يجب أن تكون مربعة NxN");

            int m = alphabet.Length;
            List<int> numbers = input.Select(c => alphabet.IndexOf(c)).Where(i => i >= 0).ToList();

            // Padding
            while (numbers.Count % n != 0)
                numbers.Add(0);

            string result = "";

            for (int i = 0; i < numbers.Count; i += n)
            {
                int[] vector = new int[n];
                for (int j = 0; j < n; j++)
                    vector[j] = numbers[i + j];

                int[] cipherVector = MultiplyMatrixVector(keyMatrix, vector, m);
                foreach (var val in cipherVector)
                    result += alphabet[val];
            }

            return result;
        }

        public static string Decrypt(string input, int[,] keyMatrix)
        {
            int n = keyMatrix.GetLength(0);
            if (keyMatrix.GetLength(1) != n)
                throw new Exception("مصفوفة المفاتيح يجب أن تكون مربعة NxN");

            int m = alphabet.Length;

            int det = Determinant(keyMatrix, n);
            det = ((det % m) + m) % m;
            int detInv = MultiplicativeInverse(det, m);
            if (detInv == -1)
                throw new Exception("مصفوفة المفتاح غير قابلة للعكس");

            int[,] adj = Adjugate(keyMatrix, n);
            int[,] invMatrix = new int[n, n];

            // حساب مصفوفة المعكوسة modulo m
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    invMatrix[i, j] = (adj[i, j] * detInv % m + m) % m;

            List<int> numbers = input.Select(c => alphabet.IndexOf(c)).Where(i => i >= 0).ToList();
            string result = "";

            for (int i = 0; i < numbers.Count; i += n)
            {
                int[] vector = new int[n];
                for (int j = 0; j < n; j++)
                    vector[j] = numbers[i + j];

                int[] plainVector = MultiplyMatrixVector(invMatrix, vector, m);
                foreach (var val in plainVector)
                    result += alphabet[val];
            }

            return result;
        }
        private static int[] MultiplyMatrixVector(int[,] matrix, int[] vector, int mod)
        {
            int n = vector.Length;
            int[] result = new int[n];
            for (int i = 0; i < n; i++)
            {
                result[i] = 0;
                for (int j = 0; j < n; j++)
                    result[i] += matrix[i, j] * vector[j];
                result[i] %= mod;
            }
            return result;
        }

        private static int Determinant(int[,] matrix, int n)
        {
            if (n == 1) return matrix[0, 0];
            if (n == 2) return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];

            int det = 0;
            for (int p = 0; p < n; p++)
            {
                int[,] subMatrix = new int[n - 1, n - 1];
                for (int i = 1; i < n; i++)
                {
                    int colIndex = 0;
                    for (int j = 0; j < n; j++)
                    {
                        if (j == p) continue;
                        subMatrix[i - 1, colIndex] = matrix[i, j];
                        colIndex++;
                    }
                }
                det += (p % 2 == 0 ? 1 : -1) * matrix[0, p] * Determinant(subMatrix, n - 1);
            }
            return det;
        }

        private static int MultiplicativeInverse(int a, int m)
        {
            a = ((a % m) + m) % m;
            for (int i = 1; i < m; i++)
                if ((a * i) % m == 1) return i;
            return -1;
        }

        private static int[,] Adjugate(int[,] matrix, int n)
        {
            int[,] adj = new int[n, n];
            if (n == 1) { adj[0, 0] = 1; return adj; }
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    int[,] subMatrix = new int[n - 1, n - 1];
                    int r = 0;
                    for (int row = 0; row < n; row++)
                    {
                        if (row == i) continue;
                        int c = 0;
                        for (int col = 0; col < n; col++)
                        {
                            if (col == j) continue;
                            subMatrix[r, c] = matrix[row, col];
                            c++;
                        }
                        r++;
                    }
                    int sign = ((i + j) % 2 == 0) ? 1 : -1;
                    adj[j, i] = sign * Determinant(subMatrix, n - 1); // مقلوبة الصفوف والأعمدة
                }
            return adj;
        }
    }
}

