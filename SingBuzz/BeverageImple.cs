using System;
using System.Collections.Generic;
using System.Text;

namespace SingBuzz
{
    class BeverageImple
    {
        public class Espresso : Beverage
        {
            public Espresso()
            {
                description = "Espresso";
            }

            public override double cost()
            {
                return 1.99;
            }
        }

        public class HouseBlend : Beverage
        {
            public HouseBlend()
            {
                description = "House Blend Coffee";
            }

            public override double cost()
            {
                return .89;
            }
        }

        public class DarkRoast : Beverage
        {
            public DarkRoast()
            {
                description = "DarkRoast";
            }

            public override double cost()
            {
                return .99;
            }
        }
    }
}
