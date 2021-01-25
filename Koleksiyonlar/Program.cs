using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] { "engin", "murat", "kerem", "halil" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);
            //diziler oluşturuldukları andaki sınırlara bağlı kalır ve yeni bir eleman ekleyemeyiz bu yüzden koleksiyonlar kullanılır.
            //aslında isimler = new string[5]; ile eklenebilir ama bu seferde sıfırdan oluşturulduğu için sadece ekleyeceğimiz ifade yazdırılabilir.
            List<string> isimler2 = new List<string>();
            isimler2.Add("Engin");
            //istenirse koleksiyonlar içi dolu başlatılabilir.----> List<string> isimler2 = new List<string>{"ahmet","mehmet"};

        }
    }
}
