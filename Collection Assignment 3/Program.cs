//Assignment 3: Dictionary Basics

using System;

namespace Assignment3
{
     public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> student = new Dictionary<string, int>();


            student.Add("Shailja",96);
            student.Add("Raunak",92);
            student.Add("Aryan",93);
            student.Add("Vanshika",84);
            student.Add("Deepa",75);
            
            Console.WriteLine("Students and Scores");
            foreach (var stud in student)
            {
                Console.WriteLine(stud.Key + "  " +stud.Value);
            }


            student.Add("Safal",  66);
            Console.WriteLine("\nUpdated dictionary:");
            foreach (var stud in student)
            {
                Console.WriteLine(stud.Key + "  " + stud.Value);
            }

            student.Remove("Deepa");
            Console.WriteLine("\nafter removing Deepa:");
            foreach (var stud in student)
            {
                Console.WriteLine(stud.Key + "  " + stud.Value);
            }

        
            int rollnum = student["Shailja"];
            Console.WriteLine("\nShailja's Scores is " +"  " + rollnum);
        }
    }
}

