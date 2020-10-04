using Model.Database;
using RepositoryLayer;
using ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiceLayer.Classes
{
    public class OperativniSustavService : IOperativniSustaviService
    {
        private readonly IRepository<OperativniSustav> operativniSustavRepository;

        public OperativniSustavService(IRepository<OperativniSustav> operativniSustavRepository)
        {
            this.operativniSustavRepository = operativniSustavRepository;
        }

        public IEnumerable<OperativniSustav> GetOperativniSustavi()
        {
            return operativniSustavRepository.GetAllQueryable().OrderBy(x => x.Naziv).ToList();
        }
    }
}
