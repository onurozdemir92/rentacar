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
    public partial class bugun : Form
    {
        int secilenkira = 0;
        public void kiragetir()
        {
            DateTimePicker tarih = new DateTimePicker();
            tarih.CustomFormat = "dd.MM.yyyy";
            tarih.Text = DateTime.Today.ToString("dd.MM.yyyy");
            kiraveritabani baglanti = new kiraveritabani();
            var sorgu = from p in baglanti.kira
                        join plakaal in baglanti.araclar on p.arac_id equals plakaal.id
                        join mustc in baglanti.musteriler on p.mus_id equals mustc.id

                        where p.teslim_kontrol == 0& p.teslim_tarih==tarih.Value
                        select new { ID = p.id, TC = mustc.TC, ISIM = mustc.isim, ARACPLAKA = plakaal.plaka, TESLIMTARIHI = p.teslim_tarih, ALISTARIHI = p.alis_tarih };
            dataGridView1.DataSource = sorgu.ToList();



        }
        public bugun()
        {
            InitializeComponent();
        }

        private void bugun_Load(object sender, EventArgs e)
        {
            kiragetir();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (secilenkira != 0)
            {
                try
                {
                    kiraveritabani baglanti = new kiraveritabani();
                    var sorgu = from p in baglanti.kira
                                where p.id == secilenkira
                                select p;
                    foreach (var duzenle in sorgu)
                    {
                        duzenle.teslim_kontrol = 1;


                    }
                    baglanti.SaveChanges();



                    MessageBox.Show("Teslim Alindi");
                    kiragetir();
                    secilenkira = 0;

                }
                catch
                {
                    MessageBox.Show("Teslim Alinirken Bir hata Olustu");
                }

            }
            else
            {
                MessageBox.Show("Bir Secim Yapiniz");
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            secilenkira = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
        }
    }
}
