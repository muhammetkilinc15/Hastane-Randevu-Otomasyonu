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
    public partial class HastaLogin : Form
    {
        public HastaLogin()
        {
            InitializeComponent();
        }

        private void linkLabelSingIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PatientRegistereted frmPatientRegistereted = new PatientRegistereted();
            frmPatientRegistereted.Show();
        }

        SqlBaglanti baglanti = new SqlBaglanti();
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxTc.Text=="" || textBoxPasword.Text=="")
            {
                MessageBox.Show("Lütfen bilgilerinizi eksiksiz giriniz","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                SqlCommand cmd = new SqlCommand("Select * From hasta where hastaTc=@p1 and hastaSifre=@p2", baglanti.baglanti());


                cmd.Parameters.AddWithValue("@p1", maskedTextBoxTc.Text);
                cmd.Parameters.AddWithValue("@p2", textBoxPasword.Text);

                SqlDataReader dr= cmd.ExecuteReader();
                if (dr.Read())
                {
                    FrmHastaDetay frm= new FrmHastaDetay();
                    frm.TC= maskedTextBoxTc.Text;
                    frm.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Hatalı  Tc veya Şifre");
                }

                baglanti.baglanti().Close();               

            }

          

        }
    }
}
