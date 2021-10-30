using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class FabricaPizzeriaItaliana : FabricaAbstractaPizzeria
    {
        public override Empanada CrearEmpanada()
        {
           return new EmpanadaCapresse();
        }

        public override Pizza CrearPizza()
        {
            return new PizzaNapolitana();
        }
    }
}
