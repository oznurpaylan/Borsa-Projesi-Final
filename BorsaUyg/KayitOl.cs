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
    public partial class KayitOl : Form
    {
        public KayitOl()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_Click(object sender, EventArgs e)
        {
            GirisEkrani frm = new GirisEkrani();
            frm.Show();
            this.Hide();
        }

        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "" || textBox4.Text == "" || textBox7.Text == "")
                MessageBox.Show("* LI ALANLAR BOŞ GEÇİLEMEZ!");
            else
            {
                MessageBox.Show("KAYDINIZ BAŞARIYLA OLUŞTURULMUŞTUR. GİRİŞ YAPINIZ...");
                GirisEkrani frm = new GirisEkrani();
                frm.Show();
                this.Hide();
            }
        }
    }
}