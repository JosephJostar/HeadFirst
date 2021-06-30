using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace CompositePattern
{
    public class CompositeIterator : IEnumerator
    {
        Stack stack = new Stack();
        readonly Stack stackRetset = new Stack();
      
        public CompositeIterator(IEnumerator enumerator)
        {
            stack.Push(enumerator);
            stackRetset = stack;
        }

        public object Current
        {
            get
            {         
                if (MoveNext())
                {
                    IEnumerator enumerator = (IEnumerator)(stack.Peek());
                    object obj = enumerator.Current;
                    //MenuComponent component = (MenuComponent)enumerator.Current;
                    //if (component is Menu menu)
                    //{
                    //    stack.Push(menu.CreateIterator());
                    //}
                    return obj;
                }
                else
                {
                    return null;
                }
            }
        }

        public bool MoveNext()
        {
            if (stack.Count <= 0)
            {
                return false;
            }
            else
            {
                IEnumerator enumerator = (IEnumerator)stack.Peek();
                if(!enumerator.MoveNext())
                {
                    stack.Pop();
                    return MoveNext();
                }
                else
                {
                    MenuComponent component = (MenuComponent)enumerator.Current;
                    if (component is Menu menu)
                    {
                        IEnumerator enumeratorMenu = menu.CreateIterator();
                        stack.Push(enumeratorMenu);
                        //if (!(enumeratorMenu.Current is MenuItem))
                        //{
                        //    MoveNext();
                        //}
                    }
                    return true;
                }
            }
        }

        public void Reset()
        {
            stack = stackRetset;
        }
    }
}
