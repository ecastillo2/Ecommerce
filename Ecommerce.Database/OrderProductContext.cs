using Ecommerce.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Database
{
    public class OrderProductContext : DbContext
    {
        public OrderProductContext(DbContextOptions<OrderProductContext> options) : base(options)
        {

        }

        public DbSet<Order> Order { get; set; }
    }
}
