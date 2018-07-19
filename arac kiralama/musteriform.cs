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
    public partial class musteriform : Form
    {
        public static int secilenmusteri=0;
        public void arama()
        {
            kiraveritabani baglanti = new kiraveritabani();
            var sorgu = from p in baglanti.musteriler
                        
                        where p.TC.Contains(textBox2.Text) & p.isim.Contains(textBox3.Text)
                        select new { ID = p.id, TC = p.TC.Trim(), Isim = p.isim.Trim(), TEL = p.tel.Trim(), DogumTarihi = p.d_tarih, Cinsiyet = p.cinsiyet.Trim(), EkliyetNo = p.eh_no.Trim(), EhliyetTarihi = p.eh_tarih, Adres = p.adres.Trim() };
            dataGridView1.DataSource = sorgu.ToList();



        }
        public void musterigetir()
        {
            kiraveritabani baglanti = new kiraveritabani();
            var sorgu = from p in baglanti.musteriler
                        select new {ID=p.id,tc=p.TC.Trim(),Isim=p.isim.Trim(), TEL=p.tel.Trim(), DogumTarihi=p.d_tarih, Cinsiyet=p.cinsiyet.Trim(), EkliyetNo=p.eh_no.Trim(), EhliyetTarihi=p.eh_tarih, Adres=p.adres.Trim() };
            dataGridView1.DataSource = sorgu.ToList();
        }
        public musteriform()
        {
            InitializeComponent();
        }

        private void musteriform_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            musterigetir();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            arama();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            musterigetir();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
           
            panel1.Visible = true ;
            secilenmusteri = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            ibisim.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            lbtc.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            lbtel.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
          
            lbcinsiyet.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            lbehno.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            
            tbadres.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();





        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            musteriekle m = new musteriekle();
            m.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            musteriyiduzenle me = new musteriyiduzenle();
            me.ShowDialog();
        }
    }
}
