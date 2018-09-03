using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using GamesStore.Common.Admin.ViewModels;
using GamesStore.Data;
using GamesStore.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace GamesStore.Services
{
    public class GamesService : BaseEFService, IGamesService
    {
        public GamesService(GamesStoreContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        public ICollection<GameViewModel> GetAllGames()
        {
            var gamesDb = DbContext.Games
                .Include(x => x.Category)
                .ToList();
            var models = Mapper.Map<ICollection<GameViewModel>>(gamesDb);

            return models;
        }

        public GameViewModel GetGame(string id)
        {
            var game = DbContext.Games.Find(id);

            var gameModel = Mapper.Map<GameViewModel>(game);

            return gameModel;
        }
    }
}
