using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneRandevuOtomasyonu
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonHasta_Click(object sender, EventArgs e)
        {
            HastaLogin frmPatient = new HastaLogin();
            this.Hide();
            frmPatient.Show();
           

        }

        private void buttonDoktor_Click(object sender, EventArgs e)
        {
            DoktorLogin frm= new DoktorLogin();
            this.Hide();
            frm.Show();
            
        }

        private void buttonSekreter_Click(object sender, EventArgs e)
        {
            SekreterLogin frmSekreterLogin = new SekreterLogin();
            this.Hide();
            frmSekreterLogin.Show();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
