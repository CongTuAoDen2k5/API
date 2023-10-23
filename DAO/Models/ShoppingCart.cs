using System;
using System.Collections.Generic;

#nullable disable

namespace DAO.Models
{
    public partial class ShoppingCart
    {
        public int Id { get; set; }
        public string ApplicationUserId { get; set; }
        public int ProductId { get; set; }
        public int Count { get; set; }

        public virtual AspNetUser ApplicationUser { get; set; }
        public virtual Product Product { get; set; }
    }
}
