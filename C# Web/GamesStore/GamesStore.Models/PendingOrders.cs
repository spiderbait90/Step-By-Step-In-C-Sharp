using System;
using System.Collections.Generic;
using System.Text;

namespace GamesStore.Models
{
    public class PendingOrder
    {
        public PendingOrder()
        {
            Items = new List<CartItem>();
            IsConfirmed = false;
        }
        public string Id { get; set; }

        public string Address { get; set; }

        public string FullName { get; set; }

        public bool IsConfirmed { get; set; }

        public ICollection<CartItem> Items { get; set; }

    }
}
