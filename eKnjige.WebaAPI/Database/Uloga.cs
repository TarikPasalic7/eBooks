using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eKnjige.WebaAPI.Database
{
    public class Uloga
    {

        [Key]
        public int UlogaId { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
    }
}
