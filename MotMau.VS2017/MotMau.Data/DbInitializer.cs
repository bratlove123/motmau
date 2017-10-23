using MotMau.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MotMau.Data
{
    public static class DbInitializer
    {
        public static void Initialize(MotMauDataContext context)
        {
            context.Database.EnsureCreated();

            if (context.Products.Any())
            {
                return;
            }

            var products = new Product[]
            {
                new Product{Id="SP01", ProductName="Ao quan day"},
                new Product{Id="SP02", ProductName="Ao den day"}
            };

            foreach (Product p in products)
            {
                context.Products.Add(p);
            }
            context.SaveChanges();
        }
    }
}
