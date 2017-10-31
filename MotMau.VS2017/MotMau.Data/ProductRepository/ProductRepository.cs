using MotMau.Core.Domain;
using MotMau.Core.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace MotMau.Data.ProductRepository
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(MotMauDataContext context) : base(context)
        {
        }

        public void getSpecialProduct()
        {
            throw new NotImplementedException();
        }
    }
}
