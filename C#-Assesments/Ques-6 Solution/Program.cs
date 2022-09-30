using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string file;
            
            Console.WriteLine("Before : ");
            file = File.ReadAllText("C:\\Users\\ankit.gupta\\source\\repos\\test.txt");
            Console.WriteLine("data in the First File : ");
            Console.WriteLine(file);

            file = File.ReadAllText("C:\\Users\\ankit.gupta\\source\\repos\\test.txt");
            Console.WriteLine("data in Second file : ");
            Console.WriteLine(file);
            Console.WriteLine();

            File.Copy("C:\\Users\\ankit.gupta\\source\\repos\\test.txt", "C:\\Users\\ankit.gupta\\source\\repos\\New folder\\test.txt", true);
            
            Console.WriteLine("After :\n");
            file = File.ReadAllText("C:\\Users\\ankit.gupta\\source\\repos\\test.txt");
            Console.WriteLine("data in first file : ");
            Console.WriteLine(file);

            file = File.ReadAllText("C:\\Users\\ankit.gupta\\source\\repos\\New folder\\test.txt");
            Console.WriteLine("data in Second file : ");
            Console.WriteLine(file);

            Console.ReadKey();
        }
    }
}

