
using System;

namespace Model.Database
{
	public class SmsLog : BaseEntity
	{

		public string Broj { get; set; }
		public string Poruka { get; set; }
		public string Dodatnisadrzaj { get; set; }

	}
}