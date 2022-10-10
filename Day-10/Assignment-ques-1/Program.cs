using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_10_ass
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number: ");

                int n =Int32.Parse(Console.ReadLine());

                Console.WriteLine("Squre of {0} is {1}",n,n*n);
            }
            catch (Exception ex)
            {
                Console.Write("Error info:" + ex.Message);
            }
            finally
            {
                Console.Write("Try Again with a different number.");
            }

            Console.ReadKey();
        }
    }
}