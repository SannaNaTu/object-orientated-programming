using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceTask
{
    class Product : IProduct
    {
        //Fields
        public string Name;
        public double Price;
        public double Count;

        //Constructor
        public Product(string name, double price, double count)
        {
            Name = name;
            Price = price;
            Count = count;
        }
        //Override ToString
        public override string ToString()
        {
            return ($"\n{Name}\n" +
                $"{Price}\n" +
                $"{Count}\n");
        }

        //Interface Methods
        public string GetProduct(string name)
        {

            if (name == Name)
            {
                return $"{name} löytyi! ";
            }
            else
                return null;
        }

        public  double CountValue()
        {

            return Price * Count;
        }
    }
}
