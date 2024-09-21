using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Demo2_SortList
    {
        static void Main(string[] args)
        {
            SortedSet<int> listt = new SortedSet<int>() { 3, 6, 2, 8, 1 };
            listt.Add(4);
            listt.Add(7);
            listt.Add(9);
            listt.Add(5);
            foreach (int i in listt)
            {
                Console.Write($"{i} ");
            }

        }
    }
}
