using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GamesStore.Common.Admin.BindingModels;
using GamesStore.Data;
using GamesStore.Models;
using GamesStore.Services.Interfaces;
using GamesStore.Web.Areas.Admin.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GamesStore.Web.Controllers
{

    [Authorize(Roles = "User , ")]
    public class CartController : Controller
    {
        private readonly IGamesService gameService;
        private readonly GamesStoreContext db;

        public CartController(GamesStoreContext context, IGamesService gamesService)
        {
            this.gameService = gamesService;
            this.db = context;
        }

        public IActionResult AddToCart(string id)
        {
            var user = db.Users
                 .Include(x => x.Cart)
                .ThenInclude(x => x.Products)
                .ThenInclude(x => x.Product)
                .FirstOrDefault(x => x.UserName == User.Identity.Name);

            var game = db.Games.Find(id);

            if (user == null || game == null)
            {
                return NotFound();
            }

            if (user.Cart == null)
            {
                user.Cart = new Cart();
            }

            if (user.Cart.Products.Any(x => x.ProductId == game.Id))
            {
                var gameToModify = user.Cart.Products.FirstOrDefault(x => x.Product.Id == game.Id);

                if (gameToModify == null)
                {
                    return NotFound();
                }

                gameToModify.Quantity++;

            }
            else
            {
                var item = new CartItem()
                {
                    Product = game,
                    Quantity = 1
                };

                user.Cart.Products.Add(item);
            }

            game.Quantity--;

            db.SaveChanges();

            TempData["SuccsesAdded"] = "Succsesfully Added";

            return RedirectToAction("CartDetails", "Cart");
        }

        public IActionResult CartDetails()
        {
            var user = db.Users.Include(x => x.Cart)
                .ThenInclude(x => x.Products)
                .ThenInclude(x => x.Product)
                .ThenInclude(x => x.Category)
                .FirstOrDefault(x => x.UserName == User.Identity.Name);

            if (user == null)
            {
                return NotFound();
            }

            if (user.Cart == null)
            {
                user.Cart = new Cart();
            }

            if (user.Cart.Products.Count == 0)
            {
                var model = new Collection<CartItem>();
                return View(model);
            }

            return View(user.Cart.Products);
        }

        public IActionResult Delete(string id)
        {
            var user = db.Users
                    .Include(x => x.Cart)
                .ThenInclude(x => x.Products)
                .ThenInclude(x => x.Product)
                .ThenInclude(x => x.Category)
                .FirstOrDefault(x => x.UserName == User.Identity.Name);

            var game = db.Games.Find(id);

            var itemToRemove = user.Cart.Products.FirstOrDefault(x => x.Product.Id == game.Id);

            if (itemToRemove == null)
            {
                return NotFound();
            }

            db.CartItems.Remove(itemToRemove);

            game.Quantity += itemToRemove.Quantity;

            db.SaveChanges();

            TempData["SuccsesDelete"] = "Succsesfully Deleted";

            return View("CartDetails", user.Cart.Products);
        }

        [HttpGet]
        public IActionResult Order()
        {
            return View();
        }

        public IActionResult Order(UserInfoBindingModel model)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }

            var user = db.Users
                .Include(x => x.Cart)
                .ThenInclude(x => x.Products)
                .ThenInclude(x => x.Product)
                .FirstOrDefault(x => x.UserName == User.Identity.Name);

            var products = new CartItem[user.Cart.Products.Count];

            user.Cart.Products.CopyTo(products, 0);

            var pendingOrder = db.PendingOrders.Find(model.Id);

            if (pendingOrder == null)
            {
                pendingOrder = new PendingOrder();
            }

            pendingOrder.Id = model.Id;
            pendingOrder.Address = model.Addres;
            pendingOrder.FullName = model.FullName;

            foreach (var p in products)
            {
                pendingOrder.Items.Add(p);
            }

            db.PendingOrders.Add(pendingOrder);
            user.Cart.Products.Clear();

            db.SaveChanges();

            return RedirectToAction("CartDetails");
        }
    }
}
