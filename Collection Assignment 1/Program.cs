// Assignment 1: Basic List Operations


using System;

 public class Program
{
    public static void Main()
    {
        List<string> fruits = new List<string>();
        fruits.Add("Apple");
        fruits.Add("Banana");
        fruits.Add("Papaya");
        fruits.Add("Orange");
        fruits.Add("Mango");

        Console.WriteLine("Fruits List: ");
        foreach (var fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
        fruits.Add("guava");
        Console.WriteLine("After Adding a fruit:");
        foreach (var fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        fruits.Remove(fruits[1]);
        Console.WriteLine("After Deleting Second Fruit : ");
        foreach (var fruit in fruits)
        {
            Console.WriteLine(fruit);
        }


        Console.WriteLine("Third fruit is : "+ fruits[2]);

       if(fruits.Contains("Apple"))
        {
            Console.WriteLine("Yes list contains Apple.");
        }
    }
}

