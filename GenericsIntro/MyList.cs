using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        public MyList()
        {
            items = new T[0];   //Bu alanın ismi constructor, class new'lenince bu alanda new'leniyor.
        }
        public void Add(T item)
        {
            T[] tempArray = items; //referans numaram kaybolmasın diye geçiçi bir array atadım.
            items = new T[items.Length+1];  //Eleman sayısının 1 arttırdım.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i]; //vermiş olduğum değerleri geri aldım.

            }
            items[items.Length - 1] = item; //

        }
        public int Length
        {
            get { return items.Length; }
        }

        public T[] Items
        {
            get { return items; }
        }
    }
}
