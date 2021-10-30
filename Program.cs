using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pizzeria argentina: ");
            FabricaAbstractaPizzeria factory = new FabricaPizzeriaArgentina();
            factory.CrearEmpanada();
            factory.CrearPizza();

            Console.WriteLine("Pizzeria italiana: ");
            FabricaAbstractaPizzeria italianFactory = new FabricaPizzeriaItaliana();
            italianFactory.CrearEmpanada();
            italianFactory.CrearPizza();

            Console.ReadLine();
        }
    }
}
