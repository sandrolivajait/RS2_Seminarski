﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Models
{
    public class Mobiteli
    {
		public int Id { get; set; }
		public string Naziv { get; set; }

		public string Opis { get; set; }
		public string KratkiOpis { get; set; }
		public float Megapikseli { get; set; }
		public float Ram_Gb { get; set; }
		public int StanjeNaSkladistu { get; set; }
		public bool EksternaMemorija { get; set; }
		public double Cijena { get; set; }
		public int KapacitetBaterije { get; set; }
		public int Tezina { get; set; }
		public string Rezolucija { get; set; }
		public float DijagonalaEkrana { get; set; }
		public string Procesor { get; set; }
		public string Graficka { get; set; }
		public bool IsDeleted { get; set; }


		public byte[] Slika { get; set; }
		public byte[] SlikaThumb { get; set; }
		
		

		public int ProizvodjacId { get; set; }
		public string Prozivodjac { get; set; }
		public int? OperativniSustavId { get; set; }
		public string OperativniSustav { get; set; }
		public int? PopustId{ get; set; }

		public float? KolicinaPopustaDecimalni { get; set; }
		
		public int ProdanoKomada { get; set; }
	}
}
