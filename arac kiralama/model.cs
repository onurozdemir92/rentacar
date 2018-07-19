namespace arac_kiralama
{
    using System;
    using System.Data.Entity;
    using System.Linq;

   
    public partial class model
    {
        public int id { get; set; }

        public int marka_id { get; set; }

       
        public string modeladi { get; set; }
        public virtual marka marka { get; set; }
    }
}
