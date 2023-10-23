using System;
using System.Collections.Generic;

#nullable disable

namespace DAO.Models
{
    public partial class Product
    {
        public Product()
        {
            OrderDetails = new HashSet<OrderDetail>();
            ShoppingCarts = new HashSet<ShoppingCart>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Discription { get; set; }
        public int Quantity { get; set; }
        public long Price { get; set; }
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public int UnitId { get; set; }
        public DateTime? CreateAt { get; set; }

        public virtual Brand Brand { get; set; }
        public virtual Category Category { get; set; }
        public virtual Unit Unit { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<ShoppingCart> ShoppingCarts { get; set; }
    }
}
