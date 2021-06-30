using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace IteratorModel
{
    public interface IIterator
    {
        bool HasNext();
        object Next();
    }

    public class DinerMenuIterator : IEnumerator, IEnumerable //IIterator
    {
        readonly MenuItem[] items;
        int position = 0;
        MenuItem menuItem;

        public DinerMenuIterator(MenuItem[] items)
        {
            this.items = items;
        }

        public object Current
        {
            get
            {
                return menuItem;
            }
        }

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            if (position >= items.Length || items[position] == null)
            {
                return false;
            }
            else
            {
                menuItem = items[position];
                position++;
                return true;
            }

        }

        public void Reset()
        {
            position = 0;
        }

        //public bool HasNext()
        //{
        //    if (position >= items.Length || items[position] == null)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        return true;
        //    }
        //}

        //public object Next()
        //{
        //    MenuItem menuItem = items[position];
        //    position++;
        //    return menuItem;
        //}
    }

    //public class PancakeHouseMenuIterator: IIterator
    //{
    //    readonly List<MenuItem> items;
    //    int position = 0;

    //    public PancakeHouseMenuIterator(List<MenuItem> items)
    //    {
    //        this.items = items;
    //    }

    //    public bool HasNext()
    //    {
    //        if (position >= items.Count || items[position] == null)
    //        {
    //            return false;
    //        }
    //        else
    //        {
    //            return true;
    //        }
    //    }

    //    public object Next()
    //    {
    //        MenuItem menuItem = items[position];
    //        position++;
    //        return menuItem;
    //    }
    //}
}
