using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13_Assignment2
{
    class Program
    {
        public delegate void findGreater(int num1, int num2);
        static void Main(string[] args)
        {
            findGreater f = (int n1, int n2) => Console.WriteLine("The Greater number is : {0}",n1>n2 ? n1 : n2);
            Console.WriteLine("Enter the Two Numbers :");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            f.Invoke(a, b);

            Console.ReadKey();
        }
    }
}
