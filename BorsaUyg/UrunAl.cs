using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BorsaUyg
{
    public partial class UrunAl : Form
    {
        public UrunAl()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
                Application.Exit();
        }

        private void back_Click(object sender, EventArgs e)
        {
               KulaniciGiris frm = new KulaniciGiris();
               frm.Show();
               this.Hide();
        }

        private void btnUalisEmri_Click(object sender, EventArgs e)
        {
            AlisEmri frm = new AlisEmri();
            frm.Show();
            this.Hide();
        }

        private void ptrSepet_Click(object sender, EventArgs e)
        {
            Sepet frm = new Sepet();
            frm.Show();
            this.Hide();

        }
    }
}
       