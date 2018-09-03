using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using GamesStore.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace GamesStore.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Administrator")]
    public abstract class AdminController : Controller
    {
        protected readonly IMapper mapper;
        protected GamesStoreContext context;

        protected AdminController(IMapper mapper, GamesStoreContext context)
        {
            this.context = context;
            this.mapper = mapper;
        }
    }
}