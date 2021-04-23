using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyDictionary<T,Y>
    {
        T[] items;
        Y[] ids;
        public MyDictionary()
        {
            items = new T[0];
            ids = new Y[0];
        }
        public void Add(T item, Y id)
        {
            T[] tempItems = items;
            Y[] tempIds = ids;
            items = new T[items.Length + 1];
            ids = new Y[ids.Length + 1];

            for (int i = 0; i < tempItems.Length; i++)
            {
                items[i] = tempItems[i];
            }

            for (int i = 0; i < tempIds.Length; i++)
            {
                ids[i] = tempIds[i];
            }

            items[items.Length - 1] = item;
            ids[ids.Length - 1] = id;
        }

        public int Length
        {
            get { return items.Length; }
        }

        public T[] Items
        {
            get { return items; }
        }

        public Y[] Ids
        {
            get { return ids; }
        }
    }
}
