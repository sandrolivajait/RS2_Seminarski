using System;
using System.Collections.Generic;
using System.Text;
using Model.Database;

namespace ServiceLayer.Interfaces
{
    public interface IKupacService
    {
        IEnumerable<Kupac> GetKupci();
        Kupac GetKupac(int id);

        void InsertKupac(Kupac kupac);

    }
}
