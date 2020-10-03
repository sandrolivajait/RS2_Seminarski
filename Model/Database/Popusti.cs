using Model;
using Model.Models;
using System;

namespace Model.Database
{
	public class Popusti : BaseEntity
	{

		public DateTime DatumOd { get; set; }
		public DateTime DatumDo { get; set; }
		public float PostotakPopusta { get; set; }

		public System.Collections.Generic.List<Mobiteli> Mobiteli;

	}
}