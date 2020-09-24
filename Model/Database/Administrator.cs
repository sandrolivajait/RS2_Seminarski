using Model;
using System;

namespace Model.Models
{
	public class Administrator : BaseEntity
	{

		public string Email { get; set; }
		public bool IsSuperAdmin { get; set; }
		public string Ime { get; set; }
		public string Prezime { get; set; }

	}
}