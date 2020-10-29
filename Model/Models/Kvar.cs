using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Models
{
    public class Kvar
    {
        public int Id { get; set; }
        public DateTime DatumKvara { get; set; }
        public string OpisKvara { get; set; }

        
        public int StanjeKvaraId { get; set; }

        public string NazivMobitela { get; set; }
        public string BrojMobitela { get; set; }

        public string ImeKupca { get; set; }
        public int KupacId { get; set; }
        
    }
}
