﻿namespace Report_Pro
{
    partial class Form_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_1));
            this.cboCurrency = new System.Windows.Forms.ComboBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtEnglishWord = new System.Windows.Forms.TextBox();
            this.txtArabicWord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.uC_Acc1 = new Report_Pro.MyControls.UC_Acc();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboCurrency
            // 
            this.cboCurrency.DisplayMember = "EnglishCurrencyName";
            this.cboCurrency.FormattingEnabled = true;
            this.cboCurrency.Location = new System.Drawing.Point(691, 29);
            this.cboCurrency.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboCurrency.Name = "cboCurrency";
            this.cboCurrency.Size = new System.Drawing.Size(160, 31);
            this.cboCurrency.TabIndex = 3;
            this.cboCurrency.ValueMember = "CurrencyID";
            this.cboCurrency.DropDownClosed += new System.EventHandler(this.cboCurrency_DropDownClosed);
            // 
            // txtNumber
            // 
            this.txtNumber.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumber.ForeColor = System.Drawing.Color.Blue;
            this.txtNumber.Location = new System.Drawing.Point(212, 27);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(343, 32);
            this.txtNumber.TabIndex = 4;
            this.txtNumber.TextChanged += new System.EventHandler(this.txtNumber_TextChanged);
            // 
            // txtEnglishWord
            // 
            this.txtEnglishWord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEnglishWord.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnglishWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtEnglishWord.Location = new System.Drawing.Point(29, 31);
            this.txtEnglishWord.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEnglishWord.Multiline = true;
            this.txtEnglishWord.Name = "txtEnglishWord";
            this.txtEnglishWord.ReadOnly = true;
            this.txtEnglishWord.Size = new System.Drawing.Size(961, 111);
            this.txtEnglishWord.TabIndex = 5;
            // 
            // txtArabicWord
            // 
            this.txtArabicWord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtArabicWord.Font = new System.Drawing.Font("Sakkal Majalla", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArabicWord.ForeColor = System.Drawing.Color.Green;
            this.txtArabicWord.Location = new System.Drawing.Point(28, 37);
            this.txtArabicWord.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtArabicWord.Multiline = true;
            this.txtArabicWord.Name = "txtArabicWord";
            this.txtArabicWord.ReadOnly = true;
            this.txtArabicWord.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtArabicWord.Size = new System.Drawing.Size(961, 103);
            this.txtArabicWord.TabIndex = 6;
            this.txtArabicWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(25, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter Number: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.uC_Acc1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboCurrency);
            this.groupBox1.Controls.Add(this.txtNumber);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.MediumBlue;
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(1013, 121);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Your Number";
            // 
            // uC_Acc1
            // 
            this.uC_Acc1.BackColor = System.Drawing.Color.Transparent;
            this.uC_Acc1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.uC_Acc1.Location = new System.Drawing.Point(327, 68);
            this.uC_Acc1.Margin = new System.Windows.Forms.Padding(0);
            this.uC_Acc1.Name = "uC_Acc1";
            this.uC_Acc1.Padding = new System.Windows.Forms.Padding(1);
            this.uC_Acc1.Size = new System.Drawing.Size(414, 33);
            this.uC_Acc1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(880, 40);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 29);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtEnglishWord);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.MediumBlue;
            this.groupBox2.Location = new System.Drawing.Point(18, 112);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(1012, 166);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Your Numbers into English Words";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtArabicWord);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.MediumBlue;
            this.groupBox3.Location = new System.Drawing.Point(19, 291);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(1010, 161);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Your Numbers into Arabic Word ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(525, 551);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 12;
            // 
            // Form_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 627);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form_1";
            this.Text = "Number to Word in English and Arabic";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCurrency;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtEnglishWord;
        private System.Windows.Forms.TextBox txtArabicWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private MyControls.UC_Acc uC_Acc1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

