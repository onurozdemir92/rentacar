namespace arac_kiralama
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;

   
    public partial class marka
    {
        public int id { get; set; }

       public string markaadi { get; set; }
        public virtual List<model> modeller { get; set; }
        public virtual List<araclar> araclar { get; set; }


    }
}
