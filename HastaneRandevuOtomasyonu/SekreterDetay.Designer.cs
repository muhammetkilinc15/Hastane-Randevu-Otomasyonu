namespace HastaneRandevuOtomasyonu
{
    partial class SekreterDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SekreterDetay));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelTc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelNameSurname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonDuyuruOlustur = new System.Windows.Forms.Button();
            this.richTextBoxDuyuru = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.checkBoxDurum = new System.Windows.Forms.CheckBox();
            this.maskedTextBoxTc = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxDoktor = new System.Windows.Forms.ComboBox();
            this.comboBoxBrans = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxSaat = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxTarih = new System.Windows.Forms.MaskedTextBox();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridViewBrans = new System.Windows.Forms.DataGridView();
            this.bransId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bransAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridViewDoktor = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.buttonDuyurular = new System.Windows.Forms.Button();
            this.buttonRandevuListe = new System.Windows.Forms.Button();
            this.buttonBransPanel = new System.Windows.Forms.Button();
            this.buttonDoktorPanel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBrans)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoktor)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelTc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.labelNameSurname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 193);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sekreter Bilgi";
            // 
            // labelTc
            // 
            this.labelTc.AutoSize = true;
            this.labelTc.Location = new System.Drawing.Point(136, 63);
            this.labelTc.Name = "labelTc";
            this.labelTc.Size = new System.Drawing.Size(144, 28);
            this.labelTc.TabIndex = 27;
            this.labelTc.Text = "00000000000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 28);
            this.label2.TabIndex = 26;
            this.label2.Text = "TC No:";
            // 
            // labelNameSurname
            // 
            this.labelNameSurname.AutoSize = true;
            this.labelNameSurname.Location = new System.Drawing.Point(136, 112);
            this.labelNameSurname.Name = "labelNameSurname";
            this.labelNameSurname.Size = new System.Drawing.Size(93, 28);
            this.labelNameSurname.TabIndex = 25;
            this.labelNameSurname.Text = "Null Null";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 28);
            this.label1.TabIndex = 24;
            this.label1.Text = "Ad Soyad:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonDuyuruOlustur);
            this.groupBox2.Controls.Add(this.richTextBoxDuyuru);
            this.groupBox2.Location = new System.Drawing.Point(12, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(349, 302);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Duyuru Oluştur";
            // 
            // buttonDuyuruOlustur
            // 
            this.buttonDuyuruOlustur.Location = new System.Drawing.Point(18, 240);
            this.buttonDuyuruOlustur.Name = "buttonDuyuruOlustur";
            this.buttonDuyuruOlustur.Size = new System.Drawing.Size(309, 40);
            this.buttonDuyuruOlustur.TabIndex = 1;
            this.buttonDuyuruOlustur.Text = "Oluştur";
            this.buttonDuyuruOlustur.UseVisualStyleBackColor = true;
            this.buttonDuyuruOlustur.Click += new System.EventHandler(this.buttonDuyuruOlustur_Click);
            // 
            // richTextBoxDuyuru
            // 
            this.richTextBoxDuyuru.Location = new System.Drawing.Point(18, 35);
            this.richTextBoxDuyuru.Name = "richTextBoxDuyuru";
            this.richTextBoxDuyuru.Size = new System.Drawing.Size(309, 199);
            this.richTextBoxDuyuru.TabIndex = 0;
            this.richTextBoxDuyuru.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonKaydet);
            this.groupBox3.Controls.Add(this.checkBoxDurum);
            this.groupBox3.Controls.Add(this.maskedTextBoxTc);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.comboBoxDoktor);
            this.groupBox3.Controls.Add(this.comboBoxBrans);
            this.groupBox3.Controls.Add(this.maskedTextBoxSaat);
            this.groupBox3.Controls.Add(this.maskedTextBoxTarih);
            this.groupBox3.Controls.Add(this.textBoxId);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(385, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(310, 506);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Paneli";
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonKaydet.Location = new System.Drawing.Point(108, 370);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(164, 41);
            this.buttonKaydet.TabIndex = 14;
            this.buttonKaydet.Text = "Kaydet";
            this.buttonKaydet.UseVisualStyleBackColor = true;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // checkBoxDurum
            // 
            this.checkBoxDurum.AutoSize = true;
            this.checkBoxDurum.Location = new System.Drawing.Point(108, 332);
            this.checkBoxDurum.Name = "checkBoxDurum";
            this.checkBoxDurum.Size = new System.Drawing.Size(100, 32);
            this.checkBoxDurum.TabIndex = 13;
            this.checkBoxDurum.Text = "Durum";
            this.checkBoxDurum.UseVisualStyleBackColor = true;
            // 
            // maskedTextBoxTc
            // 
            this.maskedTextBoxTc.Location = new System.Drawing.Point(108, 280);
            this.maskedTextBoxTc.Mask = "00000000000";
            this.maskedTextBoxTc.Name = "maskedTextBoxTc";
            this.maskedTextBoxTc.Size = new System.Drawing.Size(164, 36);
            this.maskedTextBoxTc.TabIndex = 12;
            this.maskedTextBoxTc.ValidatingType = typeof(System.DateTime);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 288);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 28);
            this.label9.TabIndex = 11;
            this.label9.Text = "TC:";
            // 
            // comboBoxDoktor
            // 
            this.comboBoxDoktor.FormattingEnabled = true;
            this.comboBoxDoktor.Location = new System.Drawing.Point(108, 238);
            this.comboBoxDoktor.Name = "comboBoxDoktor";
            this.comboBoxDoktor.Size = new System.Drawing.Size(164, 36);
            this.comboBoxDoktor.TabIndex = 10;
            // 
            // comboBoxBrans
            // 
            this.comboBoxBrans.FormattingEnabled = true;
            this.comboBoxBrans.Location = new System.Drawing.Point(108, 196);
            this.comboBoxBrans.Name = "comboBoxBrans";
            this.comboBoxBrans.Size = new System.Drawing.Size(164, 36);
            this.comboBoxBrans.TabIndex = 9;
            this.comboBoxBrans.SelectedIndexChanged += new System.EventHandler(this.comboBoxBrans_SelectedIndexChanged);
            // 
            // maskedTextBoxSaat
            // 
            this.maskedTextBoxSaat.Location = new System.Drawing.Point(108, 154);
            this.maskedTextBoxSaat.Mask = "00:00";
            this.maskedTextBoxSaat.Name = "maskedTextBoxSaat";
            this.maskedTextBoxSaat.Size = new System.Drawing.Size(164, 36);
            this.maskedTextBoxSaat.TabIndex = 8;
            this.maskedTextBoxSaat.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBoxTarih
            // 
            this.maskedTextBoxTarih.Location = new System.Drawing.Point(108, 112);
            this.maskedTextBoxTarih.Mask = "00/00/0000";
            this.maskedTextBoxTarih.Name = "maskedTextBoxTarih";
            this.maskedTextBoxTarih.Size = new System.Drawing.Size(164, 36);
            this.maskedTextBoxTarih.TabIndex = 7;
            this.maskedTextBoxTarih.ValidatingType = typeof(System.DateTime);
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(108, 70);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(164, 36);
            this.textBoxId.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 28);
            this.label7.TabIndex = 4;
            this.label7.Text = "Doktor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 28);
            this.label6.TabIndex = 3;
            this.label6.Text = "Branş:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 28);
            this.label5.TabIndex = 2;
            this.label5.Text = "Saat:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tarih:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridViewBrans);
            this.groupBox4.Location = new System.Drawing.Point(704, 23);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(541, 309);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Branşlar";
            // 
            // dataGridViewBrans
            // 
            this.dataGridViewBrans.AllowUserToAddRows = false;
            this.dataGridViewBrans.AllowUserToDeleteRows = false;
            this.dataGridViewBrans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBrans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bransId,
            this.bransAd});
            this.dataGridViewBrans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewBrans.Location = new System.Drawing.Point(3, 32);
            this.dataGridViewBrans.Name = "dataGridViewBrans";
            this.dataGridViewBrans.ReadOnly = true;
            this.dataGridViewBrans.RowHeadersWidth = 51;
            this.dataGridViewBrans.RowTemplate.Height = 24;
            this.dataGridViewBrans.Size = new System.Drawing.Size(535, 274);
            this.dataGridViewBrans.TabIndex = 0;
            // 
            // bransId
            // 
            this.bransId.DataPropertyName = "bransId";
            this.bransId.FillWeight = 85.5615F;
            this.bransId.HeaderText = "ID";
            this.bransId.MinimumWidth = 6;
            this.bransId.Name = "bransId";
            this.bransId.ReadOnly = true;
            // 
            // bransAd
            // 
            this.bransAd.DataPropertyName = "bransAd";
            this.bransAd.FillWeight = 114.4385F;
            this.bransAd.HeaderText = "Branş Adı";
            this.bransAd.MinimumWidth = 6;
            this.bransAd.Name = "bransAd";
            this.bransAd.ReadOnly = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridViewDoktor);
            this.groupBox5.Location = new System.Drawing.Point(701, 338);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(544, 332);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Doktorlar";
            // 
            // dataGridViewDoktor
            // 
            this.dataGridViewDoktor.AllowUserToAddRows = false;
            this.dataGridViewDoktor.AllowUserToDeleteRows = false;
            this.dataGridViewDoktor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDoktor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoktor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDoktor.Location = new System.Drawing.Point(3, 32);
            this.dataGridViewDoktor.Name = "dataGridViewDoktor";
            this.dataGridViewDoktor.ReadOnly = true;
            this.dataGridViewDoktor.RowHeadersWidth = 51;
            this.dataGridViewDoktor.RowTemplate.Height = 24;
            this.dataGridViewDoktor.Size = new System.Drawing.Size(538, 297);
            this.dataGridViewDoktor.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.buttonDuyurular);
            this.groupBox6.Controls.Add(this.buttonRandevuListe);
            this.groupBox6.Controls.Add(this.buttonBransPanel);
            this.groupBox6.Controls.Add(this.buttonDoktorPanel);
            this.groupBox6.Location = new System.Drawing.Point(12, 539);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(683, 131);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Hızlı Erişim";
            // 
            // buttonDuyurular
            // 
            this.buttonDuyurular.Location = new System.Drawing.Point(521, 48);
            this.buttonDuyurular.Name = "buttonDuyurular";
            this.buttonDuyurular.Size = new System.Drawing.Size(152, 48);
            this.buttonDuyurular.TabIndex = 3;
            this.buttonDuyurular.Text = "Duyurular";
            this.buttonDuyurular.UseVisualStyleBackColor = true;
            this.buttonDuyurular.Click += new System.EventHandler(this.buttonDuyurular_Click);
            // 
            // buttonRandevuListe
            // 
            this.buttonRandevuListe.Location = new System.Drawing.Point(338, 48);
            this.buttonRandevuListe.Name = "buttonRandevuListe";
            this.buttonRandevuListe.Size = new System.Drawing.Size(177, 48);
            this.buttonRandevuListe.TabIndex = 2;
            this.buttonRandevuListe.Text = "Randevu Liste";
            this.buttonRandevuListe.UseVisualStyleBackColor = true;
            this.buttonRandevuListe.Click += new System.EventHandler(this.buttonRandevuListe_Click);
            // 
            // buttonBransPanel
            // 
            this.buttonBransPanel.Location = new System.Drawing.Point(180, 48);
            this.buttonBransPanel.Name = "buttonBransPanel";
            this.buttonBransPanel.Size = new System.Drawing.Size(152, 48);
            this.buttonBransPanel.TabIndex = 1;
            this.buttonBransPanel.Text = "Branş Paneli";
            this.buttonBransPanel.UseVisualStyleBackColor = true;
            this.buttonBransPanel.Click += new System.EventHandler(this.buttonBransPanel_Click);
            // 
            // buttonDoktorPanel
            // 
            this.buttonDoktorPanel.Location = new System.Drawing.Point(6, 48);
            this.buttonDoktorPanel.Name = "buttonDoktorPanel";
            this.buttonDoktorPanel.Size = new System.Drawing.Size(168, 48);
            this.buttonDoktorPanel.TabIndex = 0;
            this.buttonDoktorPanel.Text = "Doktor Paneli";
            this.buttonDoktorPanel.UseVisualStyleBackColor = true;
            this.buttonDoktorPanel.Click += new System.EventHandler(this.buttonDoktorPanel_Click);
            // 
            // SekreterDetay
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1257, 689);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "SekreterDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sekreter Ana Ekranı";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SekreterDetay_FormClosing);
            this.Load += new System.EventHandler(this.SekreterDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBrans)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoktor)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelTc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelNameSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonDuyuruOlustur;
        private System.Windows.Forms.RichTextBox richTextBoxDuyuru;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTarih;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxDoktor;
        private System.Windows.Forms.ComboBox comboBoxBrans;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSaat;
        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.CheckBox checkBoxDurum;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridViewBrans;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridViewDoktor;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button buttonRandevuListe;
        private System.Windows.Forms.Button buttonBransPanel;
        private System.Windows.Forms.Button buttonDoktorPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn bransId;
        private System.Windows.Forms.DataGridViewTextBoxColumn bransAd;
        private System.Windows.Forms.Button buttonDuyurular;
    }
}