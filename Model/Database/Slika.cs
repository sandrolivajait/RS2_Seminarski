
using System;
namespace Model.Models
{
	public class Slika : BaseEntity
	{

		public byte[] SlikaFull { get; set; }
		public byte[] SlikaThumb { get; set; }

		public int Order { get; set; }


		public int MobitelId { get; set; }
		public virtual Mobiteli Mobitel { get; set; }

	}
}