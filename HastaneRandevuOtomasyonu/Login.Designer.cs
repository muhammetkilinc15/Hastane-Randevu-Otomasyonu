namespace HastaneRandevuOtomasyonu
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.buttonHasta = new System.Windows.Forms.Button();
            this.buttonDoktor = new System.Windows.Forms.Button();
            this.buttonSekreter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonHasta
            // 
            this.buttonHasta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonHasta.BackgroundImage")));
            this.buttonHasta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonHasta.Location = new System.Drawing.Point(50, 196);
            this.buttonHasta.Name = "buttonHasta";
            this.buttonHasta.Size = new System.Drawing.Size(183, 177);
            this.buttonHasta.TabIndex = 0;
            this.buttonHasta.UseVisualStyleBackColor = true;
            this.buttonHasta.Click += new System.EventHandler(this.buttonHasta_Click);
            // 
            // buttonDoktor
            // 
            this.buttonDoktor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDoktor.BackgroundImage")));
            this.buttonDoktor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDoktor.Location = new System.Drawing.Point(291, 196);
            this.buttonDoktor.Name = "buttonDoktor";
            this.buttonDoktor.Size = new System.Drawing.Size(183, 177);
            this.buttonDoktor.TabIndex = 1;
            this.buttonDoktor.UseVisualStyleBackColor = true;
            this.buttonDoktor.Click += new System.EventHandler(this.buttonDoktor_Click);
            // 
            // buttonSekreter
            // 
            this.buttonSekreter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSekreter.BackgroundImage")));
            this.buttonSekreter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSekreter.Location = new System.Drawing.Point(526, 196);
            this.buttonSekreter.Name = "buttonSekreter";
            this.buttonSekreter.Size = new System.Drawing.Size(183, 177);
            this.buttonSekreter.TabIndex = 2;
            this.buttonSekreter.UseVisualStyleBackColor = true;
            this.buttonSekreter.Click += new System.EventHandler(this.buttonSekreter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(353, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Doktor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(99, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hasta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(576, 392);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sekreter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Tan;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(368, 46);
            this.label4.TabIndex = 6;
            this.label4.Text = "Bucak Devlet Hastanesi";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(427, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(307, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(780, 428);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSekreter);
            this.Controls.Add(this.buttonDoktor);
            this.Controls.Add(this.buttonHasta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bucak Devlet Hastanesi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonHasta;
        private System.Windows.Forms.Button buttonDoktor;
        private System.Windows.Forms.Button buttonSekreter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

