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
    public partial class ParaYatir : Form
    {
        public ParaYatir()
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label9.Visible = true;
            if (comboBox1.Text == "Ziraat Bankası")
            {
                label9.Text = "TR56 1458 6845 3159 2548 4895 56";
            }
            else if (comboBox1.Text == "Vakıfbank")
            {
                label9.Text = "TR09 7568 1063 0004 8787 0865 47";
            }
            else if (comboBox1.Text == "Akbank")
            {
                label9.Text = "TR96 5050 5045 9648 3264 6897 65";
            }
            else if (comboBox1.Text == "Finansbank")
            {
                label9.Text = "TR03 5875 8740 0101 3560 2485 21";
            }
            else if (comboBox1.Text == "Yapı Kredi Bankası")
            {
                label9.Text = "TR48 5769 1350 9848 8652 6596 12";
            }
            else if (comboBox1.Text == "Garanti Bankası")
            {
                label9.Text = "TR78 0325 8099 1054 5590 5986 96";
            }
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("İŞLEMİNİZ ALINMIŞTIR. ONAYLANDIĞINDA BİLGİLENDİRİLECEKSİNİZ...");
        }
    }
}