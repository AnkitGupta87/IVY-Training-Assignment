using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_Assignment9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] {1,2,3,4,5,6,7};
            int[] arr2 = new int[arr1.Length];
            for(int i=0; i<arr1.Length; i++)
            {
                arr2[i] = arr1[i];
            }

            Console.WriteLine("Original Array :");
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Copied Array :");
            for(int i=0; i<arr2.Length; i++)
            {
                Console.Write(arr2[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
