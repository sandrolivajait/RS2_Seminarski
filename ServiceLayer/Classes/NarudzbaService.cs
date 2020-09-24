using RepositoryLayer;
using ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.Models;

namespace ServiceLayer.Classes
{
    public class NarudzbaService : INarudzbaService
    {
        private readonly IRepository<Narudzba> naruzbaRepository;
        private readonly IRepository<StavkaNarudzbe> stavkeNaruzbaRepository;

        public NarudzbaService(IRepository<Narudzba> naruzbaRepository, IRepository<StavkaNarudzbe> stavkeNaruzbaRepository)
        {
            this.naruzbaRepository = naruzbaRepository;
            this.stavkeNaruzbaRepository = stavkeNaruzbaRepository;
        }

     


        public void InsertNarudzba(Narudzba narudzba, List<StavkaNarudzbe> stavke)
        {
            int id = naruzbaRepository.InsertAndReturnEntityId(narudzba);
            stavke.ForEach(x => x.NarudzbaId = id);
            stavkeNaruzbaRepository.InsertRange(stavke);
        }
    }
}
