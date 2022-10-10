using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_Assignment6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Height in cm :");
            int height = Convert.ToInt32(Console.ReadLine());
            if(height <= 135)
            {
                Console.WriteLine("Short");
            }
            else if (height >= 180)
            {
                Console.WriteLine("Tall");
            }
            else
            {
                Console.WriteLine("Average");
            }

            Console.ReadKey();
        }
    }
}
