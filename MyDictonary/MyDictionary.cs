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
    class MyDictionary<T,Z>
    {
        T[] arraysT;
        Z[] arraysZ;
        public MyDictionary()
        {
            arraysT = new T[0];
            arraysZ = new Z[0];
        }
        public void Add(T arrayT,Z arrayZ)
        {
            T[] temparrayT = arraysT;
            Z[] temparrayZ = arraysZ;
            arraysT = new T[arraysT.Length + 1];
            for (int i = 0; i < temparrayT.Length; i++)
            {
                arraysT[i] = temparrayT[i];
                arraysZ[i] = temparrayZ[i];
            }
            arraysT[arraysT.Length - 1] = arrayT;
            arraysZ[arraysT.Length - 1] = arrayZ;
        }
    }
}
