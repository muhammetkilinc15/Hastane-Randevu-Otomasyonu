namespace HastaneRandevuOtomasyonu
{
    partial class RandevuListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RandevuListesi));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randevuTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randevuSaat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randevuBrans = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randevuDoktor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randevuDurum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastaTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.randevuTarih,
            this.randevuSaat,
            this.randevuBrans,
            this.randevuDoktor,
            this.randevuDurum,
            this.hastaTC});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1083, 607);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "randevuID";
            this.ID.HeaderText = "randevuID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // randevuTarih
            // 
            this.randevuTarih.DataPropertyName = "randevuTarih";
            this.randevuTarih.HeaderText = "Randevu Tarih";
            this.randevuTarih.MinimumWidth = 6;
            this.randevuTarih.Name = "randevuTarih";
            this.randevuTarih.ReadOnly = true;
            // 
            // randevuSaat
            // 
            this.randevuSaat.DataPropertyName = "randevuSaat";
            this.randevuSaat.HeaderText = "Randevu Saat";
            this.randevuSaat.MinimumWidth = 6;
            this.randevuSaat.Name = "randevuSaat";
            this.randevuSaat.ReadOnly = true;
            // 
            // randevuBrans
            // 
            this.randevuBrans.DataPropertyName = "randevuBrans";
            this.randevuBrans.HeaderText = "Randevu Branş";
            this.randevuBrans.MinimumWidth = 6;
            this.randevuBrans.Name = "randevuBrans";
            this.randevuBrans.ReadOnly = true;
            // 
            // randevuDoktor
            // 
            this.randevuDoktor.DataPropertyName = "randevuDoktor";
            this.randevuDoktor.HeaderText = "Randevu Doktor";
            this.randevuDoktor.MinimumWidth = 6;
            this.randevuDoktor.Name = "randevuDoktor";
            this.randevuDoktor.ReadOnly = true;
            // 
            // randevuDurum
            // 
            this.randevuDurum.DataPropertyName = "randevuDurum";
            this.randevuDurum.HeaderText = "Randevu Durum";
            this.randevuDurum.MinimumWidth = 6;
            this.randevuDurum.Name = "randevuDurum";
            this.randevuDurum.ReadOnly = true;
            // 
            // hastaTC
            // 
            this.hastaTC.DataPropertyName = "hastaTC";
            this.hastaTC.HeaderText = "Hasta TC";
            this.hastaTC.MinimumWidth = 6;
            this.hastaTC.Name = "hastaTC";
            this.hastaTC.ReadOnly = true;
            // 
            // randevuListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1083, 607);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "randevuListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "randevuListesi";
            this.Load += new System.EventHandler(this.randevuListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn randevuTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn randevuSaat;
        private System.Windows.Forms.DataGridViewTextBoxColumn randevuBrans;
        private System.Windows.Forms.DataGridViewTextBoxColumn randevuDoktor;
        private System.Windows.Forms.DataGridViewTextBoxColumn randevuDurum;
        private System.Windows.Forms.DataGridViewTextBoxColumn hastaTC;
    }
}