using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace IteratorModel
{
    public class CompositeIterator : IEnumerator
    {
        public object Current => throw new NotImplementedException();

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
