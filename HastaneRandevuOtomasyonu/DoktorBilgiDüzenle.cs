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

namespace HastaneRandevuOtomasyonu
{
    public partial class DoktorBilgiDüzenle : Form
    {
        public DoktorBilgiDüzenle()
        {
            InitializeComponent();
        }

        SqlBaglanti baglanti = new SqlBaglanti();
        public string TC;
        private void DoktorBilgiDüzenle_Load(object sender, EventArgs e)
        {
            maskedTextBoxTc.Text = TC;
            
            // 

            SqlCommand cmd = new SqlCommand("Select * From doktor where doktorTc=@p1",baglanti.baglanti());
            cmd.Parameters.AddWithValue("@p1",maskedTextBoxTc.Text);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                textBoxName.Text= reader[1].ToString();
                textBoxSurname.Text= reader[2].ToString();
                comboBox1.Text = reader[3].ToString();
                textBoxPasword.Text= reader[5].ToString();
            }
            baglanti.baglanti().Close();

            // Comboxa brans adlarını ekleme

            SqlCommand cmd2 = new SqlCommand("Select bransAd From brans", baglanti.baglanti());
            SqlDataReader dr2 = cmd2.ExecuteReader();

            while (dr2.Read())
            {
                comboBox1.Items.Add(dr2[0]);
            }
            baglanti.baglanti().Close();
        }

        private void bilgiDüzenle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update doktor set doktorAd=@p1,doktorSoyad=@p2,doktorBrans=@p3,doktorSifre=@p4 where doktorTc=@p5",baglanti.baglanti());
            cmd.Parameters.AddWithValue("@p1",textBoxName.Text);
            cmd.Parameters.AddWithValue("@p2",textBoxSurname.Text);
            cmd.Parameters.AddWithValue("@p3",comboBox1.Text);
            cmd.Parameters.AddWithValue("@p4",textBoxPasword.Text);
            cmd.Parameters.AddWithValue("@p5",maskedTextBoxTc.Text);
          

        }
    }
}
