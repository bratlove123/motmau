using MotMau.Core.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace MotMau.Core.Domain
{
    public class Product:EntityBase
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
    }
}
