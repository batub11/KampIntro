using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    { //​(C)reate (R)ead (U)pdate (D)elete - SQL Sorgu İşlemleri
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName +"Eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "Güncellendi.");
        }



        

    }
}
