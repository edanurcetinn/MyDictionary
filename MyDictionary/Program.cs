using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int, string> idProduct = new MyList<int, string>();
            idProduct.Add(100, "Süt");
            idProduct.Add(101, "Peynir");
            idProduct.Add(102, "Sıvı Yağ");
            idProduct.Add(103, "Makarna");
            idProduct.Add(104, "Yoğurt");

            Console.WriteLine("Ürün: " + idProduct.items1[0] + " " + "ID: " + idProduct.items2[0]);
            Console.WriteLine("Ürün: " + idProduct.items1[1] + " " + "ID: " + idProduct.items2[1]);
            Console.WriteLine("Ürün: " + idProduct.items1[2] + " " + "ID: " + idProduct.items2[2]);
            Console.WriteLine("Ürün: " + idProduct.items1[3] + " " + "ID: " + idProduct.items2[3]);
            Console.WriteLine("Ürün: " + idProduct.items1[4] + " " + "ID: " + idProduct.items2[4]);




        }
    }
}
