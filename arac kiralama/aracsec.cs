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
    public partial class aracsec : Form
    {
        public void markagetir()
        {
            kiraveritabani baglanti = new kiraveritabani();
            var sorgu = from p in baglanti.marka
                        select p;
            comboBox1.ValueMember = "id";
            comboBox1.DisplayMember = "markaadi";
            comboBox1.DataSource = sorgu.ToList();
        }
        public Boolean arackontrol(int id)
        {
            kiraveritabani baglanti = new kiraveritabani();
            var sorgu = from p in baglanti.kira
                        where p.arac_id == id && p.teslim_kontrol == 0
                        select p;
            if (sorgu.Any()) {
                return true;

            }
            else
            {
                return false;
            }

        }
        public void araclargetir()
        {
            kiraveritabani baglanti = new kiraveritabani();
            var sorgu = from p in baglanti.araclar
                        join markaal in baglanti.marka on p.marka_id equals markaal.id
                        join modelal in baglanti.model on p.model_id equals modelal.id
                        orderby p.id ascending
                        where p.arackullanim==1
                        select new { Id = p.id, Plaka = p.plaka.Trim(), Adi = p.arac_adi.Trim(), Marka = markaal.markaadi.Trim(), Model = modelal.modeladi, Kapi = p.kapi.Trim(), Klima = p.klima.Trim(), Koltuk = p.koltuk.Trim(), Vites = p.vites.Trim(), Yakit = p.yakit.Trim(), Yil = p.yil.Trim(),kula=p.arackullanim1 };
            dataGridView1.DataSource =sorgu.ToList();
        }
        public aracsec()
        {
            InitializeComponent();
        }

        private void aracsec_Load(object sender, EventArgs e)
        {
            araclargetir();
            markagetir();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (!arackontrol(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString())))
            {
                kirala.kirasecilenarac = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                this.Close();
            }
            else
            {
                MessageBox.Show("Bu Arac Kiradadir Baska Bir Arac seciniz");
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            if (arackontrol(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString())))
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                renk.BackColor = Color.Red;
                dataGridView1.Rows[dataGridView1.CurrentRow.Index].DefaultCellStyle = renk;
            }
            else
            {
                DataGridViewCellStyle renk = new DataGridViewCellStyle();
                renk.BackColor = Color.White;
                dataGridView1.Rows[dataGridView1.CurrentRow.Index].DefaultCellStyle = renk;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                kiraveritabani baglanti = new kiraveritabani();
                var sorgu = from p in baglanti.araclar
                            join markaal in baglanti.marka on p.marka_id equals markaal.id

                            where markaal.markaadi.Contains(comboBox1.Text) & p.arackullanim == 1
                            select new { Id = p.id, Plaka = p.plaka.Trim(), Adi = p.arac_adi.Trim(), Marka = markaal.markaadi.Trim(), Kapi = p.kapi.Trim(), Klima = p.klima.Trim(), Koltuk = p.koltuk.Trim(), Vites = p.vites.Trim(), Yakit = p.yakit.Trim(), Yil = p.yil.Trim(), kula = p.arackullanim1 };
                dataGridView1.DataSource = sorgu.ToList();
            }
            else
            {
                kiraveritabani baglanti = new kiraveritabani();
                var sorgu = from p in baglanti.araclar
                            join markaal in baglanti.marka on p.marka_id equals markaal.id

                            where p.plaka.Contains(textBox1.Text) & p.arackullanim == 1
                            select new { Id = p.id, Plaka = p.plaka.Trim(), Adi = p.arac_adi.Trim(), Marka = markaal.markaadi.Trim(), Kapi = p.kapi.Trim(), Klima = p.klima.Trim(), Koltuk = p.koltuk.Trim(), Vites = p.vites.Trim(), Yakit = p.yakit.Trim(), Yil = p.yil.Trim(), kula = p.arackullanim1 };
                dataGridView1.DataSource = sorgu.ToList();
            }
        }
    }
}
