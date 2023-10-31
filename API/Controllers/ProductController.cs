using API.Request;
using DAO.DataAccess.UnitOfWork;
using DAO.Models;
using DAO.Service;
using DAO.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [Route("Get")]
        [HttpGet]
        public IEnumerable<ProductVM> GetProducts()
        {
            return _productService.GetAll();
        }

        [Route("GetById")]
        [HttpGet]
        public ProductVM GetProductById(int id)
        {
            return _productService.GetById(id);
        }

        [Route("GetByName")]
        [HttpGet]
        public IEnumerable<ProductVM> GetProductsByName(string name)
        {
            Expression<Func<Product, bool>> fillter = x => x.Name.Contains(name);
            return _productService.GetAll(null, null, fillter, null);
        }

        [Route("AddProduct")]
        public void AddProduct(ProductRequest product)
        {
            if (string.IsNullOrEmpty(product.Name))
            {
                throw new Exception("Tên sản phẩm không được để trống!");
            }
            else if (string.IsNullOrEmpty(product.Discription))
            {
                throw new Exception("Mô tả sản phẩm không được để trống!");
            }
            else if (product.Quantity == null)
            {
                throw new Exception("Số lượng sản phẩm không được để trống!");
            }
            else if (string.IsNullOrEmpty(product.ImageUrl))
            {
                throw new Exception("Ảnh sản phẩm không được để trống!");
            }
            else if (product.BrandId == null)
            {
                throw new Exception("BrandId không được để trống!");
            }
            else if (product.CategoryId == null)
            {
                throw new Exception("CategoryId không được để trống!");
            }
            else if (product.UnitId == null)
            {
                throw new Exception("UnitId không được để trống!");
            }
            else
            {
                Product p = new Product()
                {
                    Name = product.Name,
                    Discription = product.Discription,
                    Quantity = product.Quantity,
                    Price = product.Price,
                    ImageUrl = product.ImageUrl,
                    CreateAt = DateTime.Now,
                    BrandId = product.BrandId,
                    CategoryId = product.CategoryId,
                    UnitId = product.UnitId,
                };

                _productService.Add(p);
            }
        }

    }
}
