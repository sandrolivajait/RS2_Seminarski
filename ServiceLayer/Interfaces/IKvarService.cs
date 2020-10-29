using Model.Models;
using Model.Requests;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.Interfaces
{
    public interface IKvarService
    {
        public IEnumerable<Kvar> Get();
        public IEnumerable<Model.Database.StanjeKvara> GetStanjaKvara();
        public Kvar Get(int id);
        public void Insert(KvarInsertRequest request);
        public void Update(int id, KvarInsertRequest request);
    }
}
