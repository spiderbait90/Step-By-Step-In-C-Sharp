using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace GamesStore.Models
{
    public class User : IdentityUser
    {
        public string FullName { get; set; }

        public string Address { get; set; }

        public Cart Cart { get; set; }

    }
}
