namespace arac_kiralama
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;


    public partial class kullanici : insan
    {

        public int id { get; set; }


        public string kullanici_adi { get; set; }
        public string sifre { get; set; }
        public string durum { get; set; }
        public virtual List<kullanici> kullanicilar { get; set; } 



        public kullanici()
        {
            this.kullanici_adi = null;
            this.sifre = null;
            this.isim = null;
           
            this.TC=null;

        }

        
      
        public kullanici(string kullanici,string sifre)
        {
            this.kullanici_adi = kullanici;
            this.sifre = sifre;
        }
        public kullanici(string kullanici, string sifre,string ad,DateTime dtarih,string tc,string durum)
        {
            kiraveritabani bag = new kiraveritabani();
            this.kullanici_adi = kullanici;
            this.sifre = sifre;
            this.isim = ad;
            this.d_tarih = dtarih;
            this.TC=tc;
            this.durum = durum;
            bag.kullanici.Add(this);
            bag.SaveChanges();
            
        }
        public static Boolean kullanicikontrol(string kadi)
        {
            kiraveritabani baglanti = new kiraveritabani();
            var sorgu = from p in baglanti.kullanici
                        where p.kullanici_adi == kadi & p.durum=="1"
                        select p;
            if (sorgu.Any())
                return true;
            else
                return false;
        }
   
    }
 
}
  