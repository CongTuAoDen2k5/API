using DAO.DataAccess.GenericRepository;
using DAO.Models;
using System;

namespace DAO.DataAccess.UnitOfWork
{
    public class UnitOfWork : IDisposable
    {
        private FreshMarketContext context = new FreshMarketContext();
        private GenericRepository<Product> productRepository;

        public GenericRepository<Product> ProductRepository
        {
            get
            {
                if (this.productRepository == null)
                    this.productRepository = new GenericRepository<Product>(context);
                return this.productRepository;
            }
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}