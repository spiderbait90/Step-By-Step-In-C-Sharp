using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GamesStore.Models
{
    public class Category
    {
        public Category()
        {
            Games = new List<Game>();
        }
        public string Id { get; set; }
        
        public string Name { get; set; }

        public ICollection<Game> Games { get; set; }
    }
}
