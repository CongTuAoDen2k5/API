using DAO.Models;
using DAO.ViewModel;
using System.Collections.Generic;

namespace DAO.Converter.ProductConverter
{
    public interface IProductConverter
    {
        ProductVM ToModel(Product p);

        List<ProductVM> ToModels(List<Product> p);
    }
}