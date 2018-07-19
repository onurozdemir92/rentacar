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
    public partial class musteriekle : Form
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
        public void temizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox7.Clear();

        }
        public musteriekle()
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
                    musteriler yenimusteri = new musteriler();
                    yenimusteri.TC=textBox1.Text;
                    yenimusteri.isim = textBox2.Text;
                    yenimusteri.d_tarih = dateTimePicker2.Value;
                    yenimusteri.eh_tarih = dateTimePicker1.Value;
                    yenimusteri.eh_no = textBox4.Text;
                    yenimusteri.tel = textBox3.Text;
                    yenimusteri.adres = textBox7.Text;
                    yenimusteri.cinsiyet = comboBox1.Text;
                    baglanti.musteriler.Add(yenimusteri);
                    baglanti.SaveChanges();
                    MessageBox.Show("Musteri Eklenmistir");
                    button2.Text = "Kapat";
                    temizle();
                }
                catch
                {
                    MessageBox.Show("Bir Hata Olustu!");
                }
            }
            else
            {
                MessageBox.Show("Bos Alan Birakmayiniz");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
