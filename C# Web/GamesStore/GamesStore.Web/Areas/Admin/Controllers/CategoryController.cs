using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GamesStore.Common.Admin.BindingModels;
using GamesStore.Data;
using GamesStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GamesStore.Web.Areas.Admin.Controllers
{
    public class CategoryController : AdminController
    {
        public CategoryController(IMapper mapper, GamesStoreContext context) : base(mapper, context)
        {
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(CategoryBindingModel categoryModel)
        {
            var category = context.Categories.FirstOrDefault(x => string.Equals(x.Name.Trim(), categoryModel.Name.Trim(), StringComparison.CurrentCultureIgnoreCase));

            if (category == null)
            {
                var categoryMap = mapper.Map<Category>(categoryModel);
                context.Categories.Add(categoryMap);
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Already Exists");
                return View();
            }

            context.SaveChanges();
            return RedirectToAction("All");
        }

        public IActionResult All()
        {
            var categories = context.Categories.ToList();
           
            return View(categories);
        }

        public IActionResult Delete(string name)
        {
            var category = context.Categories.Include(x => x.Games)
                .FirstOrDefault(x => x.Name == name);

            if (category == null)
            {
                return NotFound();
            }

            if (category.Games.Any())
            {
                TempData["inUse"] = "Category is in use of a Game";
                return RedirectToAction("All");
            }

            context.Categories.Remove(category);
            context.SaveChanges();

            return RedirectToAction("All");
        }
    }
}