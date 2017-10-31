using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MotMau.Data.UnitOfWork;
using MotMau.Data;
using MotMau.Core.Domain;

namespace MotMau.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/Product")]
    public class ProductController : Controller
    {
        private IUnitOfWork _unitOfWork;

        public ProductController(MotMauDataContext context)
        {
            _unitOfWork = new UnitOfWork(context);
        }

        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            return _unitOfWork.ProductRepo.Table;
        }
    }
}