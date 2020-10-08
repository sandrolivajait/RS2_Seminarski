using RepositoryLayer;
using ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.Models;
using AutoMapper;
using System.Security.Cryptography.X509Certificates;
using Model.Requests;
using Microsoft.EntityFrameworkCore;

namespace ServiceLayer.Classes
{
    public class KupacService : IKupacService
    {
        private readonly IRepository<Model.Database.Kupac> kupacRepository;
        private readonly IMapper mapper;
        public KupacService(IRepository<Model.Database.Kupac> kupacRepository, IMapper mapper)
        {
            this.kupacRepository = kupacRepository;
            this.mapper = mapper;
        }

        public IEnumerable<Kupac> GetAll()
        {
            return mapper.Map<IEnumerable<Model.Database.Kupac>, IEnumerable<Kupac>>(kupacRepository.GetAllQueryable().Include(x => x.Grad).ToList());
        }

        public Kupac GetKupac(int id)
        {
            return mapper.Map<Model.Database.Kupac,Kupac>(kupacRepository.GetAllQueryable().Include(x => x.Grad).FirstOrDefault(x => x.Id == id));
        }

      
        public void InsertKupac(KupacInsertRequest request)
        {
            var kupac = mapper.Map<Model.Database.Kupac>(request);
            kupacRepository.Insert(kupac);
        }

        public void Update(int id, KupacInsertRequest request)
        {
            var entity = kupacRepository.Get(id);
            mapper.Map(request, entity);
            kupacRepository.Update(entity);
        }
    }
}
