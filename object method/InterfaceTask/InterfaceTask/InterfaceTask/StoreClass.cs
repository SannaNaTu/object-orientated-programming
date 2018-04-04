using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceTask
{
    class Store : ICustomers, IProducts
    {
        //Fields
        public string Name;
        public int Business;
        public List<Product> products = new List<Product>();
        public List<Customer> customers = new List<Customer>();

        public Store(string name, int business)
        {
            Name = name;
            Business = business;
        }
        //Override ToString
        public override string ToString()
        {
            return ($"\n{Name}\n{Business:C}\n");
        }
        //Interface Product 
        public void AddProducts(Product product)
        {
            products.Add(product);
        }


        public void PrintProducts()
        {
            Console.WriteLine($"Tuotteiden määrä: {products.Count}");

            foreach (var p in products)
            {
                Console.WriteLine(p);
            }
        }

        //Interface Customer
        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }

        public void PrintCustomers()
        {
            Console.WriteLine($"Asiakkaiden määrä: {customers.Count}");

            foreach (var c in customers)
            {
                Console.WriteLine(c);
            }

        }
    }
}
