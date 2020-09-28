using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eKnjige.WebaAPI
{
    public class KlijentKnjigaOcjena
    {
        [Key]
        public int KlijentKnjigaOcijenaID { get; set; }

        public DateTime DatumOcijene { get; set; }

        public float Ocjena { get; set; }

    
        

        public Klijent Klijent { get; set; }

        public int KlijentID { get; set; }

        [ForeignKey("EKnjiga")]

        public int EKnjigaID { get; set; }

        public EKnjiga Eknjiga { get; set; }

    }
}
