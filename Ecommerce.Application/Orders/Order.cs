using Ecommerce.Database;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Application.Orders
{
    public class Order
    {

        private readonly OrderProductContext _context;
        public Order(OrderProductContext context)
        {
            _context = context;
        }
    }
}
