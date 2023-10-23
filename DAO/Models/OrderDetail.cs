using System;
using System.Collections.Generic;

#nullable disable

namespace DAO.Models
{
    public partial class OrderDetail
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Count { get; set; }
        public long Price { get; set; }

        public virtual OrderHeader Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
