using DAO.DataAccess.UnitOfWork;
using DAO.Models;
using DAO.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Service
{
    public class ProductService : IProductService
    {
        UnitOfWork u = new UnitOfWork();

        public IEnumerable<ProductVM> GetAll()
        {
            var products = u.ProductRepository.Get(null, null, "Brand,Category,Unit");
            var productsVMs = new List<ProductVM>();
            foreach (var product in products)
            {
                productsVMs.Add(new ProductVM()
                {
                    Id = product.Id,
                    Name = product.Name,
                    Discription = product.Discription,
                    Quantity = product.Quantity,
                    Price = product.Price,
                    ImageUrl = product.ImageUrl,
                    CreateAt = product.CreateAt,
                    BrandName = product.Brand.Name,
                    CategoryName = product.Category.Name,
                    UnitName = product.Unit.Name,
                });
            }
            return productsVMs;
        }

        public IEnumerable<ProductVM> GetAll(int limit, int offSet)
        {
            throw new NotImplementedException();
        }

        public ProductVM GetById(int id)
        {
            throw new NotImplementedException();
        }
        public void Add(Product p)
        {
            
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product p)
        {
            throw new NotImplementedException();
        }
    }
}
