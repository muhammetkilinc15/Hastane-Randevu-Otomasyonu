using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace HastaneRandevuOtomasyonu
{
    public partial class SekreterLogin : Form
    {
        public SekreterLogin()
        {
            InitializeComponent();
        }

       

        private void frmSekreterLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        SqlBaglanti baglanti = new SqlBaglanti();
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxTc.Text=="" ||textBoxPasword.Text==""|| maskedTextBoxTc.Text.Length!=11)
            {
                MessageBox.Show("Tc kimlik alanı ya da şifre boş bırakılamaz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);            
            }
            else
            {
                SqlCommand cmd = new SqlCommand("Select * From sekreter where sekreterTc=@p1 and sekreterSifre=@p2", baglanti.baglanti());
                cmd.Parameters.AddWithValue("@p1", maskedTextBoxTc.Text);
                cmd.Parameters.AddWithValue("@p2", textBoxPasword.Text);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    SekreterDetay sekreter = new SekreterDetay();
                    sekreter.tc= maskedTextBoxTc.Text;
                    sekreter.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı Tc ya da Şifre", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }


        }
    }
}
