using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment_4
{
    public class Program
        {
        public abstract class Bird
        {
            private string name;

            public void setName(string name)
            {
                this.name = name;
            }

            public string getName()
            {
                return name;
            }


            public abstract void fly(string name);
        }
        public class Crow : Bird
        {
            public override void fly(string bird)
               {
                    Console.WriteLine("{0} is flying : ",bird);
                }
        }

            
            public static void Main(string[] args)
            {
                Crow parrot = new Crow();
                Console.Write("Enter the name of bird : ");
                string bird = Console.ReadLine();
                parrot.setName(bird);
                Console.WriteLine(parrot.getName());
                parrot.fly(bird);

            Console.ReadKey();
            }
    }

}
