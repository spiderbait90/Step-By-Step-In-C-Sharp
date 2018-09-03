using System.Collections.Generic;

namespace GamesStore.Models
{
    public class Cart
    {
        public Cart()
        {
            Products = new List<CartItem>();
        }
        public string Id { get; set; }

        public ICollection<CartItem> Products { get; set; }
    }
}