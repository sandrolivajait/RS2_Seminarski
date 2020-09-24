using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Requests
{
    public class MobiteliSearchRequest
    {
        public string Naziv { get; set; }
        public int? ProizvodjacId { get; set; }

        public int? CijenaOd { get; set; }
        public int? CijenaDo { get; set; }
    }
}
