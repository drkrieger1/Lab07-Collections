using System;
using System.Collections.Generic;

namespace Lab07_erik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is my product Collection");

            Inventory<Product> myInventory = new Inventory<Product>();

            Product shoes = new Product("sneakers");
            Product tshirt = new Product("v-neck");
            Product pants = new Product("cargo");

            myInventory.Add(shoes);
            myInventory.Add(tshirt);
            myInventory.Add(pants);
            myInventory.Add(new Product("backpack"));

            foreach(Product i in myInventory)
            {
                Console.WriteLine(i.Name);
            }
            Console.WriteLine();

            myInventory.Remove(pants);

            foreach (Product i in myInventory)
            {
                Console.WriteLine(i.Name);
            }
            Console.WriteLine();


            Console.Read();
           
        }
    }
}
