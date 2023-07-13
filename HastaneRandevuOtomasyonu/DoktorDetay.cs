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
    public partial class DoktorDetay : Form
    {
        public DoktorDetay()
        {
            InitializeComponent();
        }

        SqlBaglanti baglanti = new SqlBaglanti();

        public String TC;
        private void DoktorDetay_Load(object sender, EventArgs e)
        {
           labelTc.Text = TC;
          
            // Doktor ad soyad datadan veri çekilecek
            SqlCommand cmd = new SqlCommand("Select doktorAd, doktorSoyad From doktor where doktorTc=@p1",baglanti.baglanti());
            cmd.Parameters.AddWithValue("@p1",labelTc.Text);
            SqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                labelNameSurname.Text = dataReader[0] + " " + dataReader[1];
            }
            baglanti.baglanti().Close();


            // Doktora ait randevular

            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * From  randevular where randevuDoktor='"+labelNameSurname.Text+"'",baglanti.baglanti());
            
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void bilgiDüzenle_Click(object sender, EventArgs e)
        {
            DoktorBilgiDüzenle doktor= new DoktorBilgiDüzenle();
            doktor.TC = labelTc.Text;
            doktor.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Duyurular duyurular = new Duyurular();  
            duyurular.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected= dataGridView1.SelectedCells[0].RowIndex;
            
            richTextBox1.Text= dataGridView1.Rows[selected].Cells[7].Value.ToString();
        
        }

        private void DoktorDetay_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
