using System;
using static System.Console;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nyStore = new NYPizzaStore();
            PizzaStore chicagoStore = new ChicagoPizzaStore();

            Pizza piz = nyStore.orderPizza("cheese");
            WriteLine("Ethan ordered a " + piz.getName() + "\n");

            //piz = chicagoStore.orderPizza("cheese");
            //WriteLine("Joel ordered a " + piz.getName());
        }
    }
}
