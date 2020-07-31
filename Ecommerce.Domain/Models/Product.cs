using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Domain.Models
{
    public abstract class Product
    {
        abstract public int Id { get; set; }
        abstract public string Name { get; set; }
        abstract public string ProductType { get; set; }
        abstract public string Description { get; set; }
        abstract public string ProductDetails { get; set; }
        abstract public string imageOne { get; set; }
        abstract public string imageTwo { get; set; }
        abstract public string imageThree { get; set; }
        abstract public int Value { get; set; }
        abstract public ICollection<Stock> Stock { get; set; }
        abstract public ICollection<OrderProduct> OrderProducts { get; set; }
    }
}
