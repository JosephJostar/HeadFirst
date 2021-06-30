using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace TemplatePattern
{
    public abstract class CaffeineBeverage
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();           
            if(CustomerWantsCondiments())
            {
                AddCondiments();
            }
        }

        public abstract void Brew();

        public abstract void AddCondiments();

        public virtual void BoilWater()
        {
            WriteLine("Boiling water");
        }

        public virtual void PourInCup()
        {
            WriteLine("Pouring into cup");
        }

        public virtual bool CustomerWantsCondiments()
        {
            return true;
        }
    }
}
