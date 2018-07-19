namespace arac_kiralama
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    
    public partial class kira
    {
        public int id { get; set; }

        public int arac_id { get; set; }

        public int mus_id { get; set; }

        public int kul_id { get; set; }

       
        public DateTime alis_tarih { get; set; }

     
        public string alis_saat { get; set; }

        
        public DateTime teslim_tarih { get; set; }

        
        public string teslim_saat { get; set; }

        public int teslim_kontrol { get; set; }

       
        public string odenecek_tutar { get; set; }

        
        public string odeme_turu { get; set; }
        public virtual araclar araclar { get; set; } 
        public virtual musteriler musteriler { get; set; }
        public virtual kullanici kullanicilar { get; set; }
    }
}
