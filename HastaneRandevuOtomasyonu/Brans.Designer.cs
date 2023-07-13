namespace HastaneRandevuOtomasyonu
{
    partial class Brans
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Brans));
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bransId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bransAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxBransName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBransId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonGuncelle.Location = new System.Drawing.Point(134, 223);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(210, 42);
            this.buttonGuncelle.TabIndex = 87;
            this.buttonGuncelle.Text = "Güncelle";
            this.buttonGuncelle.UseVisualStyleBackColor = false;
            this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonSil.Location = new System.Drawing.Point(249, 162);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(95, 42);
            this.buttonSil.TabIndex = 86;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = false;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bransId,
            this.bransAd});
            this.dataGridView1.Location = new System.Drawing.Point(382, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(546, 239);
            this.dataGridView1.TabIndex = 85;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // bransId
            // 
            this.bransId.DataPropertyName = "bransId";
            this.bransId.HeaderText = "ID";
            this.bransId.MinimumWidth = 6;
            this.bransId.Name = "bransId";
            this.bransId.ReadOnly = true;
            // 
            // bransAd
            // 
            this.bransAd.DataPropertyName = "bransAd";
            this.bransAd.HeaderText = "Branş Ad";
            this.bransAd.MinimumWidth = 6;
            this.bransAd.Name = "bransAd";
            this.bransAd.ReadOnly = true;
            // 
            // buttonEkle
            // 
            this.buttonEkle.BackColor = System.Drawing.Color.Salmon;
            this.buttonEkle.Location = new System.Drawing.Point(134, 162);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(94, 42);
            this.buttonEkle.TabIndex = 84;
            this.buttonEkle.Text = "Ekle";
            this.buttonEkle.UseVisualStyleBackColor = false;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 28);
            this.label4.TabIndex = 80;
            this.label4.Text = "Brans id:";
            // 
            // textBoxBransName
            // 
            this.textBoxBransName.Location = new System.Drawing.Point(134, 75);
            this.textBoxBransName.Name = "textBoxBransName";
            this.textBoxBransName.Size = new System.Drawing.Size(214, 36);
            this.textBoxBransName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 28);
            this.label1.TabIndex = 78;
            this.label1.Text = "Brans Ad:";
            // 
            // textBoxBransId
            // 
            this.textBoxBransId.Location = new System.Drawing.Point(134, 33);
            this.textBoxBransId.Name = "textBoxBransId";
            this.textBoxBransId.Size = new System.Drawing.Size(214, 36);
            this.textBoxBransId.TabIndex = 0;
            // 
            // Brans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(937, 286);
            this.Controls.Add(this.buttonGuncelle);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonEkle);
            this.Controls.Add(this.textBoxBransId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxBransName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Brans";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Branş";
            this.Load += new System.EventHandler(this.Brans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxBransName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBransId;
        private System.Windows.Forms.DataGridViewTextBoxColumn bransId;
        private System.Windows.Forms.DataGridViewTextBoxColumn bransAd;
    }
}