using System;
using static System.Console;

namespace State_Pattern
{
    
    class Program
    {
        static void Main(string[] args)
        {
            GumballMachine gumballMachine = new GumballMachine(5);

            WriteLine("gumballMachine has " + gumballMachine.GetCount() + " gumballs");

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            WriteLine("gumballMachine has " + gumballMachine.GetCount() + " gumballs");

            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank(); 
            gumballMachine.InsertQuarter();
            gumballMachine.TurnCrank();

            WriteLine("gumballMachine has " + gumballMachine.GetCount() + " gumballs");
        }
    }
}
