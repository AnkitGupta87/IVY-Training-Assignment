using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ay_9_Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Year : ");
            int year = Convert.ToInt32(Console.ReadLine());
            if(year % 4 == 0)
            {
                if(year % 100 == 0)
                {
                    if(year % 400 == 0)
                    {
                        Console.WriteLine("{0} is  Leap Year", year);
                    }
                    else
                    {
                        Console.WriteLine("{0} is Not Leap Year", year);
                    }
                }
                else
                {
                    Console.WriteLine("{0} is Leap Year", year);
                }
            }
            else
            {
                Console.WriteLine("{0} is Not Leap Year", year);
            }

            Console.ReadKey();
        }
    }
}
