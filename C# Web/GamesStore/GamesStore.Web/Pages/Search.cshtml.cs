using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GamesStore.Data;
using GamesStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GamesStore.Web.Pages.Search
{
    public class SearchModel : PageModel
    {
        public SearchModel(GamesStoreContext db)
        {
            Db = db;
            Games = new List<Game>();
        }

        public GamesStoreContext Db { get; set; }

        public string SearchTerm { get; set; }

        public List<Game> Games { get; set; }
        

        public void OnGet(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                Games = Db.Games.ToList();
                return;
            }

            SearchTerm = searchTerm.ToLower();           

            Games = Db.Games.Where(x => x.Name.ToLower().Contains(searchTerm)).ToList();
        }
    }
}