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
    public partial class kiragecmis : Form
    {
        public kiragecmis()
        {
            InitializeComponent();
        }
        public void getirgecmis()
        {
            kiraveritabani baglanti = new kiraveritabani();
            var sorgu = from p in baglanti.kira
                        join plakaal in baglanti.araclar on p.arac_id equals plakaal.id
                        join mustc in baglanti.musteriler on p.mus_id equals mustc.id

                        where p.teslim_kontrol == 1
                        select new { ID = p.id, TC = mustc.TC, ISIM = mustc.isim, ARACPLAKA = plakaal.plaka, TESLIMTARIHI = p.teslim_tarih, ALISTARIHI = p.alis_tarih };
            dataGridView1.DataSource = sorgu.ToList();

                      

        }

        private void kiragecmis_Load(object sender, EventArgs e)
        {

            getirgecmis();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                kiraveritabani baglanti = new kiraveritabani();
                var sorgu = from p in baglanti.kira
                            join plakaal in baglanti.araclar on p.arac_id equals plakaal.id
                            join mustc in baglanti.musteriler on p.mus_id equals mustc.id

                            where p.teslim_kontrol == 1 & p.teslim_tarih>dateTimePicker2.Value & p.teslim_tarih<dateTimePicker3.Value
                            select new { ID = p.id, TC = mustc.TC, ISIM = mustc.isim, ARACPLAKA = plakaal.plaka, TESLIMTARIHI = p.teslim_tarih, ALISTARIHI = p.alis_tarih };
                dataGridView1.DataSource = sorgu.ToList();
            }
            else
            {
                kiraveritabani baglanti = new kiraveritabani();
                var sorgu = from p in baglanti.kira
                            join plakaal in baglanti.araclar on p.arac_id equals plakaal.id
                            join mustc in baglanti.musteriler on p.mus_id equals mustc.id

                            where p.teslim_kontrol == 1 & plakaal.plaka.Contains(textBox1.Text) & mustc.TC.Contains(textBox2.Text) & p.teslim_tarih == dateTimePicker1.Value
                            select new { ID = p.id, TC = mustc.TC, ISIM = mustc.isim, ARACPLAKA = plakaal.plaka, TESLIMTARIHI = p.teslim_tarih, ALISTARIHI = p.alis_tarih };
                dataGridView1.DataSource = sorgu.ToList();
            }
        }
    }
}
