using System.Collections.Generic;
using System.Linq;

namespace BabyShop.Models
{

    public class FakeProductRepository : IProductRepository
    {
        //Mocked collection of available products
        //Implemented interface of product repository
        public IQueryable<Product> Products => new List<Product> {
            new Product { Name = "Kolica Baby Merc", Price = 250 },
            new Product { Name = "Nosiljka Bazzinga", Price = 100 },
            new Product { Name = "Cipelice Sova", Price = 50 }
        }.AsQueryable<Product>();
    }
} 