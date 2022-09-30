using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter thr size of Array :");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            for(int i=0; i<size; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            int mini = array[0];
            int maxi = array[0];

            for (int i = 1; i < size; i++)
            {
                if (array[i] > maxi)
                {
                    maxi = array[i];
                }
                if (array[i] < mini)
                {
                    mini = array[i];
                }
            }
            Console.WriteLine("Maximum Value in Array is : "+maxi);
            Console.WriteLine();
            Console.WriteLine("Minimum Value in Array is : "+mini);

            Console.ReadKey();
        }
    }
}
