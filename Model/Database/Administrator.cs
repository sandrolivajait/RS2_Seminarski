using Model;
using System;

namespace Model.Database
{
	public class Administrator : BaseEntity
	{

		public string Email { get; set; }
		public string Ime { get; set; }
		public string Prezime { get; set; }

		public string LozinkaHash { get; set; }
		public string LozinkaSalt { get; set; }

	}
}