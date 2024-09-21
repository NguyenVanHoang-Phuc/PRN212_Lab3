using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Ques3
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, "Monday");
            hashtable.Add(2, "Tuesday");
            hashtable.Add(3, "Wednesday");
            hashtable.Add(4, "Thursday");
            hashtable.Add(5, "Friday");
            hashtable.Add(6, "Saturday");
            hashtable.Add(7, "Sunday");
            
            foreach (DictionaryEntry key in hashtable)
            {
                Console.WriteLine($"{key.Key} - {key.Value}");
            }

            if (hashtable.ContainsValue("Tuesday"))
            {
                Console.WriteLine("Found Tuesday successful!");
            }
            else
            {
                Console.WriteLine("Not found Tuesday");
            }
        }
    }
}