using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arac_kiralama
{
    public partial class giris : Form
    {
        public static string girisyapan;
        public static int kullaniciidsi { get; set; }
        private bool kullanicikontrol(string kadi,string ksifre)
        {
            kiraveritabani baglanti = new kiraveritabani();



            var sorgu = from p in baglanti.kullanici
                        where p.kullanici_adi == kadi
                        && p.sifre == ksifre && p.durum == "1"
                        select p;
            var al = sorgu.FirstOrDefault();
            if (sorgu.Any())
            {
                kullaniciidsi = al.id;
                return true;
            }

            else
            {
                return false;
            }



        }
        public giris()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           

            if (kullanicikontrol(textBox1.Text, textBox2.Text))
            {
                girisyapan = textBox1.Text;
                anasayfa a = new anasayfa();
                a.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("hatali");
            }
        }

        private void giris_Load(object sender, EventArgs e)
        {//toplu silme
         //kiraveritabani baglanti = new kiraveritabani();
         //var sorgu = from p in baglanti.kira
         //            select p;

            //foreach (var d in sorgu.ToList())
            //{
            //    baglanti.kira.Remove(sorgu.FirstOrDefault());
            //    baglanti.SaveChanges();
            //}

            //kullanici k = new kullanici();
            //k.kullanicikayit("onurrahmi", "1234", "Onur Rahmi Ozdemir",DateTime.Now, "32323232");
            //try
            //{

            //}catch(Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}

            //kullanici k = new kullanici("onur", "1", "onur rahmi", DateTime.Now, "123432");

        }
    }
}
