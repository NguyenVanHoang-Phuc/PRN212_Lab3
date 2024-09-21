using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Cal<T>
    {
        public T Add(T a, T b) => (dynamic)a + (dynamic)b;
        public T Sub(T a, T b) => (dynamic)a - (dynamic)b;
        public T Mul(T a, T b) => (dynamic)a * (dynamic)b;
        public T Div(T a, T b) => (dynamic)a / (dynamic)b;

        public void Display<U>(U msg, T value)
        {
            Console.WriteLine($"{msg}: {value}");
        }
    }

    internal class Ques1
    {
        public static void Main(string[] args)
        {
            Cal<double> cal = new Cal<double>();

            Console.WriteLine("Enter Number 1 (double): ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Number 2 (double): ");
            double b = double.Parse(Console.ReadLine());

            double addRs = cal.Add(a, b);
            cal.Display($"Addition {a} and {b} ", addRs);

            double subRs = cal.Sub(a, b);
            cal.Display($"Subtraction {a} and {b} ", subRs);

            double mulRs = cal.Mul(a, b);
            cal.Display($"Multiplication {a} and {b} ", mulRs);

            double divRs = cal.Div(a, b);
            cal.Display($"Division {a} and {b} ", divRs);
            Console.ReadLine();
        }
    }
}
