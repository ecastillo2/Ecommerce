﻿using Ecommerce.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Application.ViewModels
{
    public class CosmeticViewModel : Product
    {

        public string Size { get; set; }

        public string Color { get; set; }

        public string Gender { get; set; }
        public override int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string ProductType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string ProductDetails { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string imageOne { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string imageTwo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string imageThree { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override int Value { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override ICollection<Stock> Stock { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override ICollection<OrderProduct> OrderProducts { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}