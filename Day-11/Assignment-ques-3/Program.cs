using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day11_assingment3
{
    class Program
    {
        public class student
        {
            public int id;
            public string name;
            public bool pass;

            public student(int id, string name, bool pass)
            {
                this.id = id;
                this.name = name;
                this.pass = pass;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number of Students : ");
            int size = Convert.ToInt32(Console.ReadLine());
            student[] arr = new student[size];
            List<student> ll = new List<student>();
            for(int i=0; i<size; i++)
            {
                Console.WriteLine("Enter the id :");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the name :");
                string str = Console.ReadLine();
                Console.WriteLine("Pass Or Fail :");
                bool pass = Convert.ToBoolean(Console.ReadLine());
                ll.Add(new student(id, str, pass));
            }

            foreach(var i in ll)
            {
                Console.WriteLine(i.id + " " + i.name + " " + i.pass);
            }
            Console.ReadKey();
        }
    }
}
