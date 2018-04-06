using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTask
{
    // 3.4 Mitäpä tästä opimme. en ollu laittanu GIttiin tiedostoa ja jostain syystä filu oli viottunu koneella.. tässä mitä sain pelastettua. Joten duunailen muut sitten uudestaan ! 
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            List<Product> product = new List<Product>();
            product.Add(new Product("Tuote1", 32, 3));
            product.Add(new Product("Tuote2", 52, 5));
            product.Add(new Product("Tuote3", 76, 3));


            Console.WriteLine(product[0].GetProduct("Tuote1"));
            Console.WriteLine(product[0].CountValue());

            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer("Santeri", 1200));
            customers.Add(new Customer("Salli", 200));
            customers.Add(new Customer("Sieppo", 800));

            customers[0].GetCustomer();
            customers[0].CountBonus();
            customers[1].GetCustomer();
            customers[1].CountBonus();
            customers[2].GetCustomer();
            customers[2].CountBonus();

            Store store = new Store("Pikkukauppa", 8000);
            store.AddCustomer(new Customer("Kyllikki",2000));
            store.AddProducts(new Product("Kynä",200,200));
            store.PrintCustomers();
            store.PrintProducts();
            Console.ReadKey();
        }
        //en oo varma tekeekö kaiken mitä piti, mut aika paljon kaikenlaista
        
    }
}
