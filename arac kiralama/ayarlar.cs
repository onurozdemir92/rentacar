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
    public partial class ayarlar : Form
    {
    
        public Boolean duzenle(int id,string kulad)
        {
            kiraveritabani baglanti = new kiraveritabani();
            var sorgu = from p in baglanti.kullanici
                        where p.id != id && p.kullanici_adi == kulad && p.durum=="1"
                        select p;
            if (sorgu.Any())
                return true;
            else
                return false;


        }
        int secilenkullanici;
        public void bilgigetir(int id)
        {
            kiraveritabani baglanti = new kiraveritabani();
            var sorgu = from p in baglanti.kullanici
                        where p.id == id
                        select p;
            var sonuc = sorgu.FirstOrDefault();
            secilenkullanici =id;

            textBox3.Text = sonuc.kullanici_adi;
            textBox4.Text = sonuc.sifre;
            textBox2.Text = sonuc.isim;
            dateTimePicker1.Value = sonuc.d_tarih;
            textBox1.Text = sonuc.TC;

        }
        public void temizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
        public void kullanicigetir()
        {
            kiraveritabani baglanti = new kiraveritabani();
            var sorgu = from p in baglanti.kullanici
                        where p.durum=="1"
                        select p;
            dataGridView1.DataSource = sorgu.ToList(); ;

        }
        public ayarlar()
        {
            InitializeComponent();
        }

        private void ayarlar_Load(object sender, EventArgs e)
        {
            kullanicigetir();
            secilenkullanici = 0;
            button6.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {if (textBox5.Text == textBox4.Text)
            {
                if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "")
                {
                    MessageBox.Show("Bos Alan Birakmayiniz");

                }
                else
                {



                    if (!kullanici.kullanicikontrol(textBox3.Text))
                    {
                        try
                        {
                            kullanici k = new kullanici(textBox3.Text, textBox4.Text, textBox2.Text, dateTimePicker1.Value, textBox1.Text,"1");
                            MessageBox.Show("Kullanici Kaydi Yapilmistir");
                            temizle();
                            button6.Visible = false;
                            kullanicigetir();

                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show("Kayit Islemi Yapilirken Bir Hata Olustu:"+ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bu Kullanici Adi Zaten Kayitli");
                    }
                }
            }
            else
            {
                MessageBox.Show("Sifreler Ayni degil");
            }
        
            
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            button6.Visible = true;
            bilgigetir(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
            





        }

        private void button6_Click(object sender, EventArgs e)
        {
            secilenkullanici = 0;
            temizle();
            button6.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!duzenle(secilenkullanici, textBox3.Text))
            {
                if (textBox4.Text == textBox5.Text)
                {
                    if (secilenkullanici != 0)
                    {
                        try
                        {
                            kiraveritabani baglanti = new kiraveritabani();
                            var sorgu = from p in baglanti.kullanici
                                        where p.id == secilenkullanici
                                        select p;
                            foreach (var duzenle in sorgu)
                            {
                                duzenle.d_tarih = dateTimePicker1.Value;
                                duzenle.TC=textBox1.Text;
                                duzenle.isim = textBox2.Text;
                                duzenle.kullanici_adi = textBox3.Text;
                                duzenle.sifre = textBox4.Text;


                            }
                            baglanti.SaveChanges();
                            MessageBox.Show("Duzeltildi");
                            temizle();
                            button6.Visible = false;
                            secilenkullanici = 0;
                            kullanicigetir();
                            
                      
                        }
                        catch
                        {
                            MessageBox.Show("hata");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bir Kullanici Seciniz");
                    }
                }
                else
                {
                    MessageBox.Show("Sifreler ayni degil");
                }
            }
            else
            {
                MessageBox.Show("Bu kullanici Adinda Baska Kayit Var");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            markaekle m = new markaekle();
            formalan.Controls.Clear();
            m.Dock = DockStyle.Fill;
            formalan.Controls.Add(m);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            modelekle m = new modelekle();
            formalan.Controls.Clear();
            m.Dock = DockStyle.Fill;
            formalan.Controls.Add(m);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (secilenkullanici != 0)
            {
                try
                {
                    kiraveritabani baglanti = new kiraveritabani();
                    var sorgu = from p in baglanti.kullanici
                                where p.id == secilenkullanici
                                select p;
                    foreach (var duzenle in sorgu)
                    {
                      
                        duzenle.durum = "0";


                    }
                    baglanti.SaveChanges();
                    MessageBox.Show("silindi");
                    temizle();
                    button6.Visible = false;
                    secilenkullanici = 0;
                    kullanicigetir();


                }
                catch
                {
                    MessageBox.Show("hata");
                }
            }
            else
            {
                MessageBox.Show("Bir Kullanici Seciniz");
            }
        }
    }
}
