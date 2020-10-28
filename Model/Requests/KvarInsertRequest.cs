using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Requests
{
    public class KvarInsertRequest
    {
        public DateTime DatumKvara { get; set; }
        public string OpisKvara { get; set; }

        // zahtjev poslan, mobitel zaprimljen, mobitel popravljen, mobitel vraćen korisniku
        public int StanjeKvara { get; set; }
        public string BrojMobitela { get; set; }

        public string NazivMobitela { get; set; }

        public int KupacId { get; set; }

    }
}
