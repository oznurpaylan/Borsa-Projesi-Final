using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;


namespace BorsaUyg
{
    public partial class AdminGiris : Form
    {
        public AdminGiris()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ÇIKIŞ YAPILDI...");
            GirisEkrani frm = new GirisEkrani();
            frm.Show();
            this.Hide();
        }

        private void AdminGiris_Load(object sender, EventArgs e)
        {
            timer1.Start(); //Tarih ve saat timerını başlatır.
            timer2.Start(); //Döviz çekmek için timer'ı başlatır.
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTarih.Text = DateTime.Now.ToLongDateString(); //Tarih bilgisi gösterilir.
            lblSaat.Text = DateTime.Now.ToLongTimeString(); //Saat bilgisi gösterilir.

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Interval = 5000; //5 saniyede bir yenilenmesini sağlar.
            DovizCek();
        }
        
        public void DovizCek()
        { 
            try
            {
                XmlDocument xmlData = new XmlDocument();
                xmlData.Load("http://www.tcmb.gov.tr/kurlar/today.xml"); //Döviz bilgilerinin çekileceği sayfa
                decimal dolar = Convert.ToDecimal(xmlData.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "USD")).InnerText.Replace('.', ','));
                decimal euro = Convert.ToDecimal(xmlData.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "EUR")).InnerText.Replace('.', ','));
                decimal sterlin = Convert.ToDecimal(xmlData.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "GBP")).InnerText.Replace('.', ','));
                decimal frang = Convert.ToDecimal(xmlData.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "CHF")).InnerText.Replace('.', ','));
                decimal kDolar = Convert.ToDecimal(xmlData.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "CAD")).InnerText.Replace('.', ','));

                lblDolar.Visible = true;
                lblEuro.Visible = true;
                lblFrang.Visible = true;
                lblKDolar.Visible = true;
                lblSterlin.Visible = true;

                lblDolar.Text = dolar.ToString();
                lblEuro.Text = euro.ToString();
                lblSterlin.Text = sterlin.ToString();
                lblFrang.Text = frang.ToString();
                lblKDolar.Text = kDolar.ToString();
            }
            catch (XmlException xml)
            {
                timer2.Stop();
                MessageBox.Show(xml.ToString());
            }

        }
    }
}
