using MotMau.Core.Domain;
using MotMau.Core.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace MotMau.Data.ProductRepository
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        void getSpecialProduct();
    }
}
