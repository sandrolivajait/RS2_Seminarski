
using Model.Models;
using System;
namespace Model.Database
{
	public class Kupac : BaseEntity
	{

		public string Ime { get; set; }
		public string Prezime { get; set; }
		public string Email { get; set; }
		public int BrojPokusaja { get; set; }
		public DateTime DatumPokusaja { get; set; }
		public string BrojMobitela { get; set; }

		public virtual System.Collections.Generic.List<Narudzba> Narudzba { get; set; }

	
		public string LozinkaHash { get; set; }
		public string LozinkaSalt { get; set; }

		public int GradId { get; set; }
		public virtual Grad Grad { get; set; }



	

	}
}
