namespace arac_kiralama
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;


    public partial class araclar
    {
        public int id { get; set; }

      
        public string arac_adi { get; set; }

        public int marka_id { get; set; }

        public int model_id { get; set; }

       
        public string yil { get; set; }

        
        public string koltuk { get; set; }

        
        public string kapi { get; set; }

        
        public string klima { get; set; }

        
        public string yakit { get; set; }

       
        public string vites { get; set; }

        
        public string gun_fiyat { get; set; }

        
        public string hasar { get; set; }

       
        public string plaka { get; set; }

        public int arackullanim { get; set; }

        public int arackullanim1 { get; set; }
        public virtual List<kira> kiralar { get; set; }
        public virtual marka marka { get; set; }
    }
   
}
