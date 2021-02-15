using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class myList<T>
    {
        T[] _array;
        public myList()
        {
            _array = new T[0];
        }
        public void Add(T item)
        {

        }
        private int _count;

        public int Count
        {
            get { return _array.Length; }
           
        }

    }
}
