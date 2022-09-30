using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int fact(int num)
            {
                if (num == 0 || num == 1)
                    return 1;

                return num*fact(num - 1);
            }

            Console.WriteLine("Enter the Number : ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Factorial of {0} is : ",n);
            Console.WriteLine(fact(n));
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("\t Table of {0} is :",n);
            for(int i=1; i<=10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}",n,i,n*i);
            }

            Console.ReadKey();
        }
    }
}
