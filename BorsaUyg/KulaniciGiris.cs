using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;

namespace BorsaUyg
{
    public partial class KulaniciGiris : Form
    {
        public KulaniciGiris()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void back_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ÇIKIŞ YAPILDI...");
            GirisEkrani frm = new GirisEkrani();
            frm.Show();
            this.Hide();
        }

        private void btnParaYatir_Click(object sender, EventArgs e)
        {
            ParaYatir frm = new ParaYatir();
            frm.Show();
            this.Hide();
        }

        private void btnUrunAl_Click(object sender, EventArgs e)
        {
            UrunAl frm = new UrunAl();
            frm.Show();
            this.Hide();
        }

        private void btnUrunSat_Click(object sender, EventArgs e)
        {
            UrunSat frm = new UrunSat();
            frm.Show();
            this.Hide();
        }

        private void btnAlis_Click(object sender, EventArgs e)
        {
            AlisEmri frm = new AlisEmri();
            frm.Show();
            this.Hide();
        }

        private void HesapBilgileriLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HesapBilgileri frm = new HesapBilgileri();
            frm.Show();
            this.Hide();
        }

        public string satisAd, satisMiktar, satisFiyat; //Ürün sat formu için
        public string alisAd, alisMiktar, alisFiyat; //Alış emri ver formu için
        private void KulaniciGiris_Load(object sender, EventArgs e)
        {
            string[] satisEkle = { satisAd, satisMiktar, satisFiyat }; //Ürün sat formunda satışa çıkarılan ürünleri kullanıcı girişi formunda listView1 e gönderir.
            var satisSatir = new ListViewItem(satisEkle);
            listView1.Items.Add(satisSatir);

            string[] alisEkle = { alisAd, alisMiktar, alisFiyat }; // Alış emri ver formunda belirtilen ürünlerii kullanıcı girişi formunda listView3 e gönderir.
            var alisSatir = new ListViewItem(alisEkle);
            listView3.Items.Add(alisSatir);

            timer1.Start();

            //dataGridView1 için veriler.
            dataGridView1.Rows.Add("01.03.2021", "Hasan ŞEN", "Buğday", "60", "3", "%1");
            dataGridView1.Rows.Add("12.04.2021", "Aynur KİRAZ", "Pırasa", "40", "3.50", "%1");
            dataGridView1.Rows.Add("26.04.2021", "Selma YILMAZ", "Arpa", "100", "2.50", "%1");
            dataGridView1.Rows.Add("09.05.2021", "Ali BAYRAK", "Elma", "44", "5", "%1");
            dataGridView1.Rows.Add("15.05.2021", "Fatma SEZEN", "Domates", "78", "5.50", "%1");
            dataGridView1.Rows.Add("22.05.2021", "Serdar GÜN", "Elma", "50", "5", "%1");

            //dataGridView2 için veriler
            dataGridView2.Rows.Add("12.03.2021", "Domates", "45", "260");
            dataGridView2.Rows.Add("30.03.2021", "Salatalık", "120", "362");
            dataGridView2.Rows.Add("16.04.2021", "Patates", "63", "186");
            dataGridView2.Rows.Add("28.04.2021", "Çilek", "20", "140");
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        { //Tarih ve saat bilgisini form ekranında gösterir.
            lblTarih.Text= DateTime.Now.ToLongDateString();
            lblSaat.Text = DateTime.Now.ToLongTimeString();
        }

        private void AlisLinklbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            exceleYaz();
        }

        private void SatisLinklbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dataGridView1 = dataGridView2;
            exceleYaz();
        }

        public void exceleYaz()
        {
            Excel.Application excel = new Excel.Application();
            excel.Visible = true;
            Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);
            Worksheet sheet1 = (Worksheet)workbook.Sheets[1];
            int StartCol = 1; //Sütun
            int StartRow = 1; //Satır 1 den başladı.
            for (int j = 0; j < dataGridView1.Columns.Count; j++) //Sütun sayısı kadar işlem yapar.
            {
                Range myRange = (Range)sheet1.Cells[StartRow, StartCol + j];
                myRange.Value2 = dataGridView1.Columns[j].HeaderText; //j ninci sütunun başlığı.
            } //Sütun başlıkları aktarıldı.
            StartRow++;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    Range myRange = (Range)sheet1.Cells[StartRow + i, StartCol + j];
                    myRange.Value2 = dataGridView1[j, i].Value == null ? "" : dataGridView1[j, i].Value;

                }
            }
        }
    }
}