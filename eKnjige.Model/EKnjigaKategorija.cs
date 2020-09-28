

namespace eKnjige.Model
{
    public class EKnjigaKategorija
    {
        public int EKnjigaKategorijaID { get; set; }


        
        public int EKnjigaID { get; set; }
        public EKnjiga Eknjiga { get; set; }

        
        public int KategorijaID { get; set; }
        public Kategorija Kategorija { get; set; }
    }
}
