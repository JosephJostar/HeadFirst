using System;
using static System.Console;

namespace TemplatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            TeaWithHook teaWithHook = new TeaWithHook();
            CoffeeWithHook coffeeWithHook = new CoffeeWithHook();

            WriteLine("\nMaking tea...");
            teaWithHook.PrepareRecipe();

            WriteLine("\nMaking coffee...");
            coffeeWithHook.PrepareRecipe();
        }
    }
}
