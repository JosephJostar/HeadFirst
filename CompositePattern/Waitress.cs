using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using static System.Console;

namespace CompositePattern
{
    public class Waitress
    {
        readonly Menu allMenus;

        public Waitress(Menu allMenus)
        {
            this.allMenus = allMenus;
        }

        public void printMenu()
        {
            allMenus.Print();
        }

        public void PrintVegetarianMenu()
        {
            IEnumerator enumerator = allMenus.CreateIterator();
            WriteLine("\nVEGETARIAN MENU\n--------");
            while (enumerator.MoveNext())
            {
                MenuComponent menuComponent = (MenuComponent)enumerator.Current;

                try
                {
                    if (menuComponent.IsVegetarian())
                    {
                        menuComponent.Print();
                    }
                }
                catch (NotImplementedException ex)
                {
                    WriteLine(ex.Message);
                }
            }
        }
    }
}
