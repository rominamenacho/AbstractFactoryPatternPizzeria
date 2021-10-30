﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
   abstract class FabricaAbstractaPizzeria
    {
        public abstract Empanada CrearEmpanada();
        public abstract Pizza CrearPizza();
    }
}
