using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_task
{
    // Mitäpä tästä opimme. en ollu laittanu GIttiin tiedostoa ja jostain syystä filu oli viottunu koneella.. tässä mitä sain pelastettua. Joten duunailen muut sitten uudestaan ! 
    class Program
    {
        static void Main(string[] args)
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            List<Product> product = new List<Product>();
        product.Add(new Product("Tuote1", 32, 3));
            product.Add(new Product("Tuote2", 52, 5));
            product.Add(new Product("Tuote3", 76, 3));
           

            Console.WriteLine(product[0].GetProduct("Tuote1"));
            Console.WriteLine(product[0].CountValue());

       
        
    }
}
