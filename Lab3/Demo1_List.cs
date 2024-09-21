using System;

namespace Lab3
{
     class Person
    {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public override string ToString() => $"Name: {FirstName} {LastName}, Age: {Age}";
    }

    internal class Demo1_List
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>()
        {
            new Person { FirstName = "Nguyen", LastName = "Phuc", Age = 18 },
            new Person { FirstName = "Lee", LastName = "Bao", Age = 20 },
            new Person { FirstName = "Quoc", LastName = "Cun", Age = 20 },
            new Person { FirstName = "Lee", LastName = "Dai", Age = 22 }
        };
            Console.WriteLine("Items in list : {0}", people.Count);

            foreach (Person person in people)
            {
                Console.WriteLine(person);
            }
            Console.ReadLine();
        }
    }
}