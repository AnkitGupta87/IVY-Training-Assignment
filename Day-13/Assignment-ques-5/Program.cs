using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13_Assignment5
{
    class Program
    {
        public delegate void calc(int a);
        public delegate bool calc1(int s);

        static void Main(string[] args)
        {
            calc1 isPrime = (n) =>
            {
                if (n <= 1)
                    return false;
                for (int i = 2; i < n; i++)
                    if (n % i == 0)
                        return false;
                return true;
            };

            calc obj = (p) =>
            {
                for (int i = 2; i <= p; i++)
                    if (isPrime(i))
                    {
                        Console.WriteLine(i + " ");
                    }
            };

            Console.WriteLine("Enter n Number :");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Prime numbers are :");
            obj.Invoke(n1);

            Console.ReadKey();
        }
    }
}
