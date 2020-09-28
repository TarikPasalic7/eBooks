using System;
using System.Collections.Generic;
using System.Text;

namespace eKnjige.Model.Requests
{
   public  class KlijentiSearchRequest
    {


        public int?  KlijentID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }

        public int GradID { get; set; }
    }
}
