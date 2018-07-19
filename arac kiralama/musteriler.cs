namespace arac_kiralama
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;


    public partial class musteriler :insan
    {
        public int id { get; set; }

        
        //public string isim { get; set; }

        
        //public DateTime d_tarih { get; set; }

        
        public string tel { get; set; }

        
        //public string tc { get; set; }

       
        public string eh_no { get; set; }

        
        public DateTime eh_tarih { get; set; }

        
        public string cinsiyet { get; set; }

      
        public string adres { get; set; }
        public virtual List<kira> kiralar { get; set; }
    }
}
