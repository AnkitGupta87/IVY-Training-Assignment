using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_Assignment12
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the String : ");
            string str = Console.ReadLine();
            int l = str.Length - 1;
            Console.Write("The characters of the string in reverse are : \n");
            while (l >= 0)
            {
                Console.Write("{0} ", str[l]);
                l--;
            }
            Console.ReadKey();
        }
    }
}
