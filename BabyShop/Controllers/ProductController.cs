using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BabyShop.Models;
using BabyShop.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BabyShop.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository repository;
        public int pageSize = 4;

        public ProductController(IProductRepository repo)
        {
            repository = repo;
        }

        //4 products are selected to be represented on the view
        //it is configured by pageSize field
        //Skip takes out first n products from the view
        //default value is 1, so it Skips 0 products
        //Take shows Products from the database as 
        //described in pageSize field

        public ViewResult List(string category, int productPage = 1)
            => View(new ProductsListViewModel
            {
                Products = repository.Products
                    .Where(p => category == null || p.Category == category)
                    .OrderBy(p => p.ProductID)
                    .Skip((productPage - 1) * pageSize)
                    .Take(pageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = productPage,
                    ItemsPerPage = pageSize,
                    TotalItems = category == null ? 
                        repository.Products.Count() :
                        repository.Products.Where(e => 
                            e.Category == category).Count()
                },
                CurrentCategory = category
            });

    }
}