

using System.ComponentModel.DataAnnotations;

namespace eKnjige.WebaAPI
{
    public class Kategorija
    {


        [Key]
        public int KategorijaID { get; set; }
        public string Naziv { get; set; }
    }
}
