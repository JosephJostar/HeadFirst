using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.Collections;

namespace IteratorModel
{
    public interface IMenu
    {
        public IEnumerator CreateIterator();
    }

    public class Waitress
    {
        //readonly PancakeHouseMenu pancakeHouseMenu;
        //readonly DinerMenu dinerMenu;

        //readonly IMenu pancakeHouseMenu;
        //readonly IMenu dinerMenu;
        //readonly IMenu cafeMenu;

        readonly List<IMenu> menus;


        //public Waitress(PancakeHouseMenu pancakeHouseMenu, DinerMenu dinerMenu)
        //public Waitress(IMenu pancakeHouseMenu, IMenu dinerMenu, IMenu cafeMenu)
        //{
        //    this.pancakeHouseMenu = pancakeHouseMenu;
        //    this.dinerMenu = dinerMenu;
        //    this.cafeMenu = cafeMenu;
        //}

        public Waitress(List<IMenu> menus)
        {
            this.menus = menus;
        }

        //public void PrintMenu()
        //{
        //    //IIterator pancakeIterator = pancakeHouseMenu.CreateIterator();
        //    //IIterator dinerIterator = dinerMenu.CreateIterator();

        //    IEnumerator pancakeIterator = pancakeHouseMenu.CreateIterator();
        //    IEnumerator dinerIterator = dinerMenu.CreateIterator();
        //    IEnumerator cafeIterator = cafeMenu.CreateIterator();

        //    WriteLine("Menu\n----\nBREAKFAST");
        //    PrintMenu(pancakeIterator);
        //    WriteLine("\nLUNCH");
        //    PrintMenu(dinerIterator);
        //    WriteLine("\nDINNER");
        //    PrintMenu(cafeIterator);
        //}

        public void PrintMenu()
        {
            IEnumerator menuIterator = menus.GetEnumerator();
            while(menuIterator.MoveNext())
            {
                IMenu menu = (IMenu)menuIterator.Current;
                PrintMenu(menu.CreateIterator());
            }
        }

        //private void printMenu(IIterator iterator)
        //{
        //    while(iterator.HasNext())
        //    {
        //        MenuItem menuItem = (MenuItem)iterator.Next();
        //        Write(menuItem.GetName() + ", ");
        //        Write(menuItem.GetPrice() + " -- ");
        //        WriteLine(menuItem.GetDescription() + "\n");
        //    }
        //}

        private void PrintMenu(IEnumerator iterator)
        {
            while (iterator.MoveNext())
            {
                MenuItem menuItem = (MenuItem)iterator.Current;
                if(menuItem == null)
                    return;
                Write(menuItem.GetName() + ", ");
                Write(menuItem.GetPrice() + " -- ");
                WriteLine(menuItem.GetDescription() + "\n");
            }
        }
    }
}
