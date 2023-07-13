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
    public partial class DoktorPaneli : Form
    {
        public DoktorPaneli()
        {
            InitializeComponent();
        }

        SqlBaglanti baglanti = new SqlBaglanti();



        private void updateDateGrid()
        {
            // Datagrid doldurma
            DataTable dataTable1 = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select *  From doktor", baglanti.baglanti());
            sqlDataAdapter.Fill(dataTable1);
            dataGridView1.DataSource = dataTable1;
        }
        private void DoktorPaneli_Load(object sender, EventArgs e)
        {
            updateDateGrid();
            // Brans comboBoxı doldurma
            SqlCommand cmd2 = new SqlCommand("Select bransAd From brans", baglanti.baglanti());
            SqlDataReader dr2 = cmd2.ExecuteReader();

            while (dr2.Read())
            {
                comboBoxBrans.Items.Add(dr2[0]);
            }
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("insert into doktor (doktorAd,doktorSoyad,doktorBrans,doktorTc,doktorSifre) values (@p1,@p2,@p3,@p4,@p5)",baglanti.baglanti());
            sqlCommand.Parameters.AddWithValue("@p1",textBoxName.Text);
            sqlCommand.Parameters.AddWithValue("@p2",textBoxSurname.Text);
            sqlCommand.Parameters.AddWithValue("@p3",comboBoxBrans.Text);
            sqlCommand.Parameters.AddWithValue("@p4",maskedTextBoxTc.Text);
            sqlCommand.Parameters.AddWithValue("@p5",textBoxPasword.Text);

            sqlCommand.ExecuteNonQuery();

            baglanti.baglanti().Close();
            MessageBox.Show("Doktor eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            updateDateGrid();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Delete From doktor where doktorTc=@p1",baglanti.baglanti());
            cmd.Parameters.AddWithValue("@p1", maskedTextBoxTc.Text);
            cmd.ExecuteNonQuery();
            baglanti.baglanti() .Close();
            MessageBox.Show("Doktor Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            updateDateGrid();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected= dataGridView1.SelectedCells[0].RowIndex;
            // data gridin seçilen satırının x. değerini getir diye çalışıyor
            textBoxName.Text= dataGridView1.Rows[selected].Cells[1].Value.ToString();
            textBoxSurname.Text= dataGridView1.Rows[selected].Cells[2].Value.ToString();
            comboBoxBrans.Text= dataGridView1.Rows[selected].Cells[3].Value.ToString();
            maskedTextBoxTc.Text= dataGridView1.Rows[selected].Cells[4].Value.ToString();
            textBoxPasword.Text= dataGridView1.Rows[selected].Cells[5].Value.ToString();
            
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("Update doktor set doktorAd=@p1,doktorSoyad=@p2,doktorBrans=@p3,doktorSifre=@p5 where doktorTc=@p4",baglanti.baglanti());
            sqlCommand.Parameters.AddWithValue("@p1", textBoxName.Text);
            sqlCommand.Parameters.AddWithValue("@p2", textBoxSurname.Text);
            sqlCommand.Parameters.AddWithValue("@p3", comboBoxBrans.Text);
            sqlCommand.Parameters.AddWithValue("@p4", maskedTextBoxTc.Text);
            sqlCommand.Parameters.AddWithValue("@p5", textBoxPasword.Text);

            sqlCommand.ExecuteNonQuery();

            baglanti.baglanti().Close();
            MessageBox.Show("Doktor Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            updateDateGrid();
        }
    }
}
