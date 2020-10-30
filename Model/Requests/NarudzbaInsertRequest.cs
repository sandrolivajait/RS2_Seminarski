using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Requests
{
    public class NarudzbaInsertRequest
    {
        public double UkupnaCijena { get; set; }

        public DateTime Datum { get; set; }


        // 1 = zaprimljeno, 2 = poslano, 3 = zavrseno
        public int StanjeNarudzbeId { get; set; }
      



        public string KontaktTelefon { get; set; }
        


        // koji je kupac narucio ako je kupac bio logiran
        public int KupacId { get; set; }
       
        public string Opcina { get; set; }
        public string Kanton { get; set; }
        public string PostanskiBroj { get; set; }
        public string Ulica { get; set; }

    }
}
