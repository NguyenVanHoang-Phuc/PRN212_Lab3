using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Product
    {
        private string name { get; set; }
        private double cost { get; set; }
        private int quantity { get; set; }
        public Product(string name, double cost, int quantity)
        {
            this.name = name;
            this.cost = cost;
            this.quantity = quantity;
        }
        public override string ToString()
        {
            return $"Product '{name}' with cost {cost}$ have {quantity}";
        }

    }
    internal class Ques2
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(new Product("tao", 162.2, 100));
            list.Add(new Product("le", 27.2, 2311));
            list.Add(new Product("dua hau", 60.4, 233));
            list.Add(new Product("thom", 111.1, 1090));
            list.Add(new Product("dau", 200, 1000));

            foreach (Product p in list)
            {
                Console.WriteLine(p.ToString());
            }
        }
    }
}