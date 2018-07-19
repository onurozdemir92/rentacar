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
    public partial class acilis : Form
    {
        public acilis()
        {
            InitializeComponent();
        }
        public String aracplakagetir(int id)
        {
            kiraveritabani baglanti = new kiraveritabani();
            var sorgu = from p in baglanti.araclar
                        where p.id == id
                        select new { plaka = p.plaka };
            var al = sorgu.FirstOrDefault();
            return al.plaka;
        }
        public String aracisimgetir(int id)
        {
            kiraveritabani baglanti = new kiraveritabani();
            var sorgu = from p in baglanti.araclar
                        where p.id == id
                        select new { isim = p.arac_adi };
            var al = sorgu.FirstOrDefault();
            return al.isim;
        }
        public String musteriisim(int id)
        {
            kiraveritabani baglanti = new kiraveritabani();
            var sorgu = from p in baglanti.musteriler
                        where p.id == id
                        select new { isim = p.isim };
            var al = sorgu.FirstOrDefault();
            return al.isim;
        }
        public String musteritel(int id)
        {
            kiraveritabani baglanti = new kiraveritabani();
            var sorgu = from p in baglanti.musteriler
                        where p.id == id
                        select new { tel = p.tel };
            var al = sorgu.FirstOrDefault();
            return al.tel;
        }

        public void kiradakiaraclargetir()
        {
            try
            {
                kiraveritabani baglanti = new kiraveritabani();
                var sorgu = from p in baglanti.kira
                            where p.teslim_kontrol == 0
                            select p;
                foreach (var getir in sorgu.ToList())
                {
                    kiradakilerpanel.AutoScroll = true;
                    kiradakilerpanel.HorizontalScroll.Enabled = true;
                    kiradakiarac arac = new kiradakiarac();
                    arac.aracresim = Image.FromFile("araclar/" + getir.arac_id + ".png");
                    arac.teslimsaat = getir.teslim_saat;
                    arac.teslimtarihi = getir.teslim_tarih.ToString("dd.MM.yyyy");
                    arac.aracplaka = aracplakagetir(getir.arac_id);
                    arac.aracismi = aracisimgetir(getir.arac_id);
                    arac.musteriadi = musteriisim(getir.mus_id);
                    arac.musteritel = musteritel(getir.mus_id);


                    arac.Dock = DockStyle.Top;
                    kiradakilerpanel.Controls.Add(arac);

                }
            }
            catch
            {
                MessageBox.Show("Kiradaki araclar olusturulken bir hata olustu");
            }

        }
        public void bugunteslimedilecek()
        {
            try
            {
                DateTimePicker tarih = new DateTimePicker();
            tarih.CustomFormat="dd.MM.yyyy";
            
             tarih.Text= DateTime.Today.ToString("dd.MM.yyyy");
            
                kiraveritabani baglanti = new kiraveritabani();
                var sorgu = from p in baglanti.kira
                            where p.teslim_kontrol == 0 && p.teslim_tarih == tarih.Value
            select p;
                foreach (var getir in sorgu.ToList())
                {
                    kiradakilerpanel.AutoScroll = true;
                    kiradakilerpanel.HorizontalScroll.Enabled = true;
                    teslimalinacak arac = new teslimalinacak();
                    arac.aracresmi= Image.FromFile("araclar/" + getir.arac_id + ".png");
                    arac.teslimsaati = getir.teslim_saat;
                    
                    arac.aracplaka = aracplakagetir(getir.arac_id);
                    arac.aracismi = aracisimgetir(getir.arac_id);
                    arac.musteriismi = musteriisim(getir.mus_id);
                    arac.musteritel = musteritel(getir.mus_id);


                    arac.Dock = DockStyle.Top;
                    teslimpanel.Controls.Add(arac);

                }
            }
            catch
            {
                MessageBox.Show("teslim edilecek araclar olusturulken bir hata olustu");
            }

        }
        public void araclsayi()
        {
            kiraveritabani baglanti = new kiraveritabani();
            var sorgu = from p in baglanti.araclar
                        select p;
            var aracsayisi = sorgu.Count();
            label1.Text = aracsayisi.ToString();

        }
        public void kirasayi()
        {
            kiraveritabani baglanti = new kiraveritabani();
            var sorgu = from p in baglanti.kira
                        select p;
            var aracsayisi = sorgu.Count();
            label6.Text = aracsayisi.ToString();

        }
        public void musterisayi()
        {
            kiraveritabani baglanti = new kiraveritabani();
            var sorgu = from p in baglanti.musteriler
                        select p;
            var musterisayisi = sorgu.Count();
            label4.Text = musterisayisi.ToString();

        }

        private void acilis_Load(object sender, EventArgs e)
        {


            kiradakiaraclargetir();
            bugunteslimedilecek();





         
            araclsayi();
            musterisayi();
            kirasayi();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            teslimal t = new teslimal();
            t.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            bugun b = new bugun();
            b.ShowDialog();
        }
    }
}
