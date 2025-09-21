namespace CryptoBox
{
    partial class CryptoBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.lblChooseAlgorithm = new System.Windows.Forms.Label();
            this.lnkEncrypt = new System.Windows.Forms.LinkLabel();
            this.rchInput = new System.Windows.Forms.RichTextBox();
            this.comboAlgorithms = new System.Windows.Forms.ComboBox();
            this.rchOutput = new System.Windows.Forms.RichTextBox();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.lblKey = new System.Windows.Forms.Label();
            this.lblTextInput = new System.Windows.Forms.Label();
            this.lblTextOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.Location = new System.Drawing.Point(1194, 350);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(216, 73);
            this.btnEncrypt.TabIndex = 0;
            this.btnEncrypt.Text = "تشفير";
            this.btnEncrypt.UseVisualStyleBackColor = false;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // lblChooseAlgorithm
            // 
            this.lblChooseAlgorithm.AutoSize = true;
            this.lblChooseAlgorithm.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseAlgorithm.Location = new System.Drawing.Point(1211, 86);
            this.lblChooseAlgorithm.Name = "lblChooseAlgorithm";
            this.lblChooseAlgorithm.Size = new System.Drawing.Size(183, 32);
            this.lblChooseAlgorithm.TabIndex = 1;
            this.lblChooseAlgorithm.Text = "اختر الخوارزمية";
            // 
            // lnkEncrypt
            // 
            this.lnkEncrypt.AutoSize = true;
            this.lnkEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkEncrypt.Location = new System.Drawing.Point(1216, 591);
            this.lnkEncrypt.Name = "lnkEncrypt";
            this.lnkEncrypt.Size = new System.Drawing.Size(172, 46);
            this.lnkEncrypt.TabIndex = 2;
            this.lnkEncrypt.TabStop = true;
            this.lnkEncrypt.Text = "تشفير ملف";
            this.lnkEncrypt.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkEncrypt_LinkClicked);
            // 
            // rchInput
            // 
            this.rchInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchInput.Location = new System.Drawing.Point(25, 28);
            this.rchInput.Name = "rchInput";
            this.rchInput.Size = new System.Drawing.Size(782, 321);
            this.rchInput.TabIndex = 3;
            this.rchInput.Text = "";
            this.rchInput.TextChanged += new System.EventHandler(this.rchInput_TextChanged);
            // 
            // comboAlgorithms
            // 
            this.comboAlgorithms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAlgorithms.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboAlgorithms.FormattingEnabled = true;
            this.comboAlgorithms.Location = new System.Drawing.Point(1115, 153);
            this.comboAlgorithms.Name = "comboAlgorithms";
            this.comboAlgorithms.Size = new System.Drawing.Size(354, 46);
            this.comboAlgorithms.TabIndex = 4;
            this.comboAlgorithms.SelectedIndexChanged += new System.EventHandler(this.comboAlgorithms_SelectedIndexChanged);
            // 
            // rchOutput
            // 
            this.rchOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchOutput.Location = new System.Drawing.Point(25, 372);
            this.rchOutput.Name = "rchOutput";
            this.rchOutput.ReadOnly = true;
            this.rchOutput.Size = new System.Drawing.Size(782, 321);
            this.rchOutput.TabIndex = 5;
            this.rchOutput.Text = "";
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrypt.Location = new System.Drawing.Point(1194, 468);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(216, 73);
            this.btnDecrypt.TabIndex = 6;
            this.btnDecrypt.Text = " فك تشفير";
            this.btnDecrypt.UseVisualStyleBackColor = false;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // txtKey
            // 
            this.txtKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKey.Location = new System.Drawing.Point(1163, 277);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(258, 38);
            this.txtKey.TabIndex = 7;
            this.txtKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKey.Location = new System.Drawing.Point(1222, 226);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(140, 32);
            this.lblKey.TabIndex = 8;
            this.lblKey.Text = "أدخل المفتاح";
            // 
            // lblTextInput
            // 
            this.lblTextInput.AutoSize = true;
            this.lblTextInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextInput.Location = new System.Drawing.Point(813, 172);
            this.lblTextInput.Name = "lblTextInput";
            this.lblTextInput.Size = new System.Drawing.Size(146, 32);
            this.lblTextInput.TabIndex = 9;
            this.lblTextInput.Text = "النص المدخل";
            // 
            // lblTextOutput
            // 
            this.lblTextOutput.AutoSize = true;
            this.lblTextOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextOutput.Location = new System.Drawing.Point(813, 516);
            this.lblTextOutput.Name = "lblTextOutput";
            this.lblTextOutput.Size = new System.Drawing.Size(146, 32);
            this.lblTextOutput.TabIndex = 10;
            this.lblTextOutput.Text = "النص المشفر";
            // 
            // CryptoBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1582, 724);
            this.Controls.Add(this.lblTextOutput);
            this.Controls.Add(this.lblTextInput);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.rchOutput);
            this.Controls.Add(this.comboAlgorithms);
            this.Controls.Add(this.rchInput);
            this.Controls.Add(this.lnkEncrypt);
            this.Controls.Add(this.lblChooseAlgorithm);
            this.Controls.Add(this.btnEncrypt);
            this.MaximizeBox = false;
            this.Name = "CryptoBox";
            this.Text = "CryptoBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Label lblChooseAlgorithm;
        private System.Windows.Forms.LinkLabel lnkEncrypt;
        private System.Windows.Forms.RichTextBox rchInput;
        private System.Windows.Forms.ComboBox comboAlgorithms;
        private System.Windows.Forms.RichTextBox rchOutput;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.Label lblTextInput;
        private System.Windows.Forms.Label lblTextOutput;
    }
}

