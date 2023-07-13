namespace HastaneRandevuOtomasyonu
{
    partial class DoktorPaneli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoktorPaneli));
            this.comboBoxBrans = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPasword = new System.Windows.Forms.TextBox();
            this.maskedTextBoxTc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.doktorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doktorAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doktorSoyad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doktorBrans = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doktorTc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doktorSifre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxBrans
            // 
            this.comboBoxBrans.FormattingEnabled = true;
            this.comboBoxBrans.Location = new System.Drawing.Point(162, 218);
            this.comboBoxBrans.Name = "comboBoxBrans";
            this.comboBoxBrans.Size = new System.Drawing.Size(214, 36);
            this.comboBoxBrans.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 28);
            this.label5.TabIndex = 68;
            this.label5.Text = "Branş:";
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(161, 107);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(214, 36);
            this.textBoxSurname.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 28);
            this.label4.TabIndex = 66;
            this.label4.Text = "Soyad:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(161, 65);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(214, 36);
            this.textBoxName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 28);
            this.label1.TabIndex = 64;
            this.label1.Text = "Ad:";
            // 
            // textBoxPasword
            // 
            this.textBoxPasword.Location = new System.Drawing.Point(161, 267);
            this.textBoxPasword.Name = "textBoxPasword";
            this.textBoxPasword.Size = new System.Drawing.Size(214, 36);
            this.textBoxPasword.TabIndex = 5;
            this.textBoxPasword.UseSystemPasswordChar = true;
            // 
            // maskedTextBoxTc
            // 
            this.maskedTextBoxTc.Location = new System.Drawing.Point(161, 160);
            this.maskedTextBoxTc.Mask = "00000000000";
            this.maskedTextBoxTc.Name = "maskedTextBoxTc";
            this.maskedTextBoxTc.Size = new System.Drawing.Size(214, 36);
            this.maskedTextBoxTc.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 28);
            this.label3.TabIndex = 61;
            this.label3.Text = "Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 28);
            this.label2.TabIndex = 60;
            this.label2.Text = "TC Kimlik No:";
            // 
            // buttonEkle
            // 
            this.buttonEkle.BackColor = System.Drawing.Color.Salmon;
            this.buttonEkle.Location = new System.Drawing.Point(145, 335);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(94, 42);
            this.buttonEkle.TabIndex = 6;
            this.buttonEkle.Text = "Ekle";
            this.buttonEkle.UseVisualStyleBackColor = false;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.doktorId,
            this.doktorAd,
            this.doktorSoyad,
            this.doktorBrans,
            this.doktorTc,
            this.doktorSifre});
            this.dataGridView1.Location = new System.Drawing.Point(395, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(900, 370);
            this.dataGridView1.TabIndex = 71;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // doktorId
            // 
            this.doktorId.DataPropertyName = "doktorId";
            this.doktorId.HeaderText = "ID";
            this.doktorId.MinimumWidth = 6;
            this.doktorId.Name = "doktorId";
            this.doktorId.ReadOnly = true;
            // 
            // doktorAd
            // 
            this.doktorAd.DataPropertyName = "doktorAd";
            this.doktorAd.HeaderText = "Doktor Ad";
            this.doktorAd.MinimumWidth = 6;
            this.doktorAd.Name = "doktorAd";
            this.doktorAd.ReadOnly = true;
            // 
            // doktorSoyad
            // 
            this.doktorSoyad.DataPropertyName = "doktorSoyad";
            this.doktorSoyad.HeaderText = "Doktor Soyad";
            this.doktorSoyad.MinimumWidth = 6;
            this.doktorSoyad.Name = "doktorSoyad";
            this.doktorSoyad.ReadOnly = true;
            // 
            // doktorBrans
            // 
            this.doktorBrans.DataPropertyName = "doktorBrans";
            this.doktorBrans.HeaderText = "Doktor Branş";
            this.doktorBrans.MinimumWidth = 6;
            this.doktorBrans.Name = "doktorBrans";
            this.doktorBrans.ReadOnly = true;
            // 
            // doktorTc
            // 
            this.doktorTc.DataPropertyName = "doktorTc";
            this.doktorTc.HeaderText = "Doktor Tc";
            this.doktorTc.MinimumWidth = 6;
            this.doktorTc.Name = "doktorTc";
            this.doktorTc.ReadOnly = true;
            // 
            // doktorSifre
            // 
            this.doktorSifre.DataPropertyName = "doktorSifre";
            this.doktorSifre.HeaderText = "Doktor Şifre";
            this.doktorSifre.MinimumWidth = 6;
            this.doktorSifre.Name = "doktorSifre";
            this.doktorSifre.ReadOnly = true;
            // 
            // buttonSil
            // 
            this.buttonSil.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonSil.Location = new System.Drawing.Point(260, 335);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(95, 42);
            this.buttonSil.TabIndex = 7;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = false;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonGuncelle.Location = new System.Drawing.Point(145, 396);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(210, 42);
            this.buttonGuncelle.TabIndex = 8;
            this.buttonGuncelle.Text = "Güncelle";
            this.buttonGuncelle.UseVisualStyleBackColor = false;
            this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
            // 
            // DoktorPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1307, 499);
            this.Controls.Add(this.buttonGuncelle);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonEkle);
            this.Controls.Add(this.comboBoxBrans);
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
            this.Name = "DoktorPaneli";
            this.Text = "DoktorPaneli";
            this.Load += new System.EventHandler(this.DoktorPaneli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxBrans;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPasword;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktorAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktorSoyad;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktorBrans;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktorTc;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktorSifre;
    }
}