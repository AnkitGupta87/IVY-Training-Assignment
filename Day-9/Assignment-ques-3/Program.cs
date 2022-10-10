using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_9_Assinment3
{
    class Program
    {
        double Distance, Time;
        public Program(double Distance, double Time)
        {
            this.Distance = Distance;
            this.Time = Time;
        }
        public void CalculateSpeed()
        {
            Console.WriteLine("Speed is : " + (float)(Distance / Time) + " km/hrs.");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Distance : ");
            double distance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Time : ");
            double time = Convert.ToDouble(Console.ReadLine());
            Program mypro = new Program(distance, time);
            mypro.CalculateSpeed();

            Console.ReadKey();
        }
    }
}
