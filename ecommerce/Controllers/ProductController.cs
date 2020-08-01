using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Application.Products;
using Ecommerce.Application.ViewModels;
using Ecommerce.Database;
using Ecommerce.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ecommerce.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductContext _productContext;
        CreateProduct createProduct;
        GetProduct getProduct;
        public ProductController(ProductContext productContext)
        {
            _productContext = productContext;
            
        }

        // GET: /<controller>/
        public IActionResult Product()
        {

            //getProduct.GetClothingProducts();

            return View();
        }

        public IActionResult CreateProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateProduct(ClothingViewModel model)
        {

            createProduct.CreateNewProduct(model);

            return View();
        }

        [HttpPost]
        public IActionResult DeleteProduct(ClothingViewModel model)
        {

            createProduct.CreateNewProduct(model);

            return View();
        }

        [HttpPost]
        public IActionResult UpdateProduct(ClothingViewModel model)
        {

            createProduct.CreateNewProduct(model);

            return View();
        }

    }
}
