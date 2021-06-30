using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.IO;

namespace TemplatePattern
{
    public class CoffeeWithHook : CaffeineBeverage
    {
        public override void AddCondiments()
        {
            WriteLine("Adding Sugar and Milk");
        }

        public override void Brew()
        {
            WriteLine("Dripping Coffee through filter");
        }

        public override bool CustomerWantsCondiments()
        {
            string answer = GetUserInput();

            if(answer.ToLower().StartsWith("y"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private string GetUserInput()
        {
            string answer = "";
            Write("Would you like milk and sugar with your coffee (y/n)? ");

            try
            {
                answer = ReadLine();
            }
            catch (IOException ex)
            {
                WriteLine("IO error trying to read your answer, message: " + ex.Message);
            }

            if (answer == "")
                return "no";

            return answer;
        }
    }
}
