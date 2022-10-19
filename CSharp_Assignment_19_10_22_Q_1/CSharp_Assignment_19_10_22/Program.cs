using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CSharp_Assignment_19_10_22
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string file = @"C:\Users\ankit.gupta\OneDrive - Entain Group\Documents\first.txt";
            Console.WriteLine(File.ReadAllText(file));
            string str = @"C:\Users\ankit.gupta\OneDrive - Entain Group\Documents\second.txt";
            await Task.Run(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine(File.ReadAllText(str));
            });

            Console.ReadKey();
        }
    }
}
