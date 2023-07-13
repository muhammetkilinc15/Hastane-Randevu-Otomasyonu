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
    public partial class Brans : Form
    {
        public Brans()
        {
            InitializeComponent();
        }

        SqlBaglanti baglanti= new SqlBaglanti();
        private void Brans_Load(object sender, EventArgs e)
        {
            getDataGried();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into brans (bransAd) values (@p1)",baglanti.baglanti());
            cmd.Parameters.AddWithValue("@p1",textBoxBransName.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Branş Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            getDataGried();
        }
        public void getDataGried()
        {
            DataTable dt = new DataTable();

            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * From brans", baglanti.baglanti());
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("Delete From brans where bransId=@p1",baglanti.baglanti());
            sqlCommand.Parameters.AddWithValue("@p1",textBoxBransId.Text);
            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("Branş Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            getDataGried();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = dataGridView1.SelectedCells[0].RowIndex;
            textBoxBransId.Text = dataGridView1.Rows[selected].Cells[0].Value.ToString();
            textBoxBransName.Text = dataGridView1.Rows[selected].Cells[1].Value.ToString();
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand sql = new SqlCommand("Update  brans set bransAd=@a1 where bransId=@p1", baglanti.baglanti());
            sql.Parameters.AddWithValue("@p1",textBoxBransId.Text);
            sql.Parameters.AddWithValue("@a1",textBoxBransName.Text);
            sql.ExecuteNonQuery();
            MessageBox.Show("Branş GÜncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            getDataGried();
        }
    }
}
