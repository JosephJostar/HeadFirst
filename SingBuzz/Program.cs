using System;
using static System.Console;

namespace SingBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new BeverageImple.Espresso();
            WriteLine(beverage.getDescription() + ": $" + beverage.cost());

            Beverage beverage2 = new BeverageImple.DarkRoast();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            WriteLine(beverage2.getDescription() + ": $" + beverage2.cost());//通过类包含类的方式，将同名函数全部调用

            Beverage beverage3 = new BeverageImple.HouseBlend();
            beverage3 = new Soy(beverage3);
            beverage3 = new Mocha(beverage3);
            beverage3 = new Whip(beverage3);
            WriteLine(beverage3.getDescription() + ": $" + beverage3.cost());

            var testClass = new thridClass();
            testClass.Test();
            ((secondClass)testClass).Test();
            (testClass as secondClass).Test();
           

        }

        public abstract class firstClass
        {
            public abstract void Test();
        }

        public class secondClass: firstClass
        {
            public override void Test()
            {
                WriteLine("second");
            }
        }

        public class thridClass: secondClass
        {
            public override void Test()
            {
                try
                {
                    WriteLine("Thrid");
                }
                catch(Exception ex)
                {
                    WriteLine(ex.Message);
                }
                finally
                {

                }
            }
        }

    }
}
