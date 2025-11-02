using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caesar_Cipher_Alg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (txtInput.Text.Trim() != "")
            {
                if (txtKey.Text.Trim() != "")
                {
                    txtresult.Text = Caesar.caesarCipher(txtInput.Text, int.Parse(txtKey.Text));
                }
                else
                {
                    MessageBox.Show("أدخل مفتاح التشفير");
                }
            }
            else
            {
                MessageBox.Show("الرجاء ادخل النص المراد تشفيره");
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (txtInput.Text.Trim() != "")
            {
                if (txtKey.Text.Trim() != "")
                {
                    txtresult.Text = Caesar.caesarCipher(txtInput.Text, -int.Parse(txtKey.Text));
                }
                else
                {
                    MessageBox.Show("أدخل مفتاح التشفير");
                }
            }
            else
            {
                MessageBox.Show("الرجاء ادخل النص المراد فك تشفيره");
            }
        }

        private void btnEncryptFile_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }
    }
}
