using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arac_kiralama
{
  abstract public class insan
    {

        public string isim { get; set; }


        //public string tc
        //{
        //    get { return tc; }


        //    set { if (value != null) { if (value.Length != 11) { } else { tc = value; } } else { tc = ""; } }
        //}
        private string tc;
        public string TC
        {
            get { return this.tc; }
            set
            {
                if (value != null)
                {
                    if (value.Length != 11)
                    {
                        throw new Exception("TC no 11 haneli olmalıdır");

                    }
                    else
                    {
                        tc = value;
                    }
                }
            }
        }
          
        
        //public string gettc()
        //{
        //    return this.tc;
        //}
        //public void settc(string value)
        //{
        //    if (value != null)
        //    {
        //        if (value.Length != 11)
        //        {
        //            throw new Exception("Hata");

            //        }
            //        else
            //        {
            //            tc = value;
            //        }
            //    }
            //}

        public DateTime d_tarih { get; set; }
    }
}
