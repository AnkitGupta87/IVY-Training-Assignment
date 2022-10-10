using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11_Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            string myfile = @"myFile.txt";

            using (StreamWriter SW = File.AppendText(myfile))
            {
                SW.WriteLine("Hello there");
                SW.WriteLine("This is Ankit");
                SW.WriteLine("I am appending the text in this file.");
            }

            using (StreamReader SR = File.OpenText(myfile))
            {
                string s = "";
                while ((s = SR.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }

            Console.ReadKey();
        }
    }
}
