using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13_Assignment3
{
    class Program
    {
        public delegate void swapNumber(int num1, int num2);
        static void Main(string[] args)
        {
            swapNumber sn = (int x, int y) =>
            {
                x = x + y;
                y = x - y;
                x = x - y;
                Console.WriteLine("After Swaping two Numbers are num1 = {0} & num2 = {1}", x, y);
            };

            Console.WriteLine("Enter two Number :");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            
            Console.WriteLine("Before Swaping two Numbers are num1 = {0} & num2 = {1}", a,b);
            sn.Invoke(a, b);

            Console.ReadKey();
        }
    }
}

/*
 * simple_interest obj = (pr, pt) =>
            {
                Console.WriteLine("Values before swap...");
                Console.WriteLine(pr.ToString());
                Console.WriteLine(pt.ToString());
                pr = pr + pt;
                pt = pr-pt;
                pr = pr-pt;
                Console.WriteLine("Values after swap...");
                Console.WriteLine(pr.ToString());
                Console.WriteLine(pt.ToString());
                //Console.WriteLine(obj.Invoke(s, q));
            };
                 
                Console.WriteLine("Enter num : ");
                int s = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter num2 1: ");
            int q = Convert.ToInt32(Console.ReadLine());
            
            obj.Invoke(s,q); */
