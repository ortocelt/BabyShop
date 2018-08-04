using System.Collections.Generic;
using BabyShop.Models;

namespace BabyShop.Models.ViewModels
{

    public class ProductsListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
        public string CurrentCategory { get; set; }
    }
}