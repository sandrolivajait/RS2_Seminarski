
using System;
namespace Model.Database
{
	public class Zupanija : BaseEntity
	{

		public string Naziv { get; set; }

		public virtual System.Collections.Generic.List<Grad> Grad { get; set; }

	}
}