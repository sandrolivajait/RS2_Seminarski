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
        private readonly IMapper mapper;

        public KvarService(IRepository<Model.Database.Kvar> kvarRepository,  IMapper mapper)
        {
            this.kvarRepository = kvarRepository;
            this.mapper = mapper;
        }

        public IEnumerable<Model.Models.Kvar> Get()
        {
            return mapper.Map<IEnumerable<Model.Database.Kvar>, IEnumerable<Model.Models.Kvar>>(kvarRepository.GetAllQueryable().Include(x => x.Kupac).ToList());

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
