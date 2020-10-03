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


            CreateMap<Model.Database.Mobiteli, Model.Requests.MobiteliInsertRequest>().ReverseMap();
        }
    }
}
