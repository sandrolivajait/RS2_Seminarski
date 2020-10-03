using RepositoryLayer;
using ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Model.Database;

namespace ServiceLayer
{
    public class GradoviService : IGradoviService
    {
        private readonly IRepository<Grad> gradRepository;

        public GradoviService(IRepository<Grad> gradRepository)
        {
            this.gradRepository = gradRepository;
        }
        public Grad GetGrad(int id)
        {
            return gradRepository.Get(id);
        }

        public IEnumerable<Grad> GetGradovi()
        {
            return gradRepository.GetAll();
        }
    }
}
