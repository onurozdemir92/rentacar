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

namespace arac_kiralama
{
    public partial class anasayfa : Form
        
    {

        string today = "http://www.tcmb.gov.tr/kurlar/today.xml";
        string USD;
        string EURO;
        void kiralagetir()
        {
            alan.Controls.Clear();
            kirala newForm = new kirala();
            newForm.TopLevel = false;
            alan.Controls.Add(newForm);
            newForm.Show();
            newForm.Dock = DockStyle.Fill;
            newForm.BringToFront();
            label3.Text = "Kirala";
        }

        void musterilergetir()
        {
            alan.Controls.Clear();
            musteriform newForm = new musteriform();
            newForm.TopLevel = false;
            alan.Controls.Add(newForm);
            newForm.Show();
            newForm.Dock = DockStyle.Fill;
            newForm.BringToFront();
            label3.Text = "Musteriler";
        }

        void acilis()
        {
            alan.Controls.Clear();
            acilis newForm = new acilis();
            newForm.TopLevel = false;
            alan.Controls.Add(newForm);
            newForm.Show();
            newForm.Dock = DockStyle.Fill;
            newForm.BringToFront();
            label3.Text = "Ana Sayfa";
        }
        void kiragecmis()
        {
            alan.Controls.Clear();
            kiragecmis newForm = new kiragecmis();
            newForm.TopLevel = false;
            alan.Controls.Add(newForm);
            newForm.Show();
            newForm.Dock = DockStyle.Fill;
            newForm.BringToFront();
            label3.Text = "Kira Gecmisi";
        }
        void araclargetir()
        {
            alan.Controls.Clear();
            arac newForm = new arac();
            newForm.TopLevel = false;
            alan.Controls.Add(newForm);
            newForm.Show();
            newForm.Dock = DockStyle.Fill;
            newForm.BringToFront();
            label3.Text = "Araclar";
        }
        void ayarlargetir()
        {
            alan.Controls.Clear();
            ayarlar newForm = new ayarlar();
            newForm.TopLevel = false;
            alan.Controls.Add(newForm);
            newForm.Show();
            newForm.Dock = DockStyle.Fill;
            newForm.BringToFront();
            label3.Text = "Ayarlar";
        }
        int kontrol=0;

         public static string Adal(string kulad)
        {
            kiraveritabani baglanti = new kiraveritabani();
            var sorgu = from p in baglanti.kullanici
                        where p.kullanici_adi == kulad
                        select new { p.isim };
            var aa = sorgu.FirstOrDefault();
                string s =aa.isim;
                return  s;
        }

        public anasayfa()
        {
            InitializeComponent();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToString("HH :mm:ss");
            label4.Text = DateTime.Today.ToString("dd.MM.yyyy");
        }

        private void anasayfa_Load(object sender, EventArgs e)
        {
            acilis();
            timer1.Start();
            try
            {
                var xmlDoc = new XmlDocument();
                xmlDoc.Load(today);
                USD = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
                EURO = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            }
            catch
            {
                lbdolar.Text = "baglanti yok";
                lbeuro.Text = "baglanti yok";
            }

           

            lbdolar.Text = USD;
            lbeuro.Text = EURO;
            label2.Text = giris.girisyapan;
            label1.Text=Adal(giris.girisyapan);





        }

        private void button9_Click(object sender, EventArgs e)
        {
            switch (kontrol)
            {
                case 0:
                    this.WindowState = FormWindowState.Maximized;
                    kontrol = 1;
                    break;

                case 1:
                    this.WindowState = FormWindowState.Normal;
                    kontrol = 0;
                    break;

            }
          
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            acilis();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            araclargetir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mesaj m = new mesaj();
            m.ShowDialog();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button10_Click(object sender, EventArgs e)
        {
      
        }

        private void button3_Click(object sender, EventArgs e)
        {
            musterilergetir();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            kiralagetir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kiragecmis();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ayarlargetir();
        }
    }
}
