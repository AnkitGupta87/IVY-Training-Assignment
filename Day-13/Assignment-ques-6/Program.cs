using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_13_Assignment_6
{
    public delegate void funt2(int[] array);
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size : ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[size];
            for (int i = 0; i < size; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            funt2 ff = (int[] arr) => Array.Sort(arr);
            ff.Invoke(a);
            foreach (var i in a)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
