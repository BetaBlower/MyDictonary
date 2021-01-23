using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictonary
{
    class MyDictionary<T>
    {
        T[] arrays;
        public MyDictionary()
        {
            arrays = new T[0];
        }
        public void Add(T array)
        {
            T[] temparray = arrays;
            arrays = new T[arrays.Length + 1];
            for (int i = 0; i < temparray.Length; i++)
            {
                arrays[i] = temparray[i];
            }
            arrays[arrays.Length - 1] = array;
        }
    }
}
