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
    public partial class RandevuListesi : Form
    {
        public RandevuListesi()
        {
            InitializeComponent();
        }

        SqlBaglanti sql= new SqlBaglanti();
        private void randevuListesi_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * From randevular", sql.baglanti());
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        public int selected;
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selected= dataGridView1.SelectedCells[0].RowIndex;
        }
    }
}
