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
    public partial class GirisEkrani : Form
    {
        public GirisEkrani()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblKayıt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KayitOl frm = new KayitOl();
            frm.Show();
            this.Hide();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "kullanıcı" && textBox2.Text == "1234")
            {
                KulaniciGiris frm = new KulaniciGiris();
                frm.Show();
                this.Hide();
            }
            else if (textBox1.Text == "admin" && textBox2.Text == "1234")
            {
                AdminGiris frm = new AdminGiris();
                frm.Show();
                this.Hide();
            }
            else
                MessageBox.Show("HATALI KULLANICI ADI VEYA PAROLA!");

        }
    }
}
