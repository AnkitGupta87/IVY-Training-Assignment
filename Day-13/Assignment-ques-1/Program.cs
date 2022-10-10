using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13_Assignment1
{
    class Program
    {
        public delegate void nSum(int n);
        static void Main(string[] args)
        {
            nSum s1 = (int n) =>
            {
                int Sum = 0;
                for(int i=1; i<=n; i++)
                {
                    Sum += i;
                }
                Console.WriteLine("Sum of {0} Natural number is {1}",n,Sum);
            };

            Console.WriteLine("Enter the Number :");
            int num1 = int.Parse(Console.ReadLine());
            s1.Invoke(num1);

            Console.ReadKey();
        }
    }
}
