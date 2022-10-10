using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13_Assignment4
{
    class Program
    {
        public delegate void checkPrime(int n);
        static void Main(string[] args)
        {
            checkPrime P = delegate (int n)
            {
                bool flag = false;
                if (n == 0 || n == 1)
                    flag = true;
                for (int i = 2; i <= n / 2; ++i)
                {
                    if (n % i == 0)
                    {
                        flag = true;
                        break;
                    }
                }
                Console.WriteLine("{0} is {1}",n,flag == false ? "Prime Number" : "Not a Prime Number");
            };
            Console.WriteLine("Enter the Number to check whether it is Prime or Not");
            int x = int.Parse(Console.ReadLine());
            P.Invoke(x);

            Console.ReadKey();
        }
    }
}
