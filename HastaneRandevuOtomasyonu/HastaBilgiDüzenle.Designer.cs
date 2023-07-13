namespace HastaneRandevuOtomasyonu
{
    partial class HastaBilgiDüzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HastaBilgiDüzenle));
            this.bilgiDüzenle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxPhone = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPasword = new System.Windows.Forms.TextBox();
            this.maskedTextBoxTc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bilgiDüzenle
            // 
            this.bilgiDüzenle.BackColor = System.Drawing.Color.Plum;
            this.bilgiDüzenle.Location = new System.Drawing.Point(204, 376);
            this.bilgiDüzenle.Name = "bilgiDüzenle";
            this.bilgiDüzenle.Size = new System.Drawing.Size(135, 46);
            this.bilgiDüzenle.TabIndex = 7;
            this.bilgiDüzenle.Text = "Güncelle";
            this.bilgiDüzenle.UseVisualStyleBackColor = false;
            this.bilgiDüzenle.Click += new System.EventHandler(this.bilgiDüzenle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 28);
            this.label6.TabIndex = 43;
            this.label6.Text = "Cinsiyet:";
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.comboBoxGender.Location = new System.Drawing.Point(165, 321);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(214, 36);
            this.comboBoxGender.TabIndex = 6;
            // 
            // maskedTextBoxPhone
            // 
            this.maskedTextBoxPhone.Location = new System.Drawing.Point(165, 212);
            this.maskedTextBoxPhone.Mask = "(999) 000-0000";
            this.maskedTextBoxPhone.Name = "maskedTextBoxPhone";
            this.maskedTextBoxPhone.Size = new System.Drawing.Size(214, 36);
            this.maskedTextBoxPhone.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 28);
            this.label5.TabIndex = 40;
            this.label5.Text = "Telefon:";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(165, 101);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(214, 36);
            this.textBoxSurname.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 28);
            this.label4.TabIndex = 38;
            this.label4.Text = "Soyad:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(165, 59);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(214, 36);
            this.textBoxName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 28);
            this.label1.TabIndex = 36;
            this.label1.Text = "Ad:";
            // 
            // textBoxPasword
            // 
            this.textBoxPasword.Location = new System.Drawing.Point(165, 261);
            this.textBoxPasword.Name = "textBoxPasword";
            this.textBoxPasword.Size = new System.Drawing.Size(214, 36);
            this.textBoxPasword.TabIndex = 5;
            // 
            // maskedTextBoxTc
            // 
            this.maskedTextBoxTc.Location = new System.Drawing.Point(165, 154);
            this.maskedTextBoxTc.Mask = "00000000000";
            this.maskedTextBoxTc.Name = "maskedTextBoxTc";
            this.maskedTextBoxTc.Size = new System.Drawing.Size(214, 36);
            this.maskedTextBoxTc.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 28);
            this.label3.TabIndex = 33;
            this.label3.Text = "Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 28);
            this.label2.TabIndex = 32;
            this.label2.Text = "TC Kimlik No:";
            // 
            // frmHastaBilgiDüzenle
            // 
            this.AcceptButton = this.bilgiDüzenle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(638, 491);
            this.Controls.Add(this.bilgiDüzenle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.maskedTextBoxPhone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPasword);
            this.Controls.Add(this.maskedTextBoxTc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmHastaBilgiDüzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBilgiDüzenle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHastaBilgiDüzenle_FormClosing);
            this.Load += new System.EventHandler(this.frmHastaBilgiDüzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bilgiDüzenle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPasword;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}