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
    public partial class PatientRegistereted : Form
    {
        public PatientRegistereted()
        {
            InitializeComponent();
        }

        SqlBaglanti sqlBaglanti= new SqlBaglanti();
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into hasta (HastaAd,HastaSoyad,hastaTc,hastaTel,hastaSifre,hastaCinsiyet) values (@p1,@p2,@p3,@p4,@p5,@p6)", sqlBaglanti.baglanti());

            if (textBoxName.Text==""||textBoxSurname.Text==""|| textBoxPasword.Text==""|| maskedTextBoxPhone.Text==""|| maskedTextBoxTc.Text==""|| comboBoxGender.Text=="")
            {
                MessageBox.Show("Lütfen tüm bilgileri eksiksiz giriniz","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                cmd.Parameters.AddWithValue("@p1", textBoxName.Text);
                cmd.Parameters.AddWithValue("@p2", textBoxSurname.Text);
                cmd.Parameters.AddWithValue("@p3", maskedTextBoxTc.Text);
                cmd.Parameters.AddWithValue("@p4", maskedTextBoxPhone.Text);
                cmd.Parameters.AddWithValue("@p5", textBoxPasword.Text);
                cmd.Parameters.AddWithValue("@p6", comboBoxGender.Text);

                cmd.ExecuteNonQuery();
                sqlBaglanti.baglanti().Close();
                MessageBox.Show("Kaydınız Gerçekleşmiştir Şifreniz: " + textBoxPasword.Text, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            
         
        }

       
    }
}
