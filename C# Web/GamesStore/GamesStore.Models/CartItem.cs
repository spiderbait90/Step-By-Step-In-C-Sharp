namespace GamesStore.Models
{
    public class CartItem
    {
        public string Id { get; set; }

        public string ProductId { get; set; }

        public Game Product { get; set; }

        public int Quantity { get; set; }
    }
}