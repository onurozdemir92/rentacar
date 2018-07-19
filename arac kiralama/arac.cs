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
    public partial class arac : Form
    {
        public static int secilenid=0;
        public void arama()
        {
            kiraveritabani baglanti = new kiraveritabani();
            var sorgu=from p in baglanti.araclar
                      join markaal in baglanti.marka on p.marka_id equals markaal.id
                      join modelal in baglanti.model on p.model_id equals modelal.id
                      where markaal.markaadi.Contains(comboBox1.Text)&p.plaka.Contains(textBox1.Text)
                      select new { Id = p.id, Plaka = p.plaka.Trim(), Adi = p.arac_adi.Trim(), Marka = markaal.markaadi, Model = modelal.modeladi, Kapi = p.kapi.Trim(), Klima = p.klima.Trim(), Koltuk = p.koltuk.Trim(), Vites = p.vites.Trim(), Yakit = p.yakit.Trim(), Yil = p.yil.Trim() };
            dataGridView1.DataSource = sorgu.ToList();



        }
        public void markagetir()
        {
            kiraveritabani a = new kiraveritabani();
            var sorgu = from p in a.marka
                        select new { p.id, adi = p.markaadi.Trim(), };
            comboBox1.ValueMember = "id";
            comboBox1.DisplayMember = "adi";
            comboBox1.DataSource = sorgu.ToList();

        }
        public void araclargetir()
        {
            kiraveritabani baglanti = new kiraveritabani();
            var sorgu = from p in baglanti.araclar
                        join markaal in baglanti.marka on p.marka_id equals markaal.id 
                        join modelal in baglanti.model on p.model_id equals modelal.id
                        orderby p.id ascending
                        select new {Id=p.id, Plaka=p.plaka.Trim(),Adi=p.arac_adi.Trim(), Marka = markaal.markaadi.Trim(),Model=modelal.modeladi, Kapi = p.kapi.Trim(), Klima=p.klima.Trim(), Koltuk=p.koltuk.Trim(), Vites=p.vites.Trim(), Yakit=p.yakit.Trim(), Yil=p.yil.Trim() };
            dataGridView1.DataSource = sorgu.ToList();
        }
        public arac()
        {
            InitializeComponent();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void arac_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;

            araclargetir();
            markagetir();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            aracekle a = new aracekle();
            a.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = true;
            secilenid =Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            label7.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            label8.Text= dataGridView1.CurrentRow.Cells[2].Value.ToString();
            label9.Text= dataGridView1.CurrentRow.Cells[10].Value.ToString();
            label4.Text= dataGridView1.CurrentRow.Cells[7].Value.ToString();
            label1.Text= dataGridView1.CurrentRow.Cells[5].Value.ToString();
            label2.Text= dataGridView1.CurrentRow.Cells[8].Value.ToString();
            label3.Text= dataGridView1.CurrentRow.Cells[6].Value.ToString();
            label5.Text=dataGridView1.CurrentRow.Cells[9].Value.ToString();
            try
            {
                pictureBox1.Image = Image.FromFile("araclar/" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + ".png");
            }
            catch
            {
                MessageBox.Show("Arac Resmi Yuklenemedi");
                pictureBox1.Image = null;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            arama();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            araclargetir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            aracduzenle a = new aracduzenle();
            a.ShowDialog();
        }
    }
}
