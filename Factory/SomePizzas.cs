using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Factory
{
    //public class NYStyleChessPizza: Pizza
    // {
    //     public NYStyleChessPizza()
    //     {
    //         name = "NY Style Sauce and Cheese Pizza";
    //         dough = "Thin Crust Dough";
    //         sauce = "Marinara Sauce";

    //         topping.Add("Grated Reggiano Cheese");
    //     }
    // }

    // public class ChicagoStyleCheesePizza: Pizza
    // {
    //     public ChicagoStyleCheesePizza()
    //     {
    //         name = "Chicago Style Deep Dish Cheese Pizza";
    //         dough = "Extra Thick Crust Dough";
    //         sauce = "Plum Tomato Sauce";

    //         topping.Add("Shredded Mozzarella Cheese");
    //     }

    //     public override void cut()
    //     {
    //         WriteLine("Cutting the pizza into square slices");
    //     }
    // }

    public class CheesePizza : Pizza
    {
        PizzaIngredientFactory ingredientFactory;

        public CheesePizza(PizzaIngredientFactory PizzaingredientFactory) //原料工厂
        {
            ingredientFactory = PizzaingredientFactory;
        }

        public override void prepare()
        {
            WriteLine("Perparing " + name);
            dough = ingredientFactory.createDough();
            sauce = ingredientFactory.createSauce();
            cheese = ingredientFactory.createCheese();
        }
    }

    public class ClamPizza : Pizza
    {
        PizzaIngredientFactory ingredientFactory;

        public ClamPizza(PizzaIngredientFactory PizzaingredientFactory) //原料工厂
        {
            ingredientFactory = PizzaingredientFactory;
        }

        public override void prepare()
        {
            WriteLine("Perparing " + name);
            dough = ingredientFactory.createDough();
            sauce = ingredientFactory.createSauce();
            cheese = ingredientFactory.createCheese();
            clam = ingredientFactory.createClam();
        }
    }

    public class VeggiePizza : Pizza
    {
        PizzaIngredientFactory ingredientFactory;

        public VeggiePizza(PizzaIngredientFactory PizzaingredientFactory) //原料工厂
        {
            ingredientFactory = PizzaingredientFactory;
        }

        public override void prepare()
        {
            WriteLine("Perparing " + name);
            dough = ingredientFactory.createDough();
            sauce = ingredientFactory.createSauce();
            veggies = ingredientFactory.createVeggies();
        }
    }

    public class PepperoniPizza : Pizza
    {
        PizzaIngredientFactory ingredientFactory;

        public PepperoniPizza(PizzaIngredientFactory PizzaingredientFactory) //原料工厂
        {
            ingredientFactory = PizzaingredientFactory;
        }

        public override void prepare()
        {
            WriteLine("Perparing " + name);
            dough = ingredientFactory.createDough();
            sauce = ingredientFactory.createSauce();
            pepperoni = ingredientFactory.createPepperoni();
        }
    }
}
