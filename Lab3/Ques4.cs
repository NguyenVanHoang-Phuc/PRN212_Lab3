using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{  
    internal class Ques4
    {
        void swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        static void Main(string[] args)
        {
            Ques4 example = new Ques4();
            
            int x = 10, y = 20;
            Console.WriteLine($"Truoc khi hoan doi: x = {x}, y = {y}");
            example.swap(ref x, ref y);
            Console.WriteLine($"Sau khi hoan doi: x = {x}, y = {y}");

            string str1 = "Hello";
            string str2 = "World";
            Console.WriteLine($"Truoc khi hoan doi: str1 = {str1}, str2 = {str2}");
            example.swap(ref str1, ref str2);
            Console.WriteLine($"Sau khi hoan doi: str1 = {str1}, str2 = {str2}");
        }
    }
}
