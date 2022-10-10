using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_Assignment10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Size of Array : ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] arr1 = new int[size];
            int[] arr2 = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < size; i++)
            {
                arr2[i] = Convert.ToInt32(Console.ReadLine());
            }

            int[] mergedArray = new int[2 * size];

            int j = 0;
            for(int i=0; i<size; i++)
            {
                mergedArray[j] = arr1[i];
                j++;
            }
            for (int i = 0; i < size; i++)
            {
                mergedArray[j] = arr2[i];
                j++;
            }

            Array.Sort(mergedArray);

            for (int i = 0; i < mergedArray.Length; i++)
            {
                Console.Write(mergedArray[i]+" ");
            }

            Console.ReadKey();
        }
    }
}
