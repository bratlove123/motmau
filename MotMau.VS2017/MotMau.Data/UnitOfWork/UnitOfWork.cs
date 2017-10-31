using MotMau.Data.ProductRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace MotMau.Data.UnitOfWork
{
    public class UnitOfWork:IUnitOfWork
    {
        private MotMauDataContext _motMauDataContext;
        private IProductRepository _productRepository;

        public UnitOfWork(MotMauDataContext motMauDataContext)
        {
            _motMauDataContext = motMauDataContext;
        }

        public IProductRepository ProductRepo
        {
            get
            {
                if (_productRepository == null)
                {
                    _productRepository = new ProductRepository.ProductRepository(_motMauDataContext);
                }
                return _productRepository;
            }
        }

        public int Commit()
        {
            return _motMauDataContext.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_motMauDataContext != null)
                {
                    _motMauDataContext.Dispose();
                    _motMauDataContext = null;
                }
            }
        }
    }
}
