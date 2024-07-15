//Assignment 5: Combining Lists and Dictionaries.

using System;
namespace Assignment5
{
     public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> StudentScores = new Dictionary<string, List<int>>();
            
              StudentScores.Add("Shailja", new List<int> { 95, 92, 98 } );
              StudentScores.Add("Raunak", new List<int> { 78, 81, 79 });
              StudentScores.Add("Vanshika", new List<int> { 90, 85, 87 });

            Console.WriteLine("Student Scores:");
            foreach (var student in StudentScores)
            {
                
                Console.WriteLine(student.Key + "  " + string.Join("-", student.Value) );
            }

            Console.WriteLine("\nAverage Scores: ");
            foreach (var student in StudentScores)
            {
                double averageScore = student.Value.Average();
                Console.WriteLine(student.Key + "  " + averageScore);
            }

            var highestaveragescore = StudentScores.OrderByDescending(s => s.Value.Average()).First();
            Console.WriteLine("\nTop Student:" + "  " + highestaveragescore.Key + "  " + highestaveragescore.Value.Average());
        }
    }
}

