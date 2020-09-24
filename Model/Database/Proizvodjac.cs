
using System;

namespace Model.Models
{
	public class Proizvodjac : BaseEntity
	{

		public string Naziv { get; set; }


		public virtual System.Collections.Generic.List<Mobiteli> Mobiteli { get; set; }

	}
}