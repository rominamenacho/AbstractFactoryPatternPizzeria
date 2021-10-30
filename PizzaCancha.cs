using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class PizzaCancha:Pizza
    {
        public PizzaCancha()
        {
            Console.WriteLine("Pizza de cancha");
        }
    }
}
