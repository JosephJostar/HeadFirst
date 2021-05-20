using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public abstract class PizzaStore
    {
       /* SimplePizzaFactory factory;

        public PizzaStore(SimplePizzaFactory pizzaFactory)
        {
            factory = pizzaFactory;
        }*/

        public Pizza orderPizza(string type)
        {
            Pizza oPizza = CreatePizza(type);
            oPizza.prepare();
            oPizza.bake();
            oPizza.cut();
            oPizza.box();
            return oPizza;
        }

        protected abstract Pizza CreatePizza(string type);
    }
}
