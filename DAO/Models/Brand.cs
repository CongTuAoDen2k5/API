using System;
using System.Collections.Generic;

#nullable disable

namespace DAO.Models
{
    public partial class Brand
    {
        public Brand()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Discription { get; set; }
        public string Logo { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
