using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lab07_erik
{
    class Inventory<T> : IEnumerable<T>
    {
        T[] items = new T[10];
        int count = 0;

        //Add To Inventory
        public void Add (T item)
        {
            if (count == items.Length)
            {
                int index = count * 2;
                T[] extention = new T[index];
                Array.Copy(items, extention, index);
                items = extention; 
            }
            items[count] = item;
            count++;

            //if statment that will check array limit
            //and make a bigger array to extend inventory size
        }
        // Delete Items
        public void Remove(T item)
        {
            T[] newArray = new T[count -1];
            int tempCount = 0;
            foreach (T p in items)
            {
                if (p != null)
                {
                    if (!p.Equals(item))
                    {
                        newArray[tempCount] = p;
                        tempCount++;
                    }
                }
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for(int i = 0; i < count; i++)
            {
                yield return items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
