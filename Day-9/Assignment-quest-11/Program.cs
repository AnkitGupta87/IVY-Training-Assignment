using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_Assignment11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Size of Array :");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
            Console.WriteLine("Enter the Element of Array: ");
            for(int i=0; i<size; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            List<int> EvenArray = new List<int>();
            List<int> OddArray = new List<int>();
            for(int i=0; i<size; i++)
            {
                if(array[i] % 2 == 0)
                {
                    EvenArray.Add(array[i]);
                }
                else
                {
                    OddArray.Add(array[i]);
                }
            }
            Console.WriteLine("Even Array : ");
            foreach(int i in EvenArray)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Odd Array : ");
            foreach (int i in OddArray)
            {
                Console.WriteLine(i + " ");
            }

            Console.ReadKey();
        }
    }
}
