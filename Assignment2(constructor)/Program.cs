using System;
namespace Constructor;
using System;

public class Student
{
     string name;
     int rollnumber;

    public Student()
    {
        name = "Shailja";
        rollnumber = 1;
    }
    public Student(string n, int a)
    {
        name = n;
        rollnumber = a;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {name}, rollnumber: {rollnumber}");
    }
}

public class Program
{
    public static void Main()
    {
        Student obj1 = new Student();
        Console.WriteLine("Default constructor:");
        obj1.DisplayInfo();

        Student obj2 = new Student("Sneha", 2);
        Console.WriteLine("\nParameterized constructor:");
        obj2.DisplayInfo();
    }
}


