// Assignment 2: Sorting and Searching in a List.

using System;
namespace Assignment2
{
    public class Program
    {
       static void Main(string[] args)
        {

            List<int> ints = new List<int> { 3, 70, 83, 62, 9, 82, 61, 72, 19, 40 };


            ints.Sort();
            Console.WriteLine("Sorted list in ascending order:");
            foreach (int n in ints)
            {
                Console.WriteLine(n);
            }

            ints.Sort((a,b) => b.CompareTo(a));
            Console.WriteLine("Sorted list in descending order:");
            foreach (int n in ints)
            {
                Console.WriteLine(n);
            }

            int searchNumber = 61;
            bool a = ints.Contains(searchNumber);
            Console.WriteLine("Search Number: " + searchNumber);
            Console.WriteLine(a);
            
        }
    }
}
