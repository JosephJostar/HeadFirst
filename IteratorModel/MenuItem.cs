using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorModel
{
    public class MenuItem
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

        public string GetName()
        {
            return name;
        }

        public string GetDescription()
        {
            return description;
        }

        public double GetPrice()
        {
            return price;
        }

        public bool IsVegetarian()
        {
            return vegetarian;
        }
    }
}
