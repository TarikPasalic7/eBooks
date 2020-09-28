using System;


namespace eKnjige.Model
{
    public class KomentarRequest
    {
        public int KomentarId { get; set; }

        public string komentar  { get; set; }

       public  DateTime DatumKomentara { get; set; }

        public Klijent Klijent { get; set; }
        public int KlijentID { get; set; }
        

        
        public int EKnjigaID { get; set; }
      

    }
}
