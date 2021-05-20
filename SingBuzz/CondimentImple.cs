using System;
using System.Collections.Generic;
using System.Text;

namespace SingBuzz
{
    //class CondimentImple
    //{
        public class Mocha : CondimentDecorator
        {
            Beverage bever;

            public Mocha(Beverage beverage)
            {
                bever = beverage;
            }

            public override double cost()
            {
                return .20 + bever.cost();
            }

            public override string getDescription()
            {
                return bever.getDescription() + ", Mocha";
            }
        }

        public class Soy : CondimentDecorator
        {
            Beverage bever;

            public Soy(Beverage beverage)
            {
                bever = beverage;
            }

            public override double cost()
            {
                return .15 + bever.cost();
            }

            public override string getDescription()
            {
                return bever.getDescription() + ", Soy";
            }
        }

        public class Whip : CondimentDecorator
        {
            Beverage bever;

            public Whip(Beverage beverage)
            {
                bever = beverage;
            }

            public override double cost()
            {
                return .10 + bever.cost();
            }

            public override string getDescription()
            {
                return bever.getDescription() + ", Whip";
            }
        }
   // }
}
