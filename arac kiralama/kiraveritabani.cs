namespace arac_kiralama
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class kiraveritabani : DbContext
    {
     
        public kiraveritabani()
          
        {
        }
        public virtual DbSet<araclar> araclar { get; set; }
        public virtual DbSet<kira> kira { get; set; }
        public virtual DbSet<kullanici> kullanici { get; set; }
        public virtual DbSet<marka> marka { get; set; }
        public virtual DbSet<model> model { get; set; }
        public virtual DbSet<musteriler> musteriler { get; set; }
        


    }



}