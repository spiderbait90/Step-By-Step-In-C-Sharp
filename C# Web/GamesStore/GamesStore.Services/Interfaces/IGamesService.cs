using System;
using System.Collections.Generic;
using System.Text;
using GamesStore.Common.Admin.ViewModels;

namespace GamesStore.Services.Interfaces
{
    public interface IGamesService
    {
        ICollection<GameViewModel> GetAllGames();

        GameViewModel GetGame(string id);
    }
}
