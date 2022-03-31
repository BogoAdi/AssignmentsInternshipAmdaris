using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAssignment
{
    class Garden<T> where T : class
    {
        public int index;
        public T[] items = new T[1];
        public int limit = 1;
        public Garden() { 
            index = 0;
        }
        public T getItemAtIndex(int index)
        {
            return items[index];
        }
        public void setItemAtIndex(int index, T item)
        {
            items[index] = item ;

        }
        public void swapItems(int index1, int index2)
        {
            T aux=items[index1];
            items[index1] = items[index2];
            items[index2] = aux;

        }
        public void AddItem(T item)
        {
            if(index== limit)
            {
                T[] ts = new T[limit*2];
                for(int i = 0; i < limit; i++)
                {
                    ts[i] = getItemAtIndex(i);
                }
                 items = ts;
                limit = limit*2;
            }
            items[index++]=item;

        }
        public void PrintAll()
        {
           for(int i=0; i<limit; i++)
            {
               Console.WriteLine(items[i]);
            }
        }

    }
}
