using RepositoryLayer;
using ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.Models;
using Model.Requests;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace ServiceLayer.Classes
{
    public class NarudzbaService : INarudzbaService
    {
        private readonly IRepository<Model.Database.Narudzba> naruzbaRepository;
        private readonly IRepository<Model.Database.StavkaNarudzbe> stavkeNaruzbaRepository;
        private readonly IMapper mapper;

        public NarudzbaService(IRepository<Model.Database.Narudzba> naruzbaRepository, IRepository<Model.Database.StavkaNarudzbe> stavkeNaruzbaRepository, IMapper mapper)
        {
            this.naruzbaRepository = naruzbaRepository;
            this.stavkeNaruzbaRepository = stavkeNaruzbaRepository;
            this.mapper = mapper;
        }

        public IEnumerable<Narudzba> GetAll()
        {
            return mapper.Map<IEnumerable<Model.Models.Narudzba>>(naruzbaRepository.GetAllQueryable().Include(x => x.StavkaNarudzbe).Include(x => x.Kupac).ToList());
        }

        public Narudzba GetNarudzba(int id)
        {
            return mapper.Map<Model.Models.Narudzba>(naruzbaRepository.GetAllQueryable().Include(x => x.StavkaNarudzbe).Include(x => x.Kupac).FirstOrDefault(x => x.Id == id));
        }

        public void InsertNarudzba(Model.Database.Narudzba narudzba, List<Model.Database.StavkaNarudzbe> stavke)
        {
            int id = naruzbaRepository.InsertAndReturnEntityId(narudzba);
            stavke.ForEach(x => x.NarudzbaId = id);
            stavkeNaruzbaRepository.InsertRange(stavke);
        }

      
    }
}
