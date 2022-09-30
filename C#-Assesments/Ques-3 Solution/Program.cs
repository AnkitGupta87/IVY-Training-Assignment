using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment_3
{
    interface IVehicle
    {
        void drive();
        bool Refuel(int fuelAmount);

    }
    class Car : IVehicle
    {
        int fuel;
        public Car(int fuel)
        {
            this.fuel = fuel;
        }
        public void drive()
        {
            if (Refuel(fuel))
            {
                Console.WriteLine("Car is driving...");
            }
            else
            {
                Console.WriteLine("Fuel is Empty!!! Please Refuel it.");
            }
        }
        public bool Refuel(int fuelAmmount)
        {
            fuel += fuelAmmount;
            if (fuel > 0)
                return true;
            return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car(0);
            myCar.drive();
            Console.WriteLine("Enter the Amount of Fuel you want to fill : ");
            int fuel = int.Parse(Console.ReadLine());
            myCar.Refuel(fuel);
            myCar.drive();
            Console.ReadKey();
        }
    }
}
