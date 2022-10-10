using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11_assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> StudentDetails = new Dictionary<int, int>();
            Console.WriteLine("Enter the number of students : ");
            int size = Convert.ToInt32(Console.ReadLine());
            for(int i=0; i<size; i++)
            {
                Console.WriteLine("Enter the id of student {0} :", i + 1);
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Marks of student {0} :", i + 1);
                int marks = Convert.ToInt32(Console.ReadLine());
                StudentDetails.Add(id, marks);
            }

            Console.WriteLine();
            Console.WriteLine("Detail of student id & marks are : ");

            foreach (var i in StudentDetails)
            {
                Console.WriteLine(i.Key + " -> " + i.Value);
            }

            Console.ReadKey();
        }
    }
}
