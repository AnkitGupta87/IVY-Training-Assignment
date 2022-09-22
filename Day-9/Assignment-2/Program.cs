using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_9_Assignment2
{
    class Circle
    {
        float radius;
        public Circle(int radius)
        {
            this.radius = radius;
        }
        public void Perimeter()
        {
            Console.WriteLine("Perimeter of Circle is : "+2 * 3.14 * radius);
        }
        public void Area()
        {
            Console.WriteLine("Area of Circle is : " + 3.14 * radius * radius);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Radius of Circle : ");
            int radius;
            radius = Convert.ToInt32(Console.ReadLine());
            Circle mycircle = new Circle(radius);
            mycircle.Perimeter();
            mycircle.Area();

            Console.ReadKey();
        }
    }
}
