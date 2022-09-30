using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment_2
{
    class phonebook
    {
        public long phoneNo;
        public string name;
        public int age;
        public string Profession;

        public phonebook(long phoneNo,string name,int age,string Profession)
        {
            this.phoneNo = phoneNo;
            this.name = name;
            this.age = age;
            this.Profession = Profession;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<phonebook> phoneList = new List<phonebook>();
            for(int i=1; i<10; i++)
            {
                Console.WriteLine(" \t\t Enter PhoneList Number "+i);
                Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Enter Your Phone Number :");
            int phn = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your Name :");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Your Age :");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your Profession :");
            string profession = Console.ReadLine();
            phoneList.Add(new phonebook(phn, name, age, profession));

                Console.WriteLine();
                Console.WriteLine();
            }
            
            Console.WriteLine("\t\t PhoneList ");
            foreach (var i in phoneList)
            {
                Console.WriteLine("Name : "+i.name + ", Age : " + i.age + ", Profession : " + i.Profession + ", Phone No. : "+ i.phoneNo);
            }

            Console.ReadKey();
        }
    }
}