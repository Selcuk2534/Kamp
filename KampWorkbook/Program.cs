using System;

namespace KampHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Brand = "Samsung";
            product1.Value = 3479.99;
            product1.Point = 6;

            Product product2 = new Product();
            product2.Brand = "Apple";
            product2.Value = 9999.99;
            product2.Point = 8;

            Product product3 = new Product();
            product3.Brand = "Xiaomi";
            product3.Value = 2599.95;
            product3.Point = 7;

            Product[] products = new Product[] { product1, product2, product3 };

            Console.WriteLine("----------for----------");
            for(int i = 0; i < products.Length; i++)
            {
                Console.WriteLine("Marka : " + products[i].Brand + "\nFiyatı : " + products[i].Value + "\nAldığı Puan : " + products[i].Point);
                Console.WriteLine("  ");
            }

            Console.WriteLine("----------foreach----------");
            foreach (var product in products)
            {
                Console.WriteLine("Marka : " + product.Brand + " \nFiyatı : " + product.Value + "\nAldığı Puan : " + product.Point);
                Console.WriteLine("  ");
            }

            Console.WriteLine("----------While----------");
            int a = 0;
            while (a < products.Length)
            {
                Console.WriteLine("Marka : " + products[a].Brand + " \nFiyatı : " + products[a].Value + "\nAldığı Puan : " + products[a].Point);
                a++;
                Console.WriteLine("  ");
            }
        }
        class Product
        {
            public string Brand { get; set; }
            public double Value { get; set; }
            public int Point { get; set; }
        }
        
    }


}
