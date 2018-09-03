using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using GamesStore.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GamesStore.Common.Admin.ViewModels
{
   public class GameViewModel
    {
        public string Id { get; set; }

        public string ImgUrl { get; set; }

        public string Description { get; set; }

        public string Name { get; set; }

        public int Quantity { get; set; }
        
        public decimal Price { get; set; }

        public Category Category { get; set; }

    }
}
