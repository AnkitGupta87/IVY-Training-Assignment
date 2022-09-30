using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment_7
{
    class Program
    {
        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }


            public override string ToString()
            {
                return Name + " : " + Age;
            }
        }
        static void Main(string[] args)
        {
            Queue q = new Queue();
            
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter the Name of Person {0} : ",i+1);
                string name = Console.ReadLine();
                Console.WriteLine("Enter the Age : ");
                int age = int.Parse(Console.ReadLine());

                q.Enqueue(new Person()
                {
                    Name = name,
                    Age = age
                });
            }
            Console.WriteLine(" \t List of person in Queue are : ");
            Console.WriteLine();
            foreach (Person p in q)
            {
                Console.WriteLine(p.ToString());
            }

            Console.ReadKey();
        }
    }
}

