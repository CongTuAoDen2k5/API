using DAO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.ViewModel
{
    public class ProductVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Discription { get; set; }
        public int Quantity { get; set; }
        public long Price { get; set; }
        public string ImageUrl { get; set; }
        public DateTime? CreateAt { get; set; }

        public string BrandName { get; set; }
        public string CategoryName { get; set; }
        public string UnitName { get; set; }
    }
}
