//Assignment 6: Advanced Dictionary Operations

using System;
namespace Assignment_6
{
    class Person
    {
        public string Firstname;
        public string Lastname;
       
    }
        class program 
    {
            public static void Main(string[] args)
            {
            Person person1 = new Person()
            {
                Firstname = "Shailja",
                Lastname = "Bhargava"

            };

            
            Person person2 = new Person()
                {
                    Firstname = "Vanshika",
                    Lastname = "Thakur"

                };

            Person person3 = new Person()
            {
                Firstname = "Raunak",
                Lastname = "Bhargava"

            };


            Dictionary<Person, string> PE = new Dictionary<Person, string>();
                PE[person1] = "shailja@gmail.com";
                PE[person2] = "vanshi@gmail.com";
                PE[person3] = "rb@gmail.com";
               

                Console.WriteLine("Person Emails:");
            foreach (var person in PE)
            {
                Console.WriteLine(person.Key.Firstname+ "  "+person.Key.Lastname+"  " +person.Value);

                }

                var personName = person3;
                if (PE.ContainsKey(personName))
                {
                    PE[personName] = "raunak22@gmail.com";
                }
                Console.WriteLine("\nUpdated Emails:");
                foreach (var person in PE)
                {
                    Console.WriteLine(person.Key.Firstname +"  "+ person.Key.Lastname + "  " + person.Value);
                }

                var removeperson = person2;
                PE.Remove(removeperson);
                Console.WriteLine("\nEmails after removing Vanshika Thakur:");
                foreach (var person in PE)
                {
                    Console.WriteLine(person.Key.Firstname + "  " +person.Key.Lastname+"  "+ person.Value);
                }
            }
        }
    }
       


