using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace arac_kiralama
{
    public partial class aracduzenle : Form
    {
        public void markagetir()
        {
            kiraveritabani a = new kiraveritabani();
            var sorgu = from p in a.marka
                        select new { p.id, adi = p.markaadi.Trim(), };
            cbmarka.ValueMember = "id";
            cbmarka.DisplayMember = "adi";
            cbmarka.DataSource = sorgu.ToList();

        }
        public void modelgetir()
        {
            int a = Convert.ToInt32(cbmarka.SelectedValue);

            kiraveritabani baglanti = new kiraveritabani();
            var sorgu = from p in baglanti.model
                        where p.marka_id == a
                        select new { p.id, ad = p.modeladi.Trim() };
            cbmodel.ValueMember = "id";
            cbmodel.DisplayMember = "ad";
            cbmodel.DataSource = sorgu.ToList();
        }
        public void verigetir(int id)
        {
            kiraveritabani baglanti = new kiraveritabani();
            var sorgu=from p in baglanti.araclar
                      where p.id==id
                      select new { Id = p.id, Plaka = p.plaka.Trim(), Adi = p.arac_adi.Trim(), Marka = p.marka_id, Model = p.model_id, Kapi = p.kapi.Trim(), Klima = p.klima.Trim(), Koltuk = p.koltuk.Trim(), Vites = p.vites.Trim(), Yakit = p.yakit.Trim(), Yil = p.yil.Trim(),Fiyat=p.gun_fiyat,Durum=p.arackullanim,hasar=p.hasar };

            var al = sorgu.FirstOrDefault();
            tbplaka.Text = al.Plaka;
            cbkapi.Text = al.Kapi;
            cbkilima.Text = al.Klima;
            cbkoltuk.Text = al.Koltuk;
            cbmarka.SelectedValue = al.Marka;
            cbmodel.SelectedValue = al.Model;
            cbvites.Text = al.Vites;
            cbyakit.Text = al.Yakit;
            tbaracadi.Text = al.Adi;
            tbgunfiyat.Text = al.Fiyat;
            if (al.Durum == 0)
                cbdurum.Text = "Arac Kirada Degil";
           else if (al.Durum == 1)
                cbdurum.Text = "Arac Kirada";

            tbyil.Text = al.Yil;
            tbhasar.Text = al.hasar;
            try
            {
                arabaresim.Image = Image.FromFile("araclar/" + arac.secilenid + ".png");
            }
            catch
            {
                MessageBox.Show("Arac resmi bulunmamakdadir");
            }







        }
        public aracduzenle()
        {
            InitializeComponent();
        }

        private void aracduzenle_Load(object sender, EventArgs e)
        {
            markagetir();
            modelgetir();
            if (arac.secilenid !=0)
            {
                verigetir(arac.secilenid);
            }
            else
            {
                MessageBox.Show("Bir Arac Seciniz");
                this.Close();
            }
        }

        private void cbmarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            modelgetir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                kiraveritabani baglanti = new kiraveritabani();
                var sorgu = from p in baglanti.araclar
                            where p.id == arac.secilenid
                            select p;
                foreach (var duzenle in sorgu)
                {
                    duzenle.gun_fiyat = tbgunfiyat.Text;
                    duzenle.hasar = tbhasar.Text;
                    duzenle.kapi = cbkapi.Text;
                    duzenle.klima = cbkilima.Text;
                    duzenle.koltuk = cbkoltuk.Text;
                    duzenle.marka_id = Convert.ToInt32(cbmarka.SelectedValue);
                    duzenle.model_id = Convert.ToInt32(cbmodel.SelectedValue);
                    duzenle.plaka = tbplaka.Text;
                    duzenle.vites = cbvites.Text;
                    duzenle.yakit = cbyakit.Text;
                    duzenle.yil = tbyil.Text;
                    duzenle.arac_adi = tbaracadi.Text;
                    if (cbdurum.Text == "Arac Kirada Degil")
                        duzenle.arackullanim = 0;
                    if (cbdurum.Text == "Arac Kirada")
                        duzenle.arackullanim = 1;

                }
                baglanti.SaveChanges();
               

                
                MessageBox.Show("Duzenlendi");
                button2.Text = "kapat";
            }
            catch
            {
                MessageBox.Show("hata");
            }
           

       


        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "Png Uzantili dosya(*.png)|*.png";
            o.Title = "Resim Sec";
            o.ShowDialog();

            String yol = o.FileName;
            arabaresim.Image = Image.FromFile(yol);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
