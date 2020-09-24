using System;
using System.Collections.Generic;
using System.Text;
using Model;
using Model.Requests;
using Model.Models;

namespace ServiceLayer.Interfaces
{
    public interface IMobitelService
    {
        IEnumerable<Mobiteli> GetMobiteli();
        IEnumerable<Mobiteli> GetMobiteli(MobiteliSearchRequest search);

        IEnumerable<Mobiteli> GetMobiteliSorted(int page,bool priceDesc, string searchNaziv, string priceFromAndTo, int ? ProizvodjacId, int resultsPerPage, ref int TotalPages);
        Mobiteli GetMobitel(int id);
        void Insert(MobiteliInsertRequest request);
        void Update(int id, MobiteliInsertRequest request);
    }
}
