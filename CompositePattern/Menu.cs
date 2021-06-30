using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.Collections;

namespace CompositePattern
{
    public class Menu : MenuComponent
    {
        readonly List<MenuComponent> menuComponents = new List<MenuComponent>();
        readonly string name;
        readonly string description;

        public Menu(string name, string description)
        {
            this.name = name;
            this.description = description;
        }

        public override void Add(MenuComponent menuComponent)
        {
            menuComponents.Add(menuComponent);
        }

        public override void Remove(MenuComponent menuComponent)
        {
            menuComponents.Remove(menuComponent);
        }

        public override MenuComponent GetChild(int i)
        {
            return menuComponents[i];
        }

        public override string GetName()
        {
            return name;
        }

        public override string GetDescription()
        {
            return description;
        }

        public override void Print()
        {
            Write("\n" + GetName());
            WriteLine(", " + GetDescription());
            WriteLine("----------------------");

            IEnumerator<MenuComponent> enumerator = menuComponents.GetEnumerator();
            while (enumerator.MoveNext())
            {
                MenuComponent menuComponent = enumerator.Current;
                menuComponent.Print();
            }
        }

        public IEnumerator CreateIterator()
        {
            return new CompositeIterator(menuComponents.GetEnumerator());
        }
    }
}

