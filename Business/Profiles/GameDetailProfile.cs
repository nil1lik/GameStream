using AutoMapper;
using Business.DT0s.GameDetail;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class GameDetailProfile : Profile
    {
        public GameDetailProfile()
        {
            CreateMap<GameDetail, DetailsPageGameDetailDto>()
                .ForMember(gd => gd.GameName, opt => opt.MapFrom(src => src.Game.Name))
                .ForMember(gd => gd.GameId, opt => opt.MapFrom(src => src.Game.Id))
                .ForMember(gd => gd.Logo, opt=> opt.MapFrom(src=> src.Game.ImageUrl))
                .ForMember(gd => gd.GameImages, opt => opt.MapFrom(src => src.Game.GameImages.Select(img => img.ImageUrl).ToList()))
                .ReverseMap();
        }
    }
}
