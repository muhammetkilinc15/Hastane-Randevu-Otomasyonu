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
    public partial class HastaBilgiDüzenle : Form
    {
        public HastaBilgiDüzenle()
        {
            InitializeComponent();
        }

        SqlBaglanti baglanti = new SqlBaglanti();
        private void frmHastaBilgiDüzenle_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
        public string tc;
        private void frmHastaBilgiDüzenle_Load(object sender, EventArgs e)
        {
            maskedTextBoxTc.Text = tc;
            // Ad soyad Çekme 
            SqlCommand sqlCommand = new SqlCommand("Select * From hasta where hastaTc=@p1", baglanti.baglanti());
            sqlCommand.Parameters.AddWithValue("@p1",maskedTextBoxTc.Text);
            
            SqlDataReader dr= sqlCommand.ExecuteReader();
            while (dr.Read())
            {
                textBoxName.Text = dr[1].ToString();
                textBoxSurname.Text = dr[2].ToString();
                maskedTextBoxPhone.Text = dr[4].ToString();
                textBoxPasword.Text = dr[5].ToString();
                comboBoxGender.Text = dr[6].ToString();
            }
            baglanti.baglanti().Close();


        }

        private void bilgiDüzenle_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text==""|| textBoxSurname.Text==""||textBoxPasword.Text==""|| maskedTextBoxPhone.Text==""||maskedTextBoxTc.Text==""||maskedTextBoxTc.Text.Length!=11||comboBoxGender.Text=="")
            {
                MessageBox.Show("Lütfen bilgileri doğru bir şekilde düzenleyiniz","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                SqlCommand sqlCommand = new SqlCommand("update hasta set hastaAd=@p1,hastaSoyad=@p2,hastaTel=@p3,hastaSifre=@p4,hastaCinsiyet=@p5 where hastaTc=@p6", baglanti.baglanti());
                sqlCommand.Parameters.AddWithValue("@p1", textBoxName.Text);
                sqlCommand.Parameters.AddWithValue("@p2", textBoxSurname.Text);
                sqlCommand.Parameters.AddWithValue("@p3", maskedTextBoxPhone.Text);
                sqlCommand.Parameters.AddWithValue("@p4", textBoxPasword.Text);
                sqlCommand.Parameters.AddWithValue("@p5", comboBoxGender.Text);
                sqlCommand.Parameters.AddWithValue("@p6", maskedTextBoxTc.Text);

                // insert , update delete de yaptığımız işlemleri gerçekleştiren işlemdir
                sqlCommand.ExecuteNonQuery();
                baglanti.baglanti().Close();
                MessageBox.Show("Bilgileriniz güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
           

            


        }
    }
}
