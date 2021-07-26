using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.Id = 1;
            product.CategoryId = 2;
            product.ProductName = "Masa";
            product.UnitPrice = 1500;
            product.UnitsInStock = 2;

            Product product1 = new Product { Id = 2,CategoryId=4,UnitsInStock=5,ProductName="Kalem",UnitPrice=35};

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);

            productManager.Topla1(2, 3);

            int sonuc = productManager.Topla(3, 6);
            Console.WriteLine(sonuc*2);

            Console.ReadLine();


        }
    }
}
