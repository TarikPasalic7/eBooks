

namespace eKnjige.Model
{
    public class EKnjigeAutor { 

        public int EKnjigeAutorID { get; set; }

        public int AutorID { get; set; }
        public Autor Autor { get; set; }

      
        public int EKnjigaID { get; set; }

        public EKnjiga EKnjiga { get; set; }
    }
}
