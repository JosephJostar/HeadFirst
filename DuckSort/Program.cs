using System;
using static System.Console;

namespace DuckSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck[] ducks =
            {
                new Duck("Daffy", 8),
                new Duck("Dewey", 2),
                new Duck("Howard", 7),
                new Duck("Louie", 10),
                new Duck("Huey", 2)
            };

            WriteLine("Before sorting:");
            Display(ducks);

            Array.Sort(ducks);

            WriteLine("\nAfter sorting:");
            Display(ducks);
        }

        public static void Display(Duck[] ducks)
        {
            for(int i = 0; i < ducks.Length; i ++)
            {
                WriteLine(ducks[i].ToString());
            }
        }
    }
}
