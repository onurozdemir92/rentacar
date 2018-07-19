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
    public partial class musteriyiduzenle : Form
    {
        public Boolean kontrol()
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox7.Text != "" && comboBox1.Text != "")
                return true;
            else
            {
                return false;
            }
        }

        public void musterigetir()
        {
            try
            {
                kiraveritabani baglanti = new kiraveritabani();
                var sorgu = from p in baglanti.musteriler
                            where p.id == musteriform.secilenmusteri
                            select p;
                var al = sorgu.FirstOrDefault();
                textBox1.Text = al.TC;
                textBox2.Text = al.isim;
                dateTimePicker1.Value = al.d_tarih;
                dateTimePicker2.Value = al.eh_tarih;
                textBox3.Text = al.tel;
                textBox4.Text = al.eh_no;
                comboBox1.Text = al.cinsiyet;
                textBox7.Text = al.adres;
            }
            catch
            {
                MessageBox.Show("Bir Hata Olustu");
                this.Close();
            }


        }
        public musteriyiduzenle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (kontrol())
            {
                try
                {
                    kiraveritabani baglanti = new kiraveritabani();
                    var sorgu = from p in baglanti.musteriler
                                where p.id == musteriform.secilenmusteri
                                select p;
                    foreach (var duzenle in sorgu)
                    {
                        duzenle.TC=textBox1.Text;
                        duzenle.isim = textBox2.Text;
                        duzenle.d_tarih = dateTimePicker2.Value;
                        duzenle.tel = textBox3.Text;
                        duzenle.eh_no = textBox4.Text;
                        duzenle.eh_tarih = dateTimePicker2.Value;
                        duzenle.cinsiyet = comboBox1.Text;
                        duzenle.adres = textBox7.Text;

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
            else
            {
                MessageBox.Show("Bos Alan Birakmayiniz");
            }
        }

        private void musteriyiduzenle_Load(object sender, EventArgs e)
        {
            if (musteriform.secilenmusteri != 0)
            {
                musterigetir();
            }
            else
            {
                MessageBox.Show("Bir Musteri Secin");
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
