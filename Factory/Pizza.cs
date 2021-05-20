using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.Collections;

namespace Factory
{
    public abstract class Pizza
    {
        public string name;
        public Dough dough;
        public Sauce sauce;
        public Veggies[] veggies;
        public Cheese cheese;
        public Pepperoni pepperoni;
        public Clams clam;
        
        //public List<string> topping = new List<string>();

        //public void prepare()
        //{
        //    WriteLine("Preparing " + name);
        //    WriteLine("Tossing dough: " + dough);
        //    WriteLine("Adding sauce: " + sauce);
        //    WriteLine("Adding toppings: ");
        //    for (int i = 0; i< topping.Count; i++)
        //    {
        //        WriteLine("   " + topping[i].ToString());
        //    }
        //}

        public abstract void prepare();

        public virtual void bake()
        {
            WriteLine("Bake for 25 Minutes at 350");
        }

        public virtual void cut()
        {
            WriteLine("Cutting the pizza into diagonal slices");
        }

        public virtual void box()
        {
            WriteLine("Place pizza in official PizzaStore box");
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public virtual string getName()
        {
            return name;
        }

        public string toString()
        {
            return name;
        }
    }
}
