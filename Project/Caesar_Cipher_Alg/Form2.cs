using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caesar_Cipher_Alg
{
    public partial class Form2 : Form
    {
        public object DialogResultOK { get; private set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtInput.Text = ofd.FileName;
                    MessageBox.Show("تم تحديد الملف : " + ofd.FileName);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    txtOutput.Text = sfd.FileName;
                    MessageBox.Show("سيتم حفظ الملف في : " + sfd.FileName);
                }
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtInput.Text) || string.IsNullOrEmpty(txtOutput.Text))
            {
                MessageBox.Show("يرجى تحديد ملفات الادخال والاخراج");
                return;
            }
            if (!int.TryParse(txtKey.Text, out int key))
            {
                MessageBox.Show("يرجى ادخال مفتاح صحيح");
                return;
            }

            string text = File.ReadAllText(txtInput.Text);
            string entxt = Caesar.caesarCipher(text, key);
            File.WriteAllText(txtOutput.Text, entxt);
            MessageBox.Show("تم تشفير الملف وحفظه بنجاح");

        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtInput.Text) || string.IsNullOrEmpty(txtOutput.Text))
            {
                MessageBox.Show("يرجى تحديد ملفات الادخال والاخراج");
                return;
            }
            if (!int.TryParse(txtKey.Text, out int key))
            {
                MessageBox.Show("يرجى ادخال مفتاح صحيح");
                return;
            }
            string text = File.ReadAllText(txtInput.Text);
            string etext = Caesar.caesarCipher(text, -key);
            File.WriteAllText(txtOutput.Text, etext);
            MessageBox.Show("تم فك تشفير الملف وحفظه بنجاح");
        }
    }
}
