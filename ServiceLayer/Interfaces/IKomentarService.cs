using System;
using System.Collections.Generic;
using Model.Database;
using System.Text;

namespace ServiceLayer.Interfaces
{
    public interface IKomentarService
    {
        List<Komentar> GetAllKomentariByPhoneId(int id);

        void InsertKomentar(Komentar komentar);
    }
}
