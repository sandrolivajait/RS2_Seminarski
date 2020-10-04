using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model.Requests
{
    public class MobiteliInsertRequest
    {
		[Required(ErrorMessage = "Morate unijeti ovo polje")]
		public string Naziv { get; set; }

		[Required(ErrorMessage = "Morate unijeti ovo polje")]
		public string Opis { get; set; }
		[Required(ErrorMessage = "Morate unijeti ovo polje")]
		public string KratkiOpis { get; set; }
		[Required(ErrorMessage = "Morate unijeti ovo polje")]
		public float Megapikseli { get; set; }
		[Required(ErrorMessage = "Morate unijeti ovo polje")]
		public float Ram_Gb { get; set; }

		public int StanjeNaSkladistu { get; set; }

		[Required(ErrorMessage = "Morate unijeti ovo polje")]
		public bool EksternaMemorija { get; set; }

		[Required(ErrorMessage = "Morate unijeti ovo polje")]
		public double Cijena { get; set; }

		[Required(ErrorMessage = "Morate unijeti ovo polje")]
		public int KapacitetBaterije { get; set; }

		[Required(ErrorMessage = "Morate unijeti ovo polje")]
		public int Tezina { get; set; }

		[Required(ErrorMessage = "Morate unijeti ovo polje")]
		public string Rezolucija { get; set; }

		[Required(ErrorMessage = "Morate unijeti ovo polje")]
		public float DijagonalaEkrana { get; set; }

		[Required(ErrorMessage = "Morate unijeti ovo polje")]
		public string Procesor { get; set; }

		[Required(ErrorMessage = "Morate unijeti ovo polje")]
		public string Graficka { get; set; }

		public byte[] Slika { get; set; }
		public byte[] SlikaThumb { get; set; }

		[Required(ErrorMessage = "Morate unijeti ovo polje")]
		public int OperativniSustavId { get; set; }

		[Required(ErrorMessage = "Morate unijeti ovo polje")]
		public int PopustId { get; set; }

		[Required(ErrorMessage = "Morate unijeti ovo polje")]
		public int ProizvodjacId { get; set; }
	}
}
