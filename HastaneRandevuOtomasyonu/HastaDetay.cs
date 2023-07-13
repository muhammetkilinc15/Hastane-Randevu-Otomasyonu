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
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }
        public string TC;
        SqlBaglanti baglanti= new SqlBaglanti();
        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            labelTc.Text = TC;
            
            // Ad soyad Çekme 
            SqlCommand sqlCommand = new SqlCommand("Select HastaAd,HastaSoyad From hasta where hastaTc=@p1",baglanti.baglanti());
            sqlCommand.Parameters.AddWithValue("@p1",TC);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            
            // while ın if den farkı burda. while tüm verileri okuyor , if ise okunabilir mi diye bakıyor
            while (reader.Read())
            {             
                labelNameSurname.Text = reader[0]+" "+ reader[1];
            }
            baglanti.baglanti().Close();


            // Randevu Geçmiş
            DataTable dt= new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From randevular where hastaTc="+TC,baglanti.baglanti());
            da.Fill(dt);

            dataGridView1.DataSource = dt;

            // Branşları çekme

            SqlCommand cmd = new SqlCommand("Select bransAd From brans",baglanti.baglanti());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBoxBranch.Items.Add(dr[0]);
            }
            baglanti.baglanti().Close();
        }

        private void comboBoxBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxDoctor.Items.Clear();
            SqlCommand sqlCommand = new SqlCommand("Select doktorAd,doktorSoyad From doktor where doktorBrans=@p1",baglanti.baglanti());
            sqlCommand.Parameters.AddWithValue("@p1",comboBoxBranch.Text);

            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                comboBoxDoctor.Items.Add(reader[0]+" " + reader[1]);
            }
            baglanti.baglanti().Close();
        }

        private void FrmHastaDetay_FormClosing(object sender, FormClosingEventArgs e)
        {    

        }

        private void comboBoxDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();                                                     // sql de tek tırnak kelime (stringler) için gerekli
            SqlDataAdapter da = new SqlDataAdapter("Select * From randevular where randevuBrans='"+comboBoxBranch.Text+"' and randevuDoktor='"+comboBoxDoctor.Text+"' and randevuDurum=0",baglanti.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        
        }

        private void linkLabelBilgiDüzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HastaBilgiDüzenle frm = new HastaBilgiDüzenle();
            frm.tc = TC;
            frm.Show();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView2.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView2.Rows[selected].Cells[0].Value.ToString(); 
        }

        private void buttonRandevuAl_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Update randevular Set randevuDurum=1,hastaTc=@p1,randevuSikayet=@p2 where randevuID=@p3",baglanti.baglanti());

            cmd.Parameters.AddWithValue("@p1",labelTc.Text);
            cmd.Parameters.AddWithValue("@p2",richTextBoxSikayet.Text);
            cmd.Parameters.AddWithValue("@p3",textBox1.Text);

            cmd.ExecuteNonQuery();  
            
            baglanti.baglanti().Close();

            MessageBox.Show("Randevu Alındı","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Information);
        
        }
    }
}
