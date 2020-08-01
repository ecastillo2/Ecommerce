using Ecommerce.Database;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Application.Orders
{
    public class Stock
    {

        private readonly StockContext _context;
        public Stock(StockContext context)
        {
            _context = context;
        }
    }
}
