using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Domain.Models
{
    public class Cosmetic : Product
    {
        //Shared Variables
        private int _Id;
        public override int Id {
            get {

                return _Id;
            }
            set
            {

            }
           
        }

        private string _ProductType;
        public override string ProductType
        {
            get
            {

                return _ProductType;
            }
            set
            {

            }

        }

        private string _ProductDetails;
        public override string ProductDetails
        {
            get
            {

                return _ProductDetails;
            }
            set
            {

            }

        }
        public override string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string imageOne { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string imageTwo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string imageThree { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override int Price { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override string TrackingNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override ICollection<Stock> Stock { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override ICollection<OrderProduct> OrderProducts { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


        //Specific Datatype Variables
        private string _Size;
        public string Size
        {
            get
            {

                return _Size;
            }
            set
            {

            }

        }

        private string _Color;
        public string Color
        {
            get
            {

                return _Color;
            }
            set
            {

            }

        }

        private string _Gender;
        public string Gender
        {
            get
            {

                return _Gender;
            }
            set
            {

            }

        }
    }
}
