using DAO.DataAccess.UnitOfWork;
using DAO.Models;
using DAO.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

        public IEnumerable<ProductVM> GetAll(int limit, int offSet, Expression<Func<Product, bool>> filter = null, Func<IQueryable<Product>, IOrderedQueryable<Product>> orderBy = null)
        {
            var products = u.ProductRepository.Get(filter, orderBy, "Brand,Category,Unit").Take(limit).Skip(offSet);
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

        public ProductVM GetById(int id)
        {
            Expression<Func<Product, bool>> fillter = (x => x.Id == id);
            var product = u.ProductRepository.Get(fillter, null, "Brand,Category,Unit").Where(x => x.Id == id).FirstOrDefault();
            return new ProductVM()
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
            };
        }
        public void Add(Product p)
        {
            Expression<Func<Product, bool>> fillter = x => x.Name == p.Name;
            var products = u.ProductRepository.Get(fillter);
            if(products != null)
            {
                throw new Exception("Tên sản phẩm đã tồn tại!");
            }
            else
            {
                try
                {
                    u.ProductRepository.Insert(p);
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
            }
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
