using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public interface PizzaIngredientFactory  //原料工厂接口
    {
        public Dough createDough();
        public Sauce createSauce();
        public Cheese createCheese();
        public Veggies[] createVeggies();
        public Pepperoni createPepperoni();
        public Clams createClam();
    }
}
