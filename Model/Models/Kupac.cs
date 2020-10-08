using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Models
{
    public class Kupac
    {
		public int Id { get; set; }
		public string Ime { get; set; }
		public string Prezime { get; set; }
		public string Email { get; set; }
		public string BrojMobitela { get; set; }

		public int GradId { get; set; }
		public string Grad { get; set; }
	}
}
