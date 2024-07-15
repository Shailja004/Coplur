//Assignment 4: Iterating through Dictionary

using System;
namespace Assignment4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> product = new Dictionary<string, double>();
                product.Add( "Bag", 350 );
                product.Add( "Shoes", 500 );
                product.Add( "Earring", 50);
                product.Add( "Clothes", 1200 );
                product.Add( "Jacket", 6000);


            Console.WriteLine("Product and their Prices: ");
            foreach (var pro in product)
            {
                Console.WriteLine(pro.Key +"  "+ pro.Value);
            }

            double averagePrice = product.Values.Average();
            Console.WriteLine("\nAverage Price:"+"  "+ averagePrice);

            var mostExpensiveProduct = product.OrderByDescending(p => p.Value).First();
            Console.WriteLine("\nMost Expensive Product: " +"  "+ mostExpensiveProduct.Key +"  "+ mostExpensiveProduct.Value);
        }
    }
}

