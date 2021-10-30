using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class PizzaNapolitana:Pizza
    {
        public PizzaNapolitana()
        {
            Console.WriteLine("Pizza Napolitana");
        }
    }
}
