using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pizzeria.Domain.Factories
{
    public abstract class PizzaFactory
    {
        public abstract Pizza GetPizza();
    }
}
