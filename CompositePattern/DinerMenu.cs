using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using static System.Console;

namespace CompositePattern
{
    public class DinerMenu : MenuComponent
    {
        private const int MAX_ITEMS = 6;
        int numberOfItems = 0;
        readonly MenuItem[] menuItems;

        public DinerMenu()
        {
            menuItems = new MenuItem[MAX_ITEMS];

            AddItem("Vegetarian BLT",
                    "(Fakin') Bacon with lettuce & tomato on whole wheat", true, 2.99);

            AddItem("BLT",
                    "Bacon with lettuce & tomato on whole wheat", false, 2.99);

            AddItem("Soup of the day",
                    "Soup of the day, with a side of potato salad", false, 3.29);

            AddItem("Hot dog",
                    "A hot dog, with sauerkraut, relish onions, topped with cheese", false, 3.05);
        }

        public void AddItem(string name, string description, bool vegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            if (numberOfItems >= MAX_ITEMS)
            {
                WriteLine("Sorry, menu is full! Can't add item to menu");
            }
            else
            {
                menuItems[numberOfItems] = menuItem;
                numberOfItems++;
            }
        }

        //public MenuItem[] GetMenuItems()
        //{
        //    return menuItems;
        //}

        //public IIterator CreateIterator()
        //{
        //    return new DinerMenuIterator(menuItems);
        //}

        public IEnumerator CreateIterator()
        {
            return menuItems.GetEnumerator();
            //return new DinerMenuIterator(menuItems);
        }

    }
}
