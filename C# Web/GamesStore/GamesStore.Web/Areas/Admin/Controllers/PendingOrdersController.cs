using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GamesStore.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GamesStore.Web.Areas.Admin.Controllers
{
    public class PendingOrdersController :AdminController
    {
        public PendingOrdersController(IMapper mapper, GamesStoreContext context) : base(mapper, context)
        {
        }

        public IActionResult Confirm(string id)
        {
            var order = context.PendingOrders.Find(id);

            order.IsConfirmed = true;

            context.SaveChanges();

            return RedirectToPage("/PendingOrders");
        }
    }
}