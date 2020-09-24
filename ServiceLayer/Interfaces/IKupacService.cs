using System;
using System.Collections.Generic;
using System.Text;
using Model.Models;

namespace ServiceLayer.Interfaces
{
    public interface IKupacService
    {
        IEnumerable<Kupac> GetKupci();
        Kupac GetKupac(int id);

        void InsertKupac(Kupac kupac);

    }
}
