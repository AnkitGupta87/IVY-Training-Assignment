using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_9
{
    public delegate void Employee(string str);
    class emp
    {
        public string name;

        public emp(string name)
        {
            this.name = name;
        }
    }
    class Program
    {
        public static void promotion(string name)
        {
            Console.WriteLine();
            Console.WriteLine("is "+name+" Promoted ? ");
            bool flag = Boolean.Parse(Console.ReadLine());
            if(flag == true)
                Console.WriteLine("{0} is Promoted ",name);
            else
                Console.WriteLine("{0} is Not Promoted ", name);
        }
        static void Main(string[] args)
        {
            List<emp> empList = new List<emp>();
            for(int i=0; i<5; i++)
            {
                Console.WriteLine("Enter the Name of Employee {0}:",i);
                string s = Console.ReadLine();
                empList.Add(new emp(s));
            }
            Employee E1 = new Employee(promotion);
            foreach (var i in empList)
            {
                E1.Invoke(i.name);
            }

            Console.ReadKey();
        }

    }
}
