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
    public partial class AlisEmri : Form
    {
        public AlisEmri()
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
            MessageBox.Show("ALIŞ EMRİ VERMEDİNİZ!");
            frm.Show();
            this.Hide();
        }

        private void btnAlisEmri_Click(object sender, EventArgs e)
        {
            KulaniciGiris frm = new KulaniciGiris();
            //textBoxlardaki bilgileri kullanıcı girişinde ki listBoxa atılır.
            frm.alisAd = tbUrun.Text;
            frm.alisMiktar = tbMiktar.Text;
            frm.alisFiyat = tbFiyat.Text;
            MessageBox.Show("ALIŞ EMRİNİZ ONAYLANMIŞTIR...");
            frm.Show();
            this.Hide();
        }
    }
}
