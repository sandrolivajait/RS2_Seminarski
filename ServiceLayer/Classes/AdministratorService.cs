using AutoMapper;
using Model.Requests;
using RepositoryLayer;
using ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.Classes
{

    public class AdministratorService : IAdministratorService
    {
        private readonly IRepository<Model.Database.Administrator> administratorRepository;
        
        private readonly IMapper mapper;

        public AdministratorService(IRepository<Model.Database.Administrator> administratorRepository, IMapper mapper)
        {
            this.administratorRepository = administratorRepository;
            this.mapper = mapper;
        
        }

        public Model.Models.Administrator GetAdministrator(int id)
        {
            return mapper.Map<Model.Models.Administrator>(administratorRepository.Get(id));
        }

        public IEnumerable<Model.Models.Administrator> GetAll()
        {
            return mapper.Map<IEnumerable<Model.Models.Administrator>>(administratorRepository.GetAll());
        }

        public void Insert(AdministratorInsertRequest request)
        {

            var administrator = mapper.Map<Model.Database.Administrator>(request);
            administratorRepository.Insert(administrator);
        }

        public void Update(int id, AdministratorInsertRequest request)
        {
            var entity = administratorRepository.Get(id);
            mapper.Map(request, entity);
            administratorRepository.Update(entity);
        }
    }
}
