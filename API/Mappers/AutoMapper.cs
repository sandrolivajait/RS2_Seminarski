﻿using AutoMapper;
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
        }
    }
}
