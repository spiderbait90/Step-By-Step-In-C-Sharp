using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GamesStore.Common;
using GamesStore.Common.Admin.BindingModels;
using GamesStore.Common.Admin.ViewModels;
using GamesStore.Models;

namespace GamesStore.Web.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            this.CreateMap<GameBindingModel, Game>()
                .ForMember(x => x.Category, opt => opt.Ignore());
            this.CreateMap<Game, GameViewModel>()
                .ForMember(x => x.Category, opt => opt.MapFrom(x => x.Category));
            this.CreateMap<CategoryBindingModel, Category>();
            this.CreateMap<CartItem, GameViewModel>();
        }
    }
}
