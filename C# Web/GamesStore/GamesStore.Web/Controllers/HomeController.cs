using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GamesStore.Common.Admin.ViewModels;
using GamesStore.Data;
using GamesStore.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using GamesStore.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

namespace GamesStore.Web.Controllers
{

    public class HomeController : Controller
    {
        private IGamesService gamesService;

        public HomeController(IGamesService gamesService)
        {
            this.gamesService = gamesService;
        }

        [Authorize]
        public IActionResult Index()
        {
            if (User.IsInRole("Administrator"))
            {
                return RedirectToAction("Index", "Home", new { area = "Admin" });
            }
            
            var games = gamesService.GetAllGames();
            
            return View("~/Areas/Admin/Views/Home/Index.cshtml", games);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}
