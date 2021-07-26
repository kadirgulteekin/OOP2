using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " Eklendi.");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " Güncellendi.");
        }

        public int Topla(int sayi1,int sayi2)   //eğer dönen sonucu kullanmak istiyorsam int kullanırım
        {
            return sayi1 + sayi2;
        }
        public void Topla1(int sayi1, int sayi2)  //git yap bitir diyeceksem ise void kullanıyorum
        {
            Console.WriteLine(sayi1 + sayi2);
        }
    }
}
