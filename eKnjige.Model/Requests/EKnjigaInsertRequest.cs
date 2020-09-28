using System;
using System.Collections.Generic;
using System.Text;

namespace eKnjige.Model.Requests
{
   public class EKnjigaInsertRequest
    {
        
        public string Naziv { get; set; }
        public float OcjenaKnjige { get; set; }
        public byte[] Slika { get; set; }
        public float Cijena { get; set; }
        public string Mp3file { get; set; }
        public string Pdffile { get; set; }
        public string Opis { get; set; }

        public bool MP3Dodan { get; set; }

        public bool PDFDodan { get; set; }
        public int AdministratorID { get; set; }


    }
}
