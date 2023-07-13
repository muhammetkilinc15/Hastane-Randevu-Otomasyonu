using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HastaneRandevuOtomasyonu
{
    public partial class DoktorLogin : Form
    {
        public DoktorLogin()
        {
            InitializeComponent();
        }

        private void DoktorLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        SqlBaglanti baglanti = new SqlBaglanti();
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if(maskedTextBoxTc.Text==""|| textBoxPasword.Text == "")
            {
                MessageBox.Show("Hatalı Kullanıcı adı veya şifre boş girilemez", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlCommand cmd = new SqlCommand("Select * From doktor where doktorTc=@p1 and doktorSifre=@p2", baglanti.baglanti());
                cmd.Parameters.AddWithValue("@p1", maskedTextBoxTc.Text);
                cmd.Parameters.AddWithValue("@p2", textBoxPasword.Text);

                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    DoktorDetay doktor = new DoktorDetay();
                    doktor.TC=maskedTextBoxTc.Text;
                    doktor.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı Kullanıcı adı veya şifre","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                }
                baglanti.baglanti().Close();

            }


        }
    }
}
