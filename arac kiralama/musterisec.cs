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
    public partial class musterisec : Form
    {
        public musterisec()
        {
            InitializeComponent();
        }

        private void musterisec_Load(object sender, EventArgs e)
        {
            kirala.kirasecilenmusteri = 0;

            kiraveritabani baglanti = new kiraveritabani();
            var sorgu = from p in baglanti.musteriler
                        select new {p.id,p.isim,TC=p.TC,p.tel };
            dataGridView1.DataSource = sorgu.ToList();


        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            kirala.kirasecilenmusteri =Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kiraveritabani baglanti = new kiraveritabani();
            var sorgu = from p in baglanti.musteriler
                        

                        where p.TC.Contains(textBox1.Text) & p.isim.Contains(textBox2.Text)
                        select new { p.id, p.isim, TC = p.TC, p.tel };
            dataGridView1.DataSource = sorgu.ToList();
        }
    }
}
