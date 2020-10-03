using System;
using System.Collections.Generic;
using System.Text;
using Model.Database;

namespace ServiceLayer.Interfaces
{
    public interface IProizvodjacService
    {
        IEnumerable<Proizvodjac> GetProizvodjaci();
        Proizvodjac Get(int id);
    }
}
