using System;
using System.Collections.Generic;
using System.Text;
using Model.Models;
using Model.Requests;

namespace ServiceLayer.Interfaces
{
    public interface IKupacService
    {
        
        public Kupac GetKupac(int id);

        public void InsertKupac(KupacInsertRequest kupac);

        public IEnumerable<Kupac> GetAll();

        public void Update(int id, KupacInsertRequest request);

       

    }
}
