using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Mappers
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<Model.Database.Mobiteli, Model.Models.Mobiteli>()
                .ForMember(dest => dest.KolicinaPopustaDecimalni, opt => opt.MapFrom(src => src.Popust.PostotakPopusta))
                .ForMember(dest => dest.OperativniSustav, opt => opt.MapFrom(src => src.OperativniSustav.Naziv))
                .ForMember(dest => dest.Prozivodjac, opt => opt.MapFrom(src => src.Prozivodjac.Naziv));


            CreateMap<Model.Requests.MobiteliInsertRequest, Model.Database.Mobiteli>()
                .ForMember(dest => dest.SlikaFull, opt => opt.MapFrom(src => src.Slika))
                .ForMember(dest => dest.ProizvodjacId, opt => opt.MapFrom(src => src.ProizvodjacId))
                .ForMember(dest => dest.OperativniSustavId, opt => opt.MapFrom(src => src.OperativniSustavId))
                .ForMember(dest => dest.PopustId, opt => opt.MapFrom(src => src.PopustId))
                .ForPath(dest => dest.Popust.DatumOd, opt => opt.MapFrom(src => src.PopustOd))
                .ForPath(dest => dest.Popust.DatumDo, opt => opt.MapFrom(src => src.PopustDo))
                .ForPath(dest => dest.Popust.PostotakPopusta, opt => opt.MapFrom(src => (float)src.KolicinaPopusta));


            CreateMap<Model.Database.Administrator, Model.Models.Administrator>();

            // create the salts and hash here instead of coding directly.
            CreateMap<Model.Requests.AdministratorInsertRequest, Model.Database.Administrator>()
                .BeforeMap((src, dest) => dest.LozinkaSalt = SaltingHashes.GenerateSalt())
                .AfterMap((src, dest) => dest.LozinkaHash = SaltingHashes.GenerateHash(dest.LozinkaSalt, src.Password));

            CreateMap<Model.Database.Kupac, Model.Models.Kupac>()
                .ForMember(dest => dest.Grad, opt => opt.MapFrom(src => src.Grad.Naziv));

            CreateMap<Model.Database.Kvar, Model.Models.Kvar>()
                .ForMember(dest => dest.ImeKupca, opt => opt.MapFrom(src => src.Kupac.Ime + " " + src.Kupac.Prezime));

            // create the salts and hash here instead of coding directly.
            CreateMap<Model.Requests.KupacInsertRequest, Model.Database.Kupac>()
                .BeforeMap((src, dest) => dest.LozinkaSalt = SaltingHashes.GenerateSalt())
                .AfterMap((src, dest) => dest.LozinkaHash = SaltingHashes.GenerateHash(dest.LozinkaSalt, src.Password));

            CreateMap<Model.Requests.KvarInsertRequest, Model.Database.Kvar>();


            CreateMap<Model.Database.Narudzba, Model.Models.Narudzba>()
                .ForMember(dest => dest.NarucenoStavki, opt => opt.MapFrom(src => src.StavkaNarudzbe.Count))
                .ForMember(dest => dest.ImePrezimeKupca, opt => opt.MapFrom(src => src.Kupac.Ime + " " + src.Kupac.Prezime));


        }
    }
}
