using Ecommerce.Application.ViewModels;
using Ecommerce.Database;
using Ecommerce.Domain.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Ecommerce.Application.Products
{
    public class GetProduct
    {
        private readonly ProductContext _context;
        public GetProduct(ProductContext context)
        {
            _context = context;
        }

        public List<Product> GetClothingProducts()
        {


            return null;
        }

        public List<Product> GetCosmeticProducts()
        {


            return null;
        }
    }
}
