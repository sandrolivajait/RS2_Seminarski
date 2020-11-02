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
        private readonly IRepository<Model.Database.StanjeNarudzbe> stanjeNarudzbaRepository;
        private readonly IMapper mapper;

        public NarudzbaService(IRepository<Model.Database.Narudzba> naruzbaRepository, IRepository<Model.Database.StanjeNarudzbe> stanjeRepository, IRepository<Model.Database.StavkaNarudzbe> stavkeNaruzbaRepository, IMapper mapper)
        {
            this.naruzbaRepository = naruzbaRepository;
            this.stavkeNaruzbaRepository = stavkeNaruzbaRepository;
            this.stanjeNarudzbaRepository = stanjeRepository;
            this.mapper = mapper;
        }

        public IEnumerable<Narudzba> GetAll()
        {
            return mapper.Map<IEnumerable<Model.Models.Narudzba>>(naruzbaRepository.GetAllQueryable().Include(x => x.StanjeNarudzbe).Include(x => x.StavkaNarudzbe).Include(x => x.Kupac).ToList());
        }

        public Narudzba GetNarudzba(int id)
        {
            return mapper.Map<Model.Models.Narudzba>(naruzbaRepository.GetAllQueryable().Include(x => x.StanjeNarudzbe).Include(x => x.StavkaNarudzbe).Include(x => x.Kupac).FirstOrDefault(x => x.Id == id));
        }

        public IEnumerable<Model.Database.StanjeNarudzbe> GetStanjaNarudzbi()
        {
            return stanjeNarudzbaRepository.GetAll();
        }

        public void Insert(NarudzbaInsertRequest request)
        {
            var narudzba = mapper.Map<Model.Database.Narudzba>(request);
            naruzbaRepository.Insert(narudzba);
        }

        public void InsertNarudzba(Model.Database.Narudzba narudzba, List<Model.Database.StavkaNarudzbe> stavke)
        {
            int id = naruzbaRepository.InsertAndReturnEntityId(narudzba);
            stavke.ForEach(x => x.NarudzbaId = id);
            stavkeNaruzbaRepository.InsertRange(stavke);
        }

        public void Update(int id, NarudzbaInsertRequest request)
        {
            var entity = naruzbaRepository.Get(id);
            mapper.Map(request, entity);
            naruzbaRepository.Update(entity);
        }
    }
}
