using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    /*public class Person
    {
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Person() { }
        public override string ToString()
        {
            return $"Name : {FirstName} {LastName}, Age: {Age}";
        }
    }*/

    public class MyCollection<T> : IEnumerable where T : class, new()
    {
        private List<T> myList = new List<T>();
        public void AddItem(params T[] item) => myList.AddRange(item);
        IEnumerator IEnumerable.GetEnumerator() => myList.GetEnumerator();
    }

    internal class Demo3_IEnumerable
    {
        static void Main(string[] args)
        {
            MyCollection<Person> collection = new MyCollection<Person>();
            var p1 = new Person() { Age = 24, FirstName = "Hoang", LastName = "Phuc" };
            var p2 = new Person() { Age = 30, FirstName = "Van", LastName = "Hoang" };
            var p3 = new Person() { Age = 30, FirstName = "Nguyen", LastName = "Phaan" };
            var p4 = new Person() { Age = 20, FirstName = "Tuan", LastName = "Jack" };
            collection.AddItem(p1, p2, p3, p4);
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
