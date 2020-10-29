using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Model.Database;
using Model.Models;
using Model.Requests;
using RepositoryLayer;
using ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiceLayer.Classes
{
    public class KvarService : IKvarService
    {
        private readonly IRepository<Model.Database.Kvar> kvarRepository;
        private readonly IRepository<Model.Database.StanjeKvara> stanjeKvaraRepository;
        private readonly IMapper mapper;

        public KvarService(IRepository<Model.Database.Kvar> kvarRepository, IRepository<Model.Database.StanjeKvara> stanjeKvaraRepository,  IMapper mapper)
        {
            this.kvarRepository = kvarRepository;
            this.stanjeKvaraRepository = stanjeKvaraRepository;
            this.mapper = mapper;
        }

        public IEnumerable<Model.Models.Kvar> Get()
        {
            return mapper.Map<IEnumerable<Model.Database.Kvar>, IEnumerable<Model.Models.Kvar>>(kvarRepository.GetAllQueryable().Include(x => x.Kupac).Include(x => x.StanjeKvara).OrderByDescending(x => x.DatumKvara).ToList());

        }

        public IEnumerable<Model.Database.StanjeKvara> GetStanjaKvara()
        {
            return stanjeKvaraRepository.GetAll().OrderBy(x => x.Id).ToList();
        }

        public Model.Models.Kvar Get(int id)
        {
            return mapper.Map<Model.Database.Kvar, Model.Models.Kvar>(kvarRepository.GetAllQueryable().Include(x => x.Kupac).FirstOrDefault(x => x.Id == id));

        }

        public void Insert(KvarInsertRequest request)
        {
            var kvar = mapper.Map<Model.Database.Kvar>(request);
            kvarRepository.Insert(kvar);
        }

        public void Update(int id, KvarInsertRequest request)
        {
            var entity = kvarRepository.Get(id);
            mapper.Map(request, entity);
            kvarRepository.Update(entity);
        }
    }
}
