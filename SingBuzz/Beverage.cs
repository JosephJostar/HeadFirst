using System;
using System.Collections.Generic;
using System.Text;

namespace SingBuzz
{
    public abstract class Beverage
    {
        public string description = "Unknown Beverage";


        public virtual string getDescription()
        {
            return description;
        }

        public abstract double cost();
    }
}
