using System;
using System.Collections.Generic;
using System.Text;
using Model.Database;
using Model.Requests;

namespace ServiceLayer.Interfaces
{
    public interface INarudzbaService
    {
        void InsertNarudzba(Narudzba narudzba, List<StavkaNarudzbe> stavke);
        public IEnumerable<Model.Models.Narudzba> GetAll();

        public Model.Models.Narudzba GetNarudzba(int id);
        IEnumerable<Model.Database.StanjeNarudzbe> GetStanjaNarudzbi();

        public void Insert(NarudzbaInsertRequest request);
        public void Update(int id, NarudzbaInsertRequest request);
    }
}
