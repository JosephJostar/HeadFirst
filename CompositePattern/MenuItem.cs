using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.Collections;

namespace CompositePattern
{
    public class MenuItem : MenuComponent
    {
        readonly string name;
        readonly string description;
        readonly bool vegetarian;
        readonly double price;

        public MenuItem(string name, string description, bool vegetarian, double price)
        {
            this.name = name;
            this.description = description;
            this.vegetarian = vegetarian;
            this.price = price;
        }

        public override string GetName()
        {
            return name;
        }

        public override string GetDescription()
        {
            return description;
        }

        public override double GetPrice()
        {
            return price;
        }

        public override bool IsVegetarian()
        {
            return vegetarian;
        }

        public override void Print()
        {
            Write("    " + GetName());
            if (IsVegetarian())
            {
                Write("(v)");
            }
            WriteLine(",  " + GetPrice());
            WriteLine("     -- " + GetDescription());
        }

        public IEnumerator CreateIterator()
        {
            return new NullIterator();
        }
    }

    public class NullIterator : IEnumerator
    {
        public object Current => null;

        public bool MoveNext()
        {
            return false;
        }

        public void Reset()
        {
            
        }
    }
}
