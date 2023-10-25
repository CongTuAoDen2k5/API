using DAO.DataAccess.UnitOfWork;
using DAO.Models;
using DAO.Service;
using DAO.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
    }
}
