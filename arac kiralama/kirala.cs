using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arac_kiralama
{
    public partial class kirala : Form
    {
        public void temizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            kirasecilenarac = 0;
            kirasecilenmusteri = 0;
            panel1.Visible = false;
            panel2.Visible = false;
        }
        public static int kirasecilenmusteri{ get; set; }

        public static int kirasecilenarac { get; set; }
        public void musterigetir(int mus)
        {
            try
            {
                kiraveritabani baglanti = new kiraveritabani();
                var sorgu = from p in baglanti.musteriler
                            where p.id == mus
                            select p;
                var al = sorgu.FirstOrDefault();
                ibisim.Text = al.isim;
                lbtc.Text = al.TC;
                lbtel.Text = al.tel;
                lbeht.Text = al.eh_tarih.ToString();
                lbehno.Text = al.eh_no;
                lbdogumt.Text = al.d_tarih.ToString();
                lbcinsiyet.Text = al.cinsiyet;
                tbadres.Text = al.adres;
                panel1.Visible = true;
            }
            catch { }

        }
        public void aracgetir(int arac)
        {
            try
            {
                kiraveritabani baglanti = new kiraveritabani();
                var sorgu = from p in baglanti.araclar
                            where p.id == arac
                            join markaal in baglanti.marka on p.marka_id equals markaal.id
                            join modelal in baglanti.model on p.model_id equals modelal.id
                            select new { p.plaka, markaal.markaadi, modelal.modeladi, p.koltuk, p.klima, p.kapi, p.vites, p.yakit,p.gun_fiyat };
                var al = sorgu.FirstOrDefault();
                pictureBox7.Image = Image.FromFile("araclar/" + arac + ".png");
                label7.Text = al.plaka;
                label8.Text = al.markaadi;
                label9.Text = al.modeladi;
                label4.Text = al.koltuk;
                label1.Text = al.kapi;
                label2.Text = al.vites;
                label3.Text = al.klima;
                label5.Text = al.yakit;
                gunlukfiyat.Text = al.gun_fiyat;
                panel2.Visible = true;
            }
            catch { }
            
        }
        public void kirakayit()
        {
            try
            {
                kiraveritabani baglanti = new kiraveritabani();
                kira yenikira = new kira();
                yenikira.mus_id = kirasecilenmusteri;
                yenikira.arac_id = kirasecilenarac;
                yenikira.alis_tarih = dateTimePicker2.Value;
                yenikira.alis_saat = textBox1.Text;
                yenikira.odeme_turu = comboBox1.Text;
                yenikira.odenecek_tutar = textBox3.Text;
                yenikira.teslim_kontrol = 0;
                yenikira.teslim_tarih = dateTimePicker1.Value;
                yenikira.teslim_saat = textBox2.Text;
                yenikira.kul_id = giris.kullaniciidsi;
                baglanti.kira.Add(yenikira);
                baglanti.SaveChanges();
                MessageBox.Show("Arac Kıraya Verılmıstır");
                temizle();
            }
            catch
            {
                MessageBox.Show("Kayit Isleminde Bir Hata Olustu");
            }
        }
        public kirala()
        {
            InitializeComponent();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            musterisec m = new musterisec();
            m.ShowDialog();


            musterigetir(kirasecilenmusteri);
        }

        private void kirala_Load(object sender, EventArgs e)
        {
            kirasecilenarac = 0;
            kirasecilenmusteri = 0;
            panel1.Visible = false;
            panel2.Visible = false;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            aracsec a = new aracsec();
            a.ShowDialog();
            aracgetir(kirasecilenarac);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (kirasecilenarac != 0&& kirasecilenmusteri != 0)
            {
                kirakayit();
            }
            else
                MessageBox.Show("arac ve musteri seciniz");
         

        }
    }
}
