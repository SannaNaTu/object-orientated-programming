using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskProductInterface
{
    interface IProducts
    {
        void AddProducts(List<Product> product);
        void PrintProducts();
    }
}