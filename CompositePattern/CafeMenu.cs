﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using static System.Console;

namespace CompositePattern
{
    public class CafeMenu : MenuComponent
    {
        readonly Hashtable menuItems = new Hashtable();

        public CafeMenu()
        {
            AddItem("Veggie Burger and Air Fries", "Veggie burger on a whole wheat bun, lettuce, tomato, and fries",
                true, 3.99);

            AddItem("Soup of the day", "A cup of the soup of the day, with a side saled",
                false, 3.69);

            AddItem("Burrito", "A large burrito, with whole pinto beans, salsa, guacamole",
                true, 4.29);
        }

        public void AddItem(string name, string description, bool vegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);

            menuItems.Add(menuItem.GetName(), menuItem);
        }

        public IEnumerator CreateIterator()
        {
            return menuItems.Values.GetEnumerator();
        }
    }
}
