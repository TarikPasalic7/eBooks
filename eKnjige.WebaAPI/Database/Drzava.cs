

using System.ComponentModel.DataAnnotations;

namespace eKnjige.WebaAPI
{
    public class Drzava
    {

        [Key]
        public int DrzavaID { get; set; }
        public string Naziv { get; set; }
    }
}
