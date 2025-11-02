namespace Playfair_Cipher_Alg
{
    partial class Form1
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn13 = new System.Windows.Forms.Button();
            this.btn19 = new System.Windows.Forms.Button();
            this.btn25 = new System.Windows.Forms.Button();
            this.btn31 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn11 = new System.Windows.Forms.Button();
            this.btn12 = new System.Windows.Forms.Button();
            this.btn14 = new System.Windows.Forms.Button();
            this.btn15 = new System.Windows.Forms.Button();
            this.btn16 = new System.Windows.Forms.Button();
            this.btn17 = new System.Windows.Forms.Button();
            this.btn18 = new System.Windows.Forms.Button();
            this.btn20 = new System.Windows.Forms.Button();
            this.btn21 = new System.Windows.Forms.Button();
            this.btn22 = new System.Windows.Forms.Button();
            this.btn23 = new System.Windows.Forms.Button();
            this.btn24 = new System.Windows.Forms.Button();
            this.btn26 = new System.Windows.Forms.Button();
            this.btn27 = new System.Windows.Forms.Button();
            this.btn28 = new System.Windows.Forms.Button();
            this.btn29 = new System.Windows.Forms.Button();
            this.btn30 = new System.Windows.Forms.Button();
            this.btn32 = new System.Windows.Forms.Button();
            this.btn33 = new System.Windows.Forms.Button();
            this.btn34 = new System.Windows.Forms.Button();
            this.btn35 = new System.Windows.Forms.Button();
            this.btn36 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 19);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtInput.Size = new System.Drawing.Size(474, 62);
            this.txtInput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(505, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "النص الواضح";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(534, 515);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "النتيجة";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(15, 498);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtResult.Size = new System.Drawing.Size(474, 62);
            this.txtResult.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(508, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "مفتاح التشفير";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(12, 105);
            this.txtKey.Multiline = true;
            this.txtKey.Name = "txtKey";
            this.txtKey.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtKey.Size = new System.Drawing.Size(474, 62);
            this.txtKey.TabIndex = 4;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.Location = new System.Drawing.Point(398, 587);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(139, 53);
            this.btnEncrypt.TabIndex = 6;
            this.btnEncrypt.Text = "تشفير";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrypt.Location = new System.Drawing.Point(114, 587);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDecrypt.Size = new System.Drawing.Size(139, 53);
            this.btnDecrypt.TabIndex = 7;
            this.btnDecrypt.Text = "فك تشفير";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn14);
            this.panel1.Controls.Add(this.btn15);
            this.panel1.Controls.Add(this.btn16);
            this.panel1.Controls.Add(this.btn17);
            this.panel1.Controls.Add(this.btn18);
            this.panel1.Controls.Add(this.btn8);
            this.panel1.Controls.Add(this.btn9);
            this.panel1.Controls.Add(this.btn10);
            this.panel1.Controls.Add(this.btn11);
            this.panel1.Controls.Add(this.btn12);
            this.panel1.Controls.Add(this.btn2);
            this.panel1.Controls.Add(this.btn3);
            this.panel1.Controls.Add(this.btn4);
            this.panel1.Controls.Add(this.btn5);
            this.panel1.Controls.Add(this.btn6);
            this.panel1.Controls.Add(this.btn31);
            this.panel1.Controls.Add(this.btn25);
            this.panel1.Controls.Add(this.btn19);
            this.panel1.Controls.Add(this.btn13);
            this.panel1.Controls.Add(this.btn7);
            this.panel1.Controls.Add(this.btn1);
            this.panel1.Location = new System.Drawing.Point(117, 195);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 283);
            this.panel1.TabIndex = 8;
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(316, 13);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(55, 38);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "ا";
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(314, 57);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(55, 38);
            this.btn7.TabIndex = 1;
            this.btn7.Text = "خ";
            this.btn7.UseVisualStyleBackColor = true;
            // 
            // btn13
            // 
            this.btn13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn13.Location = new System.Drawing.Point(314, 101);
            this.btn13.Name = "btn13";
            this.btn13.Size = new System.Drawing.Size(55, 38);
            this.btn13.TabIndex = 2;
            this.btn13.Text = "ش";
            this.btn13.UseVisualStyleBackColor = true;
            // 
            // btn19
            // 
            this.btn19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn19.Location = new System.Drawing.Point(316, 145);
            this.btn19.Name = "btn19";
            this.btn19.Size = new System.Drawing.Size(55, 38);
            this.btn19.TabIndex = 3;
            this.btn19.Text = "غ";
            this.btn19.UseVisualStyleBackColor = true;
            // 
            // btn25
            // 
            this.btn25.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn25.Location = new System.Drawing.Point(316, 189);
            this.btn25.Name = "btn25";
            this.btn25.Size = new System.Drawing.Size(55, 38);
            this.btn25.TabIndex = 4;
            this.btn25.Text = "ن";
            this.btn25.UseVisualStyleBackColor = true;
            // 
            // btn31
            // 
            this.btn31.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn31.Location = new System.Drawing.Point(316, 233);
            this.btn31.Name = "btn31";
            this.btn31.Size = new System.Drawing.Size(55, 38);
            this.btn31.TabIndex = 5;
            this.btn31.Text = "ئ";
            this.btn31.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(11, 13);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(55, 38);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "ح";
            this.btn6.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(72, 13);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(55, 38);
            this.btn5.TabIndex = 7;
            this.btn5.Text = "ج";
            this.btn5.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(133, 13);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(55, 38);
            this.btn4.TabIndex = 8;
            this.btn4.Text = "ث";
            this.btn4.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(194, 13);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(55, 38);
            this.btn3.TabIndex = 9;
            this.btn3.Text = "ت";
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(255, 13);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(55, 38);
            this.btn2.TabIndex = 10;
            this.btn2.Text = "ب";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(253, 57);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(55, 38);
            this.btn8.TabIndex = 15;
            this.btn8.Text = "د";
            this.btn8.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(192, 57);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(55, 38);
            this.btn9.TabIndex = 14;
            this.btn9.Text = "ذ";
            this.btn9.UseVisualStyleBackColor = true;
            // 
            // btn10
            // 
            this.btn10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn10.Location = new System.Drawing.Point(131, 57);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(55, 38);
            this.btn10.TabIndex = 13;
            this.btn10.Text = "ر";
            this.btn10.UseVisualStyleBackColor = true;
            // 
            // btn11
            // 
            this.btn11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn11.Location = new System.Drawing.Point(70, 57);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(55, 38);
            this.btn11.TabIndex = 12;
            this.btn11.Text = "ز";
            this.btn11.UseVisualStyleBackColor = true;
            // 
            // btn12
            // 
            this.btn12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn12.Location = new System.Drawing.Point(9, 57);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(55, 38);
            this.btn12.TabIndex = 11;
            this.btn12.Text = "س";
            this.btn12.UseVisualStyleBackColor = true;
            // 
            // btn14
            // 
            this.btn14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn14.Location = new System.Drawing.Point(253, 101);
            this.btn14.Name = "btn14";
            this.btn14.Size = new System.Drawing.Size(55, 38);
            this.btn14.TabIndex = 20;
            this.btn14.Text = "ص";
            this.btn14.UseVisualStyleBackColor = true;
            // 
            // btn15
            // 
            this.btn15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn15.Location = new System.Drawing.Point(192, 101);
            this.btn15.Name = "btn15";
            this.btn15.Size = new System.Drawing.Size(55, 38);
            this.btn15.TabIndex = 19;
            this.btn15.Text = "ض";
            this.btn15.UseVisualStyleBackColor = true;
            // 
            // btn16
            // 
            this.btn16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn16.Location = new System.Drawing.Point(131, 101);
            this.btn16.Name = "btn16";
            this.btn16.Size = new System.Drawing.Size(55, 38);
            this.btn16.TabIndex = 18;
            this.btn16.Text = "ط";
            this.btn16.UseVisualStyleBackColor = true;
            // 
            // btn17
            // 
            this.btn17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn17.Location = new System.Drawing.Point(70, 101);
            this.btn17.Name = "btn17";
            this.btn17.Size = new System.Drawing.Size(55, 38);
            this.btn17.TabIndex = 17;
            this.btn17.Text = "ظ";
            this.btn17.UseVisualStyleBackColor = true;
            // 
            // btn18
            // 
            this.btn18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn18.Location = new System.Drawing.Point(9, 101);
            this.btn18.Name = "btn18";
            this.btn18.Size = new System.Drawing.Size(55, 38);
            this.btn18.TabIndex = 16;
            this.btn18.Text = "ع";
            this.btn18.UseVisualStyleBackColor = true;
            // 
            // btn20
            // 
            this.btn20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn20.Location = new System.Drawing.Point(371, 341);
            this.btn20.Name = "btn20";
            this.btn20.Size = new System.Drawing.Size(55, 38);
            this.btn20.TabIndex = 15;
            this.btn20.Text = "ف";
            this.btn20.UseVisualStyleBackColor = true;
            // 
            // btn21
            // 
            this.btn21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn21.Location = new System.Drawing.Point(310, 341);
            this.btn21.Name = "btn21";
            this.btn21.Size = new System.Drawing.Size(55, 38);
            this.btn21.TabIndex = 14;
            this.btn21.Text = "ق";
            this.btn21.UseVisualStyleBackColor = true;
            // 
            // btn22
            // 
            this.btn22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn22.Location = new System.Drawing.Point(249, 341);
            this.btn22.Name = "btn22";
            this.btn22.Size = new System.Drawing.Size(55, 38);
            this.btn22.TabIndex = 13;
            this.btn22.Text = "ك";
            this.btn22.UseVisualStyleBackColor = true;
            // 
            // btn23
            // 
            this.btn23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn23.Location = new System.Drawing.Point(188, 341);
            this.btn23.Name = "btn23";
            this.btn23.Size = new System.Drawing.Size(55, 38);
            this.btn23.TabIndex = 12;
            this.btn23.Text = "ل";
            this.btn23.UseVisualStyleBackColor = true;
            // 
            // btn24
            // 
            this.btn24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn24.Location = new System.Drawing.Point(127, 341);
            this.btn24.Name = "btn24";
            this.btn24.Size = new System.Drawing.Size(55, 38);
            this.btn24.TabIndex = 11;
            this.btn24.Text = "م";
            this.btn24.UseVisualStyleBackColor = true;
            // 
            // btn26
            // 
            this.btn26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn26.Location = new System.Drawing.Point(372, 387);
            this.btn26.Name = "btn26";
            this.btn26.Size = new System.Drawing.Size(55, 38);
            this.btn26.TabIndex = 20;
            this.btn26.Text = "ه";
            this.btn26.UseVisualStyleBackColor = true;
            // 
            // btn27
            // 
            this.btn27.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn27.Location = new System.Drawing.Point(311, 387);
            this.btn27.Name = "btn27";
            this.btn27.Size = new System.Drawing.Size(55, 38);
            this.btn27.TabIndex = 19;
            this.btn27.Text = "و";
            this.btn27.UseVisualStyleBackColor = true;
            // 
            // btn28
            // 
            this.btn28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn28.Location = new System.Drawing.Point(250, 387);
            this.btn28.Name = "btn28";
            this.btn28.Size = new System.Drawing.Size(55, 38);
            this.btn28.TabIndex = 18;
            this.btn28.Text = "ي";
            this.btn28.UseVisualStyleBackColor = true;
            // 
            // btn29
            // 
            this.btn29.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn29.Location = new System.Drawing.Point(189, 387);
            this.btn29.Name = "btn29";
            this.btn29.Size = new System.Drawing.Size(55, 38);
            this.btn29.TabIndex = 17;
            this.btn29.Text = "ؤ";
            this.btn29.UseVisualStyleBackColor = true;
            // 
            // btn30
            // 
            this.btn30.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn30.Location = new System.Drawing.Point(128, 387);
            this.btn30.Name = "btn30";
            this.btn30.Size = new System.Drawing.Size(55, 38);
            this.btn30.TabIndex = 16;
            this.btn30.Text = "ء";
            this.btn30.UseVisualStyleBackColor = true;
            // 
            // btn32
            // 
            this.btn32.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn32.Location = new System.Drawing.Point(374, 429);
            this.btn32.Name = "btn32";
            this.btn32.Size = new System.Drawing.Size(55, 38);
            this.btn32.TabIndex = 25;
            this.btn32.Text = "ى";
            this.btn32.UseVisualStyleBackColor = true;
            // 
            // btn33
            // 
            this.btn33.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn33.Location = new System.Drawing.Point(313, 429);
            this.btn33.Name = "btn33";
            this.btn33.Size = new System.Drawing.Size(55, 38);
            this.btn33.TabIndex = 24;
            this.btn33.Text = "ة";
            this.btn33.UseVisualStyleBackColor = true;
            // 
            // btn34
            // 
            this.btn34.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn34.Location = new System.Drawing.Point(252, 429);
            this.btn34.Name = "btn34";
            this.btn34.Size = new System.Drawing.Size(55, 38);
            this.btn34.TabIndex = 23;
            this.btn34.Text = "+";
            this.btn34.UseVisualStyleBackColor = true;
            // 
            // btn35
            // 
            this.btn35.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn35.Location = new System.Drawing.Point(191, 429);
            this.btn35.Name = "btn35";
            this.btn35.Size = new System.Drawing.Size(55, 38);
            this.btn35.TabIndex = 22;
            this.btn35.Text = "-";
            this.btn35.UseVisualStyleBackColor = true;
            // 
            // btn36
            // 
            this.btn36.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn36.Location = new System.Drawing.Point(130, 429);
            this.btn36.Name = "btn36";
            this.btn36.Size = new System.Drawing.Size(55, 38);
            this.btn36.TabIndex = 21;
            this.btn36.Text = "*";
            this.btn36.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 664);
            this.Controls.Add(this.btn32);
            this.Controls.Add(this.btn33);
            this.Controls.Add(this.btn34);
            this.Controls.Add(this.btn35);
            this.Controls.Add(this.btn36);
            this.Controls.Add(this.btn26);
            this.Controls.Add(this.btn27);
            this.Controls.Add(this.btn28);
            this.Controls.Add(this.btn29);
            this.Controls.Add(this.btn30);
            this.Controls.Add(this.btn20);
            this.Controls.Add(this.btn21);
            this.Controls.Add(this.btn22);
            this.Controls.Add(this.btn23);
            this.Controls.Add(this.btn24);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn14;
        private System.Windows.Forms.Button btn15;
        private System.Windows.Forms.Button btn16;
        private System.Windows.Forms.Button btn17;
        private System.Windows.Forms.Button btn18;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btn11;
        private System.Windows.Forms.Button btn12;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn31;
        private System.Windows.Forms.Button btn25;
        private System.Windows.Forms.Button btn19;
        private System.Windows.Forms.Button btn13;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn20;
        private System.Windows.Forms.Button btn21;
        private System.Windows.Forms.Button btn22;
        private System.Windows.Forms.Button btn23;
        private System.Windows.Forms.Button btn24;
        private System.Windows.Forms.Button btn26;
        private System.Windows.Forms.Button btn27;
        private System.Windows.Forms.Button btn28;
        private System.Windows.Forms.Button btn29;
        private System.Windows.Forms.Button btn30;
        private System.Windows.Forms.Button btn32;
        private System.Windows.Forms.Button btn33;
        private System.Windows.Forms.Button btn34;
        private System.Windows.Forms.Button btn35;
        private System.Windows.Forms.Button btn36;
    }
}

