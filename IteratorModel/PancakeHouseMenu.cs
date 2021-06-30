using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorModel
{
    public class PancakeHouseMenu: IMenu
    {
        readonly List<MenuItem> menuItems;

        public PancakeHouseMenu()
        {
            menuItems = new List<MenuItem>();

            AddItem("K&B's Pancake Breakfast",
                    "Pancakes with scrambled eggs, and toast",
                    true,
                    2.99);

            AddItem("Regular Pancake Breakfast",
                    "Pancakes with fried eggs, sausage",
                    false,
                    2.99);

            AddItem("Blueberry Pancake",
                    "Pancakes made with fresh blueberries",
                    true,
                    3.49);

            AddItem("Waffles",
                    "Waffles, with your choice of blueberries of strawberries",
                    true,
                    3.59);
        }

        public void AddItem(string name, string description, bool vegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
            menuItems.Add(menuItem);
        }

        //public List<MenuItem> GetMenuItems()
        //{
        //    return menuItems;
        //}

        //public IIterator CreateIterator()
        //{
        //    return new PancakeHouseMenuIterator(menuItems);
        //}

        public IEnumerator CreateIterator()
        {
            return menuItems.GetEnumerator();
        }
    }
}
