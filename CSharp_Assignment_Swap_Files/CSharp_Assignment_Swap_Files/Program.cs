using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Assignment_Swap_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            string file1 = @"C:\Users\ankit.gupta\OneDrive - Entain Group\Documents\Directories-1\file1.txt";
            string file2 = @"C:\Users\ankit.gupta\OneDrive - Entain Group\Documents\Directories-2\file2.txt";
            string str = "test.txt";
            File.Move(@file1, @str);
            File.Move(@file2, @file1);
            File.Move(@str, @file2);
            Console.ReadKey();
        }
    }
}
