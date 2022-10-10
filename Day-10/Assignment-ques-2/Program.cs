using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_10_ass2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number: ");

                int n = Int32.Parse(Console.ReadLine());
                Console.Write("Enter symbol(sqr,div,sqrrt): ");
                string symbol = Console.ReadLine();

                switch (symbol)
                {
                    case "sqr":
                        Console.WriteLine("Squre of {0} is {1}",n,n*n);
                        break;
                    case "div":
                        Console.WriteLine("Division of {0} is {1}",n, 100 / n);
                        break;
                    case "sqrrt":
                        Console.WriteLine($"Squreroot of {0} is {1}",n, Math.Sqrt(n));
                        break;
                    default:
                        Console.WriteLine("Try other symbol");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.Write("Error info:" + ex.Message);
            }
            finally
            {

                Console.Write("Try-Again with a different number.");
            }
            Console.ReadKey();
        }
    }
}
