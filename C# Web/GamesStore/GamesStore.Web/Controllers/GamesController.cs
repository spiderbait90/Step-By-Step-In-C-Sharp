using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using AutoMapper;
using GamesStore.Common.Admin.BindingModels;
using GamesStore.Common.Admin.ViewModels;
using GamesStore.Data;
using GamesStore.Models;
using GamesStore.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.Language.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGeneration.Templating;

namespace GamesStore.Web.Controllers
{
    public class GamesController : Controller
    {
        private IGamesService gamesService;
        private GamesStoreContext db;
        private IMapper mapper;

        public GamesController(IGamesService gamesService, GamesStoreContext db, IMapper mapper)
        {
            this.gamesService = gamesService;
            this.db = db;
            this.mapper = mapper;
        }

        [HttpGet]
        public IActionResult Details(string id)
        {
            var game = gamesService.GetGame(id);

            if (game == null)
            {
                return NotFound();
            }

            return View("~/Areas/Admin/Views/Games/Details.cshtml", game);
        }

    }
}