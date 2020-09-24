
using System;
namespace Model.Models
{
	public class StavkaNarudzbe : BaseEntity
	{

		public int Kolicina { get; set; }
		public double Cijena { get; set; }

		public int MobitelId { get; set; }
		public virtual Mobiteli Mobitel { get; set; }

		public int NarudzbaId { get; set; }
		public virtual Narudzba Narudzba { get; set; }

	}
}
