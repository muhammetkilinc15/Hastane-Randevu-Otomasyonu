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
    public partial class SekreterDetay : Form
    {
        public SekreterDetay()
        {
            InitializeComponent();
        }

        public string tc;
        SqlBaglanti baglanti= new SqlBaglanti();
        private void getDataGrieds()
        {
            // Bransları DataGried e aktarma

            DataTable dataTable = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter("Select * From brans", baglanti.baglanti());
            da.Fill(dataTable);
            dataGridViewBrans.DataSource = dataTable;



            // Doktor Datagried ekleme

            DataTable dataTable1 = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select  (doktorAd +' '+ doktorSoyad ) as 'Doktor Ad Soyad',doktorBrans as 'Branş' From doktor", baglanti.baglanti());
            sqlDataAdapter.Fill(dataTable1);
            dataGridViewDoktor.DataSource = dataTable1;


        }
        private void SekreterDetay_Load(object sender, EventArgs e)
        {
            labelTc.Text = tc;

            // Ad soyad 
            SqlCommand cmd = new SqlCommand("Select sekterAdSoyad From sekreter where sekreterTc=@p1", baglanti.baglanti());
            cmd.Parameters.AddWithValue("@p1",labelTc.Text);


            SqlDataReader dr = cmd.ExecuteReader();
           while(dr.Read()) { 
                labelNameSurname.Text = dr[0].ToString();
            }

            baglanti.baglanti().Close();

            getDataGrieds();
                    

            // Comboxa brans adlarını ekleme

            SqlCommand cmd2 = new SqlCommand("Select bransAd From brans",baglanti.baglanti());
            SqlDataReader dr2 = cmd2.ExecuteReader();

            while (dr2.Read())
            {
                comboBoxBrans.Items.Add(dr2[0]);
            }
        }

        private void SekreterDetay_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); 
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into randevular (randevuTarih,randevuSaat,randevuBrans,randevuDoktor) values (@p1,@p2,@p3,@p4)",baglanti.baglanti());

            cmd.Parameters.AddWithValue("@p1", maskedTextBoxTarih.Text);
            cmd.Parameters.AddWithValue("@p2", maskedTextBoxSaat.Text);
            cmd.Parameters.AddWithValue("@p3", comboBoxBrans.Text);
            cmd.Parameters.AddWithValue("@p4", comboBoxDoktor.Text);
            
            cmd.ExecuteNonQuery();

            baglanti.baglanti().Close();

            MessageBox.Show("Randevu oluşturuldu","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            getDataGrieds() ;
        }

        private void comboBoxBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxDoktor.Items.Clear();
          
            SqlCommand sql = new SqlCommand("Select doktorAd,doktorSoyad From doktor where doktorBrans=@p1",baglanti.baglanti());
            sql.Parameters.AddWithValue("@p1",comboBoxBrans.Text);
            SqlDataReader reader = sql.ExecuteReader();

            while (reader.Read())
            {                
                comboBoxDoktor.Items.Add(reader[0] + " " + reader[1]);
            }
            
            baglanti.baglanti().Close();
        }

        private void buttonDuyuruOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand sql = new SqlCommand("insert into duyurular (duyuru) values (@p1)",baglanti.baglanti());
            sql.Parameters.AddWithValue("@p1", richTextBoxDuyuru.Text);
            sql.ExecuteNonQuery();
            baglanti.baglanti().Close();
            MessageBox.Show("Duyuru oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonDoktorPanel_Click(object sender, EventArgs e)
        {
            DoktorPaneli doktor= new DoktorPaneli();
            doktor.Show();
        }

        private void buttonBransPanel_Click(object sender, EventArgs e)
        {
            Brans brans= new Brans();
            brans.Show();

        }

        private void buttonRandevuListe_Click(object sender, EventArgs e)
        {
            RandevuListesi randevu = new RandevuListesi();
            randevu.Show();
        }

        private void buttonDuyurular_Click(object sender, EventArgs e)
        {
            Duyurular duyurular = new Duyurular();
            duyurular.Show();
        }
    }
}
