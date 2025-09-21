using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CryptoBox.Algorithms;

namespace CryptoBox
{
    public partial class CryptoBox : Form
    {
        public CryptoBox()
        {
            InitializeComponent();
            InitAlgorithms();
            InitTool();
        }

        private void InitAlgorithms()
        {
            comboAlgorithms.Items.AddRange(new string[]
            {
                "Caesar", "Affine", "Hill", "Playfair",
                "Rail Fence", "Substitution",
                "Reverse Text", "Reverse Blocks", "Reverse Lines"
            });

            comboAlgorithms.SelectedIndex = -1;
        }

        private void InitTool()
        {
            btnDecrypt.Enabled = false;
            btnEncrypt.Enabled = false;
            txtKey.Visible = false;
            lblKey.Visible = false;
        }

        private void EnabeledBtn()
        {
            if (comboAlgorithms.SelectedIndex == -1 && rchInput.Text == "")
            {
                btnDecrypt.Enabled = false;
                btnEncrypt.Enabled = false;
            }
            else if (comboAlgorithms.SelectedIndex != -1 && rchInput.Text != "")
            {
                btnDecrypt.Enabled = true;
                btnEncrypt.Enabled = true;
            }
        }

        private void VisibleTool()
        {
            string algo = comboAlgorithms.SelectedItem.ToString();

            lblKey.Visible = true;
            txtKey.Visible = true;

            if (algo == "Caesar")
            {
                lblKey.Text = "أدخل المفتاح (عدد)";
         
            }
            else if (algo == "Affine")
            {
                lblKey.Text = "أدخل المفتاحين (a,b)";
            }
            else if (algo == "Hill")
            {
                lblKey.Text = "أدخل مصفوفة المفتاح (مثال: 3,3,2,5)";
            }
            else if (algo == "Playfair")
            {
                lblKey.Text = "أدخل كلمة المفتاح";
            }
            else if (algo == "Rail Fence")
            {
                lblKey.Text = "أدخل عدد الصفوف";
            }
            else if (algo == "Substitution")
            {
                lblKey.Text = "أدخل الأبجدية البديلة";
            }
            else if (algo == "Reverse Text" || algo == "Reverse Lines")
            {
                lblKey.Visible = false;
                txtKey.Visible = false;
            }
            else if (algo == "Reverse Blocks")
            {
                lblKey.Text = "أدخل حجم البلوك";
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (rchInput.Text != "" && comboAlgorithms.SelectedIndex != -1)
            {
                string algo = comboAlgorithms.SelectedItem.ToString();
                string input = rchInput.Text;
                string output = "";

                try
                {
                    switch(algo)
                    {
                        case "Caesar":
                            {
                                output = CaesarCipher.Encrypt(input, int.Parse(txtKey.Text));
                                break;
                            }
                        case "Affine":
                            {
                                string[] parts = txtKey.Text.Split(',');
                                int a = int.Parse(parts[0].Trim());
                                int b = int.Parse(parts[1].Trim());
                                output = AffineCipher.Encrypt(input, a, b); break;
                            }
                        case "Hill":
                            {
                                int[,] keyMatrix = ParseMatrix(txtKey.Text);
                                string encrypted = HillCipher.Encrypt(input, keyMatrix);
                                output = encrypted;
                                break;
                            }
                        case "Playfair":
                            {
                                output = PlayfairCipher.Encrypt(input, txtKey.Text);
                                break;
                            }
                        case "Rail Fence":
                            {
                                output = RailFenceCipher.Encrypt(input, int.Parse(txtKey.Text));
                                break;
                            }
                        case "Substitution":
                            {
                                output = SubstitutionCipher.Encrypt(input, txtKey.Text);
                                break;
                            }
                        case "Reverse Text":
                            {
                                output = TextReverse.Encrypt(input);
                                break;
                            }
                        case "Reverse Blocks":
                            {
                                output = BlocksReverse.Encrypt(input, int.Parse(txtKey.Text));
                                break;
                            }
                        case "Reverse Lines":
                            {
                                output = RowReverse.Encrypt(input);
                                break;
                            }
                    }
                    rchOutput.Text = output;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }
            }


        }
        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (rchOutput.Text != "" && comboAlgorithms.SelectedIndex != -1)
            {
                string algo = comboAlgorithms.SelectedItem.ToString();
                string input = rchOutput.Text;
                string output = "";

                try
                {
                    switch (algo)
                    {
                        case "Caesar":
                            output = CaesarCipher.Decrypt(input, int.Parse(txtKey.Text));
                            break;

                        case "Affine":
                            string[] parts = txtKey.Text.Split(',');
                            int a = int.Parse(parts[0].Trim());
                            int b = int.Parse(parts[1].Trim());
                            output = AffineCipher.Decrypt(input, a, b);
                            break;

                        case "Hill":
                            int[,] keyMatrix = ParseMatrix(txtKey.Text);
                            output = HillCipher.Decrypt(input, keyMatrix);
                            break;

                        case "Playfair":
                            output = PlayfairCipher.Decrypt(input, txtKey.Text);
                            break;

                        case "Rail Fence":
                            output = RailFenceCipher.Decrypt(input, int.Parse(txtKey.Text));
                            break;

                        case "Substitution":
                            output = SubstitutionCipher.Decrypt(input, txtKey.Text);
                            break;

                        case "Reverse Text":
                            output = TextReverse.Decrypt(input);
                            break;

                        case "Reverse Blocks":
                            output = BlocksReverse.Decrypt(input, int.Parse(txtKey.Text));
                            break;

                        case "Reverse Lines":
                            output = RowReverse.Decrypt(input);
                            break;
                    }

                    rchOutput.Text = output;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private int[,] ParseMatrix(string input)
        {
            int[] numbers = input.Split(',').Select(s => int.Parse(s.Trim())).ToArray();
            int n = (int)Math.Sqrt(numbers.Length);

            if (n * n != numbers.Length)
                throw new Exception("عدد عناصر المصفوفة غير مربع كامل");

            int[,] matrix = new int[n, n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    matrix[i, j] = numbers[i * n + j];

            return matrix;
        }

        private void lnkEncrypt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void rchInput_TextChanged(object sender, EventArgs e)
        {
            EnabeledBtn();
        }

        private void comboAlgorithms_SelectedIndexChanged(object sender, EventArgs e)
        {
            VisibleTool();
        }
    }
}
