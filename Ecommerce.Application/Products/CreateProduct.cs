using Ecommerce.Application.ViewModels;
using Ecommerce.Database;
using Ecommerce.Domain.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Ecommerce.Application.Products
{
    public class CreateProduct
    {
        private readonly ProductContext _context;
        public CreateProduct(ProductContext context)
        {
            _context = context;
        }

        public async void CreateNewProduct(ClothingViewModel model)
        {
            _context.Product.Add(new Clothing
            {
                Id = model.Id,
                Name = model.Name,
                Description = model.Description,
                Size = model.Size,
            });

            await _context.SaveChangesAsync();
        }

        public async void CreateNewProduct(CosmeticViewModel model)
        {
            _context.Product.Add(new Cosmetic
            {
                Id = model.Id,
                Name = model.Name,
                Description = model.Description,
                Size = model.Size,
            });

            await _context.SaveChangesAsync();
        }
    }
}
