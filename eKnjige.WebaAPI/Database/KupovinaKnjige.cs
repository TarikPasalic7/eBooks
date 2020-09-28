using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eKnjige.WebaAPI
{
    public class KupovinaKnjige
    {
        [Key]
        public int KupovinaKnjigeID { get; set; }
        public DateTime DatumKupovine { get; set; }


       
       

        public Klijent Klijent { get; set; }
        public int KlijentID { get; set; }


        [ForeignKey("EKnjiga")]
        public int EKnjigaID { get; set; }

        public EKnjiga EKnjiga { get; set; }

       
    }
}
