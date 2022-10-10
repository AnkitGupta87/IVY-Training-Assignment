using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9_Assignment7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Marks of Math :");
            int math = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Marks of Physics :");
            int phy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Marks of Chemistry :");
            int chem = Convert.ToInt32(Console.ReadLine());

            if((math > 65 && phy > 55 && chem > 50) || (math + phy + chem) > 180)
            {
                Console.WriteLine("Hoorray... You will get the Addmission");
            }
            else
            {
                Console.WriteLine("Sorry... You can't get the Addmission");
            }

            Console.ReadKey();
        }
    }
}
