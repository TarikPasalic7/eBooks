


namespace eKnjige.Model
{
    public class EKnjiga
    {


        public int EKnjigaID { get; set; }
        public string Naziv { get; set; }
        public float OcjenaKnjige { get; set; }
        public byte[]  Slika { get; set; }
        public float Cijena { get; set; }
        public string Opis { get; set; }
        public string Mp3file { get; set; }
        public string Pdffile { get; set; }
        public bool MP3Dodan { get; set; }

        public bool PDFDodan { get; set; }


    }
}
