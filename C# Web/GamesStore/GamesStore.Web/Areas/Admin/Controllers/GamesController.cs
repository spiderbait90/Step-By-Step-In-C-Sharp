using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Threading.Tasks;
using AutoMapper;
using GamesStore.Common;
using GamesStore.Common.Admin.BindingModels;
using GamesStore.Common.Admin.ViewModels;
using GamesStore.Data;
using GamesStore.Models;
using GamesStore.Services.Interfaces;
using GamesStore.Web.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace GamesStore.Web.Areas.Admin.Controllers
{
    public class GamesController : AdminController
    {
        private IGamesService gameService;

        public GamesController(IMapper mapper, GamesStoreContext context, IGamesService gamesService) : base(mapper, context)
        {
            this.gameService = gamesService;
        }

        [HttpGet]
        public IActionResult Add()
        {
            var categories = context.Categories.Select(x => x.Name).ToList();
            var model = new GameBindingModel();

            foreach (var c in categories)
            {
                model.Categories.Add(new SelectListItem(c, c));
            }

            return View(model);
        }

        [HttpPost]
        public IActionResult Add(GameBindingModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var category = context.Categories.FirstOrDefault(x => x.Name == model.Category);

            var game = mapper.Map<Game>(model);
            game.CategoryId = category.Id;

            var gameInDb =
                context.Games.FirstOrDefault(x => x.Name.Trim().Equals(model.Name.Trim(), StringComparison.OrdinalIgnoreCase));

            if (gameInDb == null)
            {
                context.Games.Add(game);
            }
            else
            {
                TempData["exists"] = "Game Exists!";
                return RedirectToAction("Add");
            }
            context.SaveChanges();

            return RedirectToAction("Details", "Games", new { game.Id });

        }


        [HttpGet]
        public IActionResult Details(string id)
        {
            var game = gameService.GetGame(id);

            if (game == null)
            {
                return NotFound();
            }

            return this.View(game);
        }

        [HttpGet]
        public IActionResult Edit(string id)
        {
            var game = context.Games.Find(id);

            if (game == null)
            {
                return NotFound();
            }

            var categories = context.Categories.ToList();
            var gameModel = mapper.Map<GameViewModel>(game);
            var list = new List<SelectListItem>();

            foreach (var c in categories)
            {
                list.Add(new SelectListItem(c.Name, c.Id));
            }

            ViewBag.Categories = list;

            return View(gameModel);
        }

        [HttpPost]
        public IActionResult Edit(GameBindingModel gameBindingModel)
        {
            if (!ModelState.IsValid)
            {
                var categories = context.Categories.ToList();

                var list = new List<SelectListItem>();

                foreach (var c in categories)
                {
                    list.Add(new SelectListItem(c.Name, c.Id));
                }

                ViewBag.Categories = list;
                return View();
            }

            var game = mapper.Map<Game>(gameBindingModel);
            game.CategoryId = gameBindingModel.Category;

            context.Entry(game).State = EntityState.Modified;
            context.SaveChanges();

            return RedirectToAction("Details", new { id = game.Id });
        }

        public IActionResult Delete(string id)
        {
            var game = context.Games.Find(id);

            if (context.CartItems.Any(x => x.ProductId == game.Id))
            {
                TempData["inUseByUser"] = "Cannot delete game that is used by user";
                return RedirectToAction("Index", "Home");
            }

            context.Games.Remove(game);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        
    }
}