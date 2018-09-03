using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GamesStore.Common.Admin.ViewModels;
using GamesStore.Data;
using GamesStore.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace GamesStore.Web.Areas.Admin.Controllers
{
    public class HomeController : AdminController
    {
        private readonly IGamesService gamesService;

        public HomeController(IMapper mapper, GamesStoreContext context,IGamesService gamesService) : base(mapper, context)
        {
            this.gamesService = gamesService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var gamesModels = gamesService.GetAllGames();

            return View(gamesModels);
        }
    }
}