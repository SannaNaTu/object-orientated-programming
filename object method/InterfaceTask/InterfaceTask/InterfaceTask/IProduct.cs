using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTask
{
    interface IProduct
    {
        string GetProduct(string name);
        double CountValue();
    }
}