using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Models
{
    public class Narudzba
    {
        public int Id { get; set; }
        public double UkupnaCijena { get; set; }

        public string Datum { get; set; }


       
        public int StanjeNarudzbeId { get; set; }
        public string StanjeOpis { get; set; }

        public string KontaktTelefon { get; set; }

        public int KupacId { get; set; }
        public string ImePrezimeKupca { get; set; }

        public string Opcina { get; set; }
        public string Kanton { get; set; }
        public string PostanskiBroj { get; set; }
        public string Ulica { get; set; }

        public int NarucenoStavki { get; set; }

    }
}
