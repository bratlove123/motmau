using MotMau.Core.Domain;

namespace MotMau.Services.Product
{
    public interface IProductService
    {
        MotMau.Core.Domain.Product GetFirstProduct();
    }
}
