using System.Collections.Generic;

namespace GamesStore.Models
{
    public class Game
    {
        
        public string Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public string ImgUrl { get; set; }

        public string CategoryId { get; set; }

        public Category Category { get; set; }

        
    }
}