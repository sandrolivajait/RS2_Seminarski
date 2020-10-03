using RepositoryLayer;
using ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.Database;

namespace ServiceLayer.Classes
{
    public class ProizvodjacService : IProizvodjacService
    {
        private readonly IRepository<Proizvodjac> proizvodjacRepository;

        public ProizvodjacService(IRepository<Proizvodjac> gradRepository)
        {
            this.proizvodjacRepository = gradRepository;
        }
        public Proizvodjac Get(int id)
        {
            return proizvodjacRepository.Get(id);
        }

        public IEnumerable<Proizvodjac> GetProizvodjaci()
        {
            return proizvodjacRepository.GetAllQueryable().OrderBy(x => x.Naziv).ToList();
        }
    }
}
