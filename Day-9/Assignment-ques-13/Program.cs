using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_Assignment13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string :");
            string str = Console.ReadLine();

            foreach(char i in str)
            {
                char ch = i;
                if (Char.IsLower(ch)) 
                    Console.Write(Char.ToUpper(ch)); 
                else
                    Console.Write(Char.ToLower(ch));
            }
            Console.ReadKey();
        }
    }
}
