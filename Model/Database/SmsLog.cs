
using System;

namespace Model.Models
{
	public class SmsLog : BaseEntity
	{

		public string Broj { get; set; }
		public string Poruka { get; set; }
		public string Dodatnisadrzaj { get; set; }

	}
}