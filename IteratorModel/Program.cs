using System;
using System.Collections;
using System.Collections.Generic;

namespace IteratorModel
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }
            //PancakeHouseMenu pancakeHouseMenu = new PancakeHouseMenu();
            //DinerMenu dinerMenu = new DinerMenu();

            //Waitress waitress = new Waitress(pancakeHouseMenu, dinerMenu);

            IMenu pancakeHouseMenu = new PancakeHouseMenu();
            IMenu  dinerMenu = new DinerMenu();
            IMenu cafeMenu = new CafeMenu();
            //IMenu[] arrayMenu = { pancakeHouseMenu, dinerMenu, cafeMenu };

            List<IMenu> menus = new List<IMenu>{ pancakeHouseMenu, dinerMenu, cafeMenu };
            

            Waitress waitress = new Waitress(menus);

            waitress.PrintMenu();
        }
    }
}
