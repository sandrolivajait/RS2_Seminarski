
using Model.Models;
using System;

namespace Model.Models
{
    public class Grad : BaseEntity
    {

        public string Naziv { get; set; }
        public int PostanskiBroj { get; set; }

        public virtual System.Collections.Generic.List<Narudzba> Narudzba { get; set; }
        public virtual System.Collections.Generic.List<Kupac> Kupac { get; set; }

        public int ZupanijaId { get; set; }
        public virtual Zupanija Zupanija { get; set; }

    }
}