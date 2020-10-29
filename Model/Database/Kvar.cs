using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Database
{
    public class Kvar : BaseEntity
    {
        public DateTime DatumKvara { get; set; }
        public string OpisKvara { get; set; }

        // zahtjev poslan, mobitel zaprimljen, mobitel popravljen, mobitel vraćen korisniku
        public int StanjeKvaraId { get; set; }
        public virtual StanjeKvara StanjeKvara { get; set; }

        public string BrojMobitela { get; set; }

        public string NazivMobitela { get; set; }

        public int KupacId { get; set; }
        public virtual Kupac Kupac { get; set; }
    }

}
