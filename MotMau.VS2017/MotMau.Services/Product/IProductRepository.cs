using MotMau.Core.Domain;

namespace MotMau.Services.Product
{
    public interface IProductRepository
    {
        MotMau.Core.Domain.Product GetFirstProduct();
    }
}
