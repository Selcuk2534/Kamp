using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro//Generic konusuna giriş
{
    class MyList<T>//Buradaki T harfi özel bir anlam ifade etmiyor A da olabilirdi ama type'dan aklımızda kalsın diye T verdik
    {
        T[] items;
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)//T vermemizin amacı biz ona T olarak ne verirsek ona göre değer alabilecek olması(T,string olabilir)
        {
            T[] tempArray = items;
            items = new T[items.Length +1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;
        }
    }
}
