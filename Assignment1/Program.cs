// See https://aka.ms/new-console-template for more information
using System;

// Q.1: Write a Program of array and add exception handling in this.
class Program
{
    static void Main()
    {
        int[] numbers = { 21, 22, 23, 24, 25 };
        try
        {
            Console.WriteLine("The element at index 3: " + numbers[3]);
            Console.WriteLine("The element at index 10: " + numbers[10]);
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine($"Index out of range: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"error occurred: {ex.Message}");
        }
        finally {
            Console.WriteLine("Continuing program...");
        }
    }
}

//Q.2: Find scenario where you can use finally.

/*Answer: Suppose, Despite being ill during the exam, you solved all your questions which finally shows your 
  dedication towards your studies.*/

//Q.3: Find use case where you can apply checked exception.

/*Answer: imagine we are developing an application that performs literary analysis on various text passages
 retrieved from external files. These files could be part of a larger database of literary works. Here's 
 checked exceptions apply.*/
