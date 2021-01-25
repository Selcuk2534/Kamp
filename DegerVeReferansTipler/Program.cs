using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        { 
            //Değer tip = int,decimal,float,double,bool
            //Referans tip = array,class,interface

            /*Bellekte stack ve heap adında iki bölüm vardır
             *değer tipleri sadece heap'de tutulur ve değişkenler sadece değerleriyle eşleştirilir.
             *referans tipleri ise değerleriyle stack bölümünde eşleştirilirken onlara verilen özel ref numaraları ise heap bölümünde saklanır
             *referans tiplerinde bir değişkeni diğer bir değişkene eşitlediğimizde referans numaraları eşleştirilir*/
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1);//30

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            Console.WriteLine(sayilar1[0]);//999

        }
    }
}
