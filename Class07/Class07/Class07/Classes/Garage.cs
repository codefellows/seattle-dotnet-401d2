using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Class07.Classes
{
    class Garage<T> : IEnumerable<T>
    {
        T[] items = new T[10];
        int count = 0;

        public void Add(T item)
        {
            if(count == (items.Length / 2))
            {
                T[] newArray = new T[items.Length * 2];

                for (int i = 0; i < items.Length; i++)
                {
                    newArray[i] = items[i];
                }

                items = newArray;

            }
            items[count] = item;

            
            count++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            //Magic don't touch.
            return GetEnumerator();
        }
    }
}
