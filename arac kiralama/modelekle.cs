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
    public partial class modelekle : UserControl
    {
        public Boolean modelkontrol(int id,string model)
        {
            kiraveritabani a = new kiraveritabani();
            var sorgu = from p in a.model
                        where p.marka_id==id&p.modeladi==model
                        select p;
            if (sorgu.Any())
                return true;
            else
                return false;


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
        public void modelgetir(int id)
        {
            kiraveritabani a = new kiraveritabani();
            var sorgu = from p in a.model
                        where p.marka_id==id 
                        select new {p.id, p.modeladi, };
            dataGridView1.DataSource = sorgu.ToList();

        }
        public modelekle()
        {
            InitializeComponent();
        }

        private void modelekle_Load(object sender, EventArgs e)
        {
            markagetir();
            modelgetir(Convert.ToInt32(comboBox1.SelectedValue));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "" && textBox1.Text != "")
            {
                if (modelkontrol(Convert.ToInt32(comboBox1.SelectedValue), textBox1.Text))
                {
                    MessageBox.Show("Bu Model Bulunmaktadır");
                }
                else
                {
                    try
                    {
                        kiraveritabani baglanti = new kiraveritabani();
                        model m = new model();
                        m.marka_id = Convert.ToInt32(comboBox1.SelectedValue);
                        m.modeladi = textBox1.Text;
                        baglanti.model.Add(m);
                        baglanti.SaveChanges();
                        modelgetir(Convert.ToInt32(comboBox1.SelectedValue));
                    }
                    catch
                    {
                        MessageBox.Show("Model Kayit edilirken bir hata olustu");
                    }
                }
            }
            else
            {
                MessageBox.Show("Bos Alan Birakmayin");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            modelgetir(Convert.ToInt32(comboBox1.SelectedValue));
        }
    }
}
