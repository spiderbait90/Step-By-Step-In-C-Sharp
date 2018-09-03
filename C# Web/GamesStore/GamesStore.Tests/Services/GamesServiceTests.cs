using System;
using System.ComponentModel.Design;
using AutoMapper;
using AutoMapper.Configuration;
using GamesStore.Data;
using GamesStore.Models;
using GamesStore.Services;
using GamesStore.Tests.Mocks;
using GamesStore.Web.AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GamesStore.Tests
{
    [TestClass]
    public class GamesServiceTests : IDisposable
    {
        private GamesStoreContext db;
        private IMapper mapper;
        

        [TestMethod]
        public void GetGame_WithNonExistentId_ShouldReturnNull()
        {
            var service = new GamesService(db, Mapper.Instance);

            db.Games.Add(new Game()
            {
                Id = "1"
            });

            var game = service.GetGame("2");

            Assert.IsNull(game);
        }

        [TestMethod]
        public void GetGame_WithId_ShouldReturnOne()
        {
            var service = new GamesService(db, Mapper.Instance);

            db.Games.Add(new Game()
            {
                Id = "1"
            });

            var game = service.GetGame("1");

            Assert.IsNotNull(game);
            Assert.AreEqual(game.Id, "1");

        }

        [TestMethod]
        public void GetAllGames_WhithFew_ShouldReturnAll()
        {
            var service = new GamesService(db, Mapper.Instance);
            db.Games.Add(new Game()
            {
                Id = "1",
                Name = "Assasins Creed",
                Quantity = 3,
                Price = 200
            });
            db.Games.Add(new Game()
            {
                Id = "2",
                Name = "Assasins Creed 2",
                Quantity = 8,
                Price = 100
            });

            db.SaveChanges();

            var games = service.GetAllGames();

            Assert.IsNotNull(games);
            Assert.AreEqual(games.Count, 2);

        }

        [TestMethod]
        public void GetAllGames_WithNone_ShouldReturnNull()
        {
            var service = new GamesService(db, mapper);

            var games = service.GetAllGames();

            Assert.IsNotNull(games);
            Assert.AreEqual(games.Count, 0);

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
