using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace arac_kiralama
{
    public partial class aracekle : Form
    {
        public void temizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            
        }
        public Boolean plakakontrol(string plaka)
        {
            kiraveritabani baglanti = new kiraveritabani();
            var sorgu = from p in baglanti.araclar
                        where p.plaka == plaka
                        select p;
            if (sorgu.Any())
                return true;
            else
                return false;
        }
        public Boolean kontrol()

        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || comboBox1.Text == "" || comboBox2.Text == "" || comboBox3.Text == "" || comboBox4.Text == "" || comboBox5.Text == "" || comboBox6.Text == "" || comboBox7.Text == "") 
            return false;
            else 
            return true;
        }
        public void markagetir(){
            kiraveritabani a = new kiraveritabani();
            var sorgu = from p in a.marka
                        select new { p.id, adi=p.markaadi.Trim(), };
            comboBox6.ValueMember = "id";
            comboBox6.DisplayMember = "adi";
            comboBox6.DataSource =sorgu.ToList();
                
            }
        public void modelgetir()
        { int a = Convert.ToInt32(comboBox6.SelectedValue);
            
            kiraveritabani baglanti = new kiraveritabani();
            var sorgu = from p in baglanti.model
                        where p.marka_id == a
                        select new { p.id, ad = p.modeladi.Trim() };
            comboBox7.ValueMember = "id";
            comboBox7.DisplayMember = "ad";
            comboBox7.DataSource = sorgu.ToList();
        }
        public static int idal()
        {
            kiraveritabani baglanti = new kiraveritabani();
         
            int s = baglanti.araclar.Max(u => u.id);
            return s;
        }
        public aracekle()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (plakakontrol(textBox2.Text))
            {
                MessageBox.Show("Bu plakaya ait Arac bulunmakdadir");
            }
            else
            {
                if (kontrol())
                {
                    try
                    {
                        kiraveritabani a = new kiraveritabani();
                        araclar yeniarac = new araclar();
                        yeniarac.arac_adi = textBox1.Text;
                        yeniarac.gun_fiyat = textBox3.Text;
                        yeniarac.hasar = textBox4.Text;
                        yeniarac.kapi = comboBox2.Text;
                        yeniarac.klima = comboBox4.Text;
                        yeniarac.koltuk = comboBox1.Text;
                        yeniarac.marka_id = Convert.ToInt32(comboBox6.SelectedValue);
                        yeniarac.model_id = Convert.ToInt32(comboBox7.SelectedValue);
                        yeniarac.vites = comboBox3.Text;
                        yeniarac.yakit = comboBox5.Text;
                        yeniarac.yil = textBox5.Text;
                        yeniarac.plaka = textBox2.Text;

                        if (comboBox8.Text == "Sadece Kaydet")
                            yeniarac.arackullanim = 0;

                        else if (comboBox8.Text == "Arac Kirada")
                            yeniarac.arackullanim = 1;
                        a.araclar.Add(yeniarac);
                        a.SaveChanges();
                        MessageBox.Show(textBox2.Text + " Plakali Arac Kayit Edilmistir");
                        button2.Text = "Kapat";
                        int id = idal();
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();
                        textBox5.Clear();

                        pictureBox1.Image.Save("araclar/" + id + ".png");


                    }
                    catch
                    {
                        MessageBox.Show("Bir Hata Olustu Arac Kayit Eddilemedi");
                    }
                }
                else
                {
                    MessageBox.Show("Bos Alan Birakmayiniz");
                }
            }
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog o = new OpenFileDialog();
                o.Filter = "Png Uzantili dosya(*.png)|*.png";
                o.Title = "Resim Sec";
                o.ShowDialog();

                String yol = o.FileName;
                pictureBox1.Image = Image.FromFile(yol);
            }
            catch { }

        }

        private void aracekle_Load(object sender, EventArgs e)
        {
            markagetir();
            modelgetir();
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            modelgetir();
        }
    }
}
