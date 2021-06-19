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
    public partial class UrunSat : Form
    {
        public UrunSat()
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

        private void button1_Click(object sender, EventArgs e)
        {
                KulaniciGiris frm = new KulaniciGiris();
                frm.satisAd = textBox1.Text;
                frm.satisMiktar = textBox2.Text;
                frm.satisFiyat = textBox3.Text;
                MessageBox.Show("ÜRÜNLERİNİZ SATIŞA ÇIKARILMIŞTIR...");
                frm.Show();
                this.Hide();
        }
    }
}
