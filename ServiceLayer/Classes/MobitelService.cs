using AutoMapper;
using Model;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer;
using ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.Requests;
using Model.Models;

namespace ServiceLayer
{
    public class MobitelService : IMobitelService
    {
        private readonly IMapper mapper;
        private readonly IRepository<Model.Database.Mobiteli> mobitelRepository;

        public MobitelService(IRepository<Model.Database.Mobiteli> mobitelRepository, IMapper mapper)
        {
            this.mobitelRepository = mobitelRepository;
            this.mapper = mapper;
        }
        public IEnumerable<Mobiteli> GetMobiteli()
        {
            return mapper.Map<List<Model.Models.Mobiteli>>(mobitelRepository.GetAll());
        }

        public Mobiteli GetMobitel(int id)
        {
            return mapper.Map<Model.Models.Mobiteli>(mobitelRepository.Get(id));
        }

        public IEnumerable<Mobiteli> GetMobiteliSorted(int page, bool priceDesc, string searchNaziv, string priceFromAndTo, int? ProizvodjacId, int resultsPerPage, ref int TotalPages)
        {
            var mobiteli = mobitelRepository.GetAllQueryable();
            

            if(ProizvodjacId != null && ProizvodjacId != 0)
            {
                mobiteli = mobiteli.Where(x => x.ProizvodjacId == ProizvodjacId.Value);
            }
            if (!string.IsNullOrEmpty(searchNaziv))
                mobiteli = mobiteli.Where(x => x.Naziv.Contains(searchNaziv) || x.Naziv.StartsWith(searchNaziv) || x.Prozivodjac.Naziv.Contains(searchNaziv));
            if (!string.IsNullOrEmpty(priceFromAndTo))
            {
                int priceFrom = Convert.ToInt32(priceFromAndTo.Split(';')[0]);
                int priceTo = Convert.ToInt32(priceFromAndTo.Split(';')[1]);

                
                mobiteli = mobiteli.Where(x =>
                (x.PopustId != null && (x.Cijena - (x.Cijena * x.Popust.PostotakPopusta) >= priceFrom && x.Cijena - (x.Cijena * x.Popust.PostotakPopusta) <= priceTo))
                || x.Cijena >= priceFrom && x.Cijena <= priceTo);
            }

            
            if (priceDesc)
                mobiteli = mobiteli.OrderByDescending(x => x.Cijena);
            else
                mobiteli = mobiteli.OrderBy(x => x.Cijena);

            TotalPages = (int)Math.Ceiling(decimal.Divide(mobiteli.Count(), resultsPerPage));
            
            if (page != 0)
                page -= 1;
            mobiteli = mobiteli.Skip(resultsPerPage * page).Take(resultsPerPage);

            return mapper.Map<List<Model.Models.Mobiteli>>(mobiteli.ToList());
        }

        public IEnumerable<Mobiteli> GetMobiteli(MobiteliSearchRequest search)
        {
            var query = mobitelRepository.GetAllQueryable();

            if (!string.IsNullOrWhiteSpace(search?.Naziv))
            {
                query = query.Where(x => x.Naziv.StartsWith(search.Naziv));
            }
            if ((!string.IsNullOrWhiteSpace((search?.ProizvodjacId).ToString())) && search?.ProizvodjacId != 0)
            {
                query = query.Where(x => x.ProizvodjacId == search.ProizvodjacId);
            }
            if (search.CijenaOd != null)
            {
                query = query.Where(x => x.Cijena > search.CijenaOd);
            }

            if (search.CijenaDo != null)
            {
                query = query.Where(x => x.Cijena < search.CijenaDo);
            }

           return mapper.Map<List<Model.Models.Mobiteli>>(query.ToList());
        }

        public void Insert(MobiteliInsertRequest request)
        {
            var mobitel = mapper.Map<Model.Database.Mobiteli>(request);
            mobitelRepository.Insert(mobitel);
        }

        public void Update(int id, MobiteliInsertRequest request)
        {
            var entity = mobitelRepository.Get(id);
            mapper.Map(request, entity);
            mobitelRepository.Update(entity);
        }

       
    }
}
