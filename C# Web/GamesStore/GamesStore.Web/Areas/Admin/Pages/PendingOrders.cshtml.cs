using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GamesStore.Data;
using GamesStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace GamesStore.Web.Pages
{
    public class PendingOrdersModel : PageModel
    {
        public PendingOrdersModel(GamesStoreContext db)
        {
            Db = db;
            PendingOrders = new List<PendingOrder>();
        }

        public ICollection<PendingOrder> PendingOrders { get; set; }

        public GamesStoreContext Db { get; set; }

        public void OnGet()
        {
            PendingOrders = Db.PendingOrders
                .Include(x => x.Items)
                .ThenInclude(x => x.Product)
                .ToList();
        }
    }
}