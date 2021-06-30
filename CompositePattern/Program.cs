﻿using System;
using static System.Console;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuComponent pancakeHouseMenu =
                new Menu("PANCAKE HOUSE MENU", "Breakfast");
            MenuComponent dinerMenu =
                new Menu("DINER MENU", "Lunch");
            MenuComponent cafeMenu =
                new Menu("CAFE MENU", "Dinner");
            MenuComponent dessertMenu =
                new Menu("DESSERT MENU", "Dessert of course!");

            Menu allMenus = new Menu("ALL MENUS", "All menus Combined");

            allMenus.Add(pancakeHouseMenu);
            allMenus.Add(dinerMenu);
            allMenus.Add(cafeMenu);

            pancakeHouseMenu.Add(new MenuItem("K&B's Pancake Breakfast",
                    "Pancakes with scrambled eggs, and toast",
                    true,
                    2.99));

            pancakeHouseMenu.Add(new MenuItem("Regular Pancake Breakfast",
                    "Pancakes with fried eggs, sausage",
                    false,
                    2.99));

            pancakeHouseMenu.Add(new MenuItem("Blueberry Pancake",
                    "Pancakes made with fresh blueberries",
                    true,
                    3.49));

            pancakeHouseMenu.Add(new MenuItem("Waffles",
                    "Waffles, with your choice of blueberries of strawberries",
                    true,
                    3.59));


            dinerMenu.Add(new MenuItem("Vegetarian BLT",
                    "(Fakin') Bacon with lettuce & tomato on whole wheat", true, 2.99));

            dinerMenu.Add(new MenuItem("BLT",
                    "Bacon with lettuce & tomato on whole wheat", false, 2.99));

            dinerMenu.Add(new MenuItem("Soup of the day",
                    "Soup of the day, with a side of potato salad", false, 3.29));

            dinerMenu.Add(new MenuItem("Hot dog",
                    "A hot dog, with sauerkraut, relish onions, topped with cheese", false, 3.05));

            dinerMenu.Add(new MenuItem(
                "Pasta",
                "Spaghetti with Marinara Sauce, and a slice of sourdough bread",
                true,
                3.89));

            dinerMenu.Add(dessertMenu);

            dessertMenu.Add(new MenuItem(
                "Apple Pie",
                "Apple pie with a flakey crust, topped with vanilla ice cream",
                true,
                1.59));


            cafeMenu.Add(new MenuItem("Veggie Burger and Air Fries", "Veggie burger on a whole wheat bun, lettuce, tomato, and fries",
                true, 3.99));

            cafeMenu.Add(new MenuItem("Soup of the day", "A cup of the soup of the day, with a side saled",
                false, 3.69));

            cafeMenu.Add(new MenuItem("Burrito", "A large burrito, with whole pinto beans, salsa, guacamole",
                true, 4.29));


            Waitress waitress = new Waitress(allMenus);

            //waitress.printMenu();

            //WriteLine("\n=============================\n");

            waitress.PrintVegetarianMenu();


        }
    }
}
