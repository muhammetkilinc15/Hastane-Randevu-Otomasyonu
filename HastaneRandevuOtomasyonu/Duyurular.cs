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
    public partial class Duyurular : Form
    {
        public Duyurular()
        {
            InitializeComponent();
        }


        SqlBaglanti baglanti = new SqlBaglanti();   
        private void duyurular_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * From duyurular",baglanti.baglanti());
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;

        }
    }
}
