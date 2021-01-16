using System;

namespace Ders2Odev6
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.productName = "Lenovo Laptop";
            product1.productPrice = 5000;
            product1.productAmount = 30;

            Product product2 = new Product();
            product2.productName = "Logitech Mouse";
            product2.productPrice = 450;
            product2.productAmount = 80;

            Product product3 = new Product();
            product3.productName = "Microsoft Klavye";
            product3.productPrice = 300;
            product3.productAmount = 75;

            Product[] products = new Product[] { product1, product2, product3 };

            int i = 0;
            for (i = 0; i < products.Length; i++)
            {
                Console.WriteLine("Ürün adı: " + products[i].productName + Environment.NewLine + "Ürün fiyatı: " + products[i].productPrice + " TL" + Environment.NewLine + "Stok adedi: " + products[i].productAmount + Environment.NewLine + "------------------------------");
            }
            Console.WriteLine("For döngüsü bitti." + Environment.NewLine);


            foreach (var product in products)
            {
                Console.WriteLine("Ürün adı: " + product.productName + Environment.NewLine + "Ürün fiyatı: " + product.productPrice + " TL" + Environment.NewLine + "Stok adedi: " + product.productAmount + Environment.NewLine + "------------------------------");
            }
            Console.WriteLine("Foreach döngüsü bitti" + Environment.NewLine);

            int j = 0;
            while (j < products.Length)
            {
                Console.WriteLine("Ürün adı: " + products[j].productName + Environment.NewLine + "Ürün fiyatı: " + products[j].productPrice + " TL" + Environment.NewLine + "Stok adedi: " + products[j].productAmount + Environment.NewLine + "------------------------------");
                j++;
            }
            Console.WriteLine("While döngüsü bitti" + Environment.NewLine);
        }
    }

    class Product
    {
        public string productName { get; set; }
        public double productPrice { get; set; }
        public int productAmount { get; set; }
    }
}
