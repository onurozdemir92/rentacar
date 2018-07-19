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
    public partial class teslimalinacak : UserControl
    {
        public teslimalinacak()
        {
            InitializeComponent();
        }
        public Image aracresmi
        {
            get { return resim.Image; }
            set { resim.Image = value; }
        }
        public String aracplaka
        {
            get { return plaka.Text; }
            set { plaka.Text = value; }
        }
        public String aracismi
        {
            get { return aracadi.Text; }
            set { aracadi.Text = value; }
        }
        public String musteriismi
        {
            get { return musadi.Text; }
            set { musadi.Text = value; }
        }
        public String musteritel
        {
            get { return mustel.Text; }
            set { mustel.Text = value; }
        }
        public String teslimsaati
        {
            get { return teslims.Text; }
            set { teslims.Text = value; }
        }
    }
    
}
