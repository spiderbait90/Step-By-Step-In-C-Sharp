using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using AutoMapper;
using GamesStore.Common.Admin.BindingModels;
using GamesStore.Data;
using GamesStore.Models;
using GamesStore.Services;
using GamesStore.Services.Interfaces;
using GamesStore.Tests.Mocks;
using GamesStore.Web.Areas.Admin.Controllers;
using GamesStore.Web.Controllers;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace GamesStore.Tests.Controllers
{
    [TestClass]
    public class CategoryControllerTests : IDisposable
    {
        private GamesStoreContext db;
        private IMapper mapper;

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void Controller_WithNullDataBase_ShouldReturnNullRefEx()
        {
            var controller = new CategoryController(mapper, null);
            var result = controller.Delete(null);
        }

        [TestMethod]
        public void Delete_WithNonExistingCategory_ShouldReturnNotFound()
        {
            var controller = new CategoryController(mapper, db);
            var result = controller.Delete("Adventure");

            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result,typeof(NotFoundResult));
        }

        [TestMethod]
        public void All_WithNoCategories_ShouldReturnNon()
        {
            var controller = new CategoryController(mapper, db);
            var result = controller.All();

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Add_WithModel_ShouldReturnRedirectToActionResult()
        {
            var controller = new CategoryController(mapper,db);
            var result = controller.Add(new CategoryBindingModel()
            {
                Name = "Adventure"
            }) as RedirectToActionResult;

            Assert.IsInstanceOfType(result,typeof(RedirectToActionResult));
            Assert.IsNotNull(result);
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
