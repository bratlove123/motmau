using MotMau.Data.ProductRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace MotMau.Data.UnitOfWork
{
    public interface IUnitOfWork:IDisposable
    {
        IProductRepository ProductRepo { get; }
        int Commit();
    }
}
