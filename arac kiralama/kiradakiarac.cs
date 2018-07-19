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
    public partial class kiradakiarac : UserControl
    {
        public kiradakiarac()
        {
            InitializeComponent();
        }
        public String aracismi
        {
            get { return aracadi.Text; }
            set { aracadi.Text = value; }
        }
        public String aracplaka
        {
            get { return plaka.Text; }
            set { plaka.Text = value; }
        }
        public String musteriadi
        {
            get { return musadi.Text; }
            set { musadi.Text = value; }
        }
        public String musteritel
        {
            get { return mustel.Text; }
            set { mustel.Text = value; }
        }
        public Image aracresim
        {
            get { return aracresmi.Image; }
            set { aracresmi.Image = value; }
        }
        public String teslimtarihi
        {
            get { return teslimt.Text; }
            set { teslimt.Text = value; }
        }
        public String teslimsaat
        {
            get { return teslims.Text; }
            set { teslims.Text = value; }
        }
    }
}
