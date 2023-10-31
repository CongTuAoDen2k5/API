using DAO.Models;
using DAO.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DAO.Service
{
    public interface IProductService
    {
        IEnumerable<ProductVM> GetAll();

        IEnumerable<ProductVM> GetAll(int? limt = null, int? offSet = null, Expression<Func<Product, bool>> filter = null, Func<IQueryable<Product>, IOrderedQueryable<Product>> orderBy = null);

        ProductVM GetById(int id);

        void Add(Product p);

        void Update(Product p);

        void Delete(int id);
    }
}