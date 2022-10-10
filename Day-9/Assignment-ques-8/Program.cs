using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_Assignment8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the three Sides of triangle : ");
            int side1 = Convert.ToInt32(Console.ReadLine());
            int side2 = Convert.ToInt32(Console.ReadLine());
            int side3 = Convert.ToInt32(Console.ReadLine());

            if(side1 == side2 && side1 == side3 && side2 == side3)
            {
                Console.WriteLine("Equilateral Triangle");
            }
            else if(side1 == side2 || side1 == side3 || side2 == side3)
            {
                Console.WriteLine("Isosceles Triangle");
            }
            else
            {
                Console.WriteLine("Scalene Triangle");
            }

            Console.ReadKey();
        }
    }
}
