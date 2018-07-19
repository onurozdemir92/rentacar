using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arac_kiralama
{
    public partial class markaekle : UserControl
    {
        public Boolean markakontrol(string marka)
        {
            kiraveritabani baglanti = new kiraveritabani();
            var sorgu = from p in baglanti.marka
                        where p.markaadi==marka
                        select p;
            if (sorgu.Any())
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public void markagetir()
        {
            kiraveritabani baglanti = new kiraveritabani();
            var sorgu = from p in baglanti.marka
                        select p;
            dataGridView1.DataSource = sorgu.ToList();
        }
        public markaekle()
        {
            InitializeComponent();
        }

        private void markaekle_Load(object sender, EventArgs e)
        {
            markagetir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
                if (textBox1.Text != "")
                {
                if (markakontrol(textBox1.Text))
                {
                    MessageBox.Show("Bu marka Kayıtlıdır");
                }
                else
                {
                    try
                    {
                        kiraveritabani baglanti = new kiraveritabani();
                        marka m = new marka();
                        m.markaadi = textBox1.Text;
                        baglanti.marka.Add(m);
                        baglanti.SaveChanges();
                        markagetir();
                    }
                    catch
                    {
                        MessageBox.Show("Marka Kayit edilirken bir hata olustu");
                    }
                }
                }
                else
                {
                    MessageBox.Show("Bos Alan Birakmayiniz");
                }
            

        }
    }
}
