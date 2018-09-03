using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using GamesStore.Data;
using GamesStore.Models;
using GamesStore.Services;
using GamesStore.Services.Interfaces;
using GamesStore.Tests.Mocks;
using GamesStore.Web.Areas.Admin.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GamesStore.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTests : IDisposable
    {

        private GamesStoreContext db;
        private IMapper mapper;
        private IGamesService service;

        [TestMethod]
        public void CheckIfReturnsView()
        {
            var controller = new HomeController(mapper, db, new GamesService(db, mapper));

            var result = controller.Index() as ViewResult;

            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result,typeof(ViewResult));
        }
        [TestInitialize]
        public void InitializeTests()
        {
            var options = new DbContextOptionsBuilder<GamesStoreContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            this.db = new GamesStoreContext(options);
            this.mapper = MockAutoMapper.GetMapper();
        }

        public void Dispose()
        {
            Mapper.Reset();
        }
    }
}
