using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_10_ass3
{
    public class BigBazar
    {
        public double Food_amount;
        public double Grocery_amount;
        public double Clothing_amount;

    }
    public class Food : BigBazar
    {

        double GST_f = 5;
        public void GST1()
        {
            double GST_Amount1 = Food_amount * GST_f / 100;
            Console.WriteLine($"GST AMOUNT  of Food: {GST_Amount1}");
        }

    }
    public class Grocery : BigBazar
    {

        double GST_g = 8;
        public void GST2()
        {
            double GST_Amount2 = Grocery_amount * GST_g / 100;
            Console.WriteLine($"GST AMOUNT  of Grocery: {GST_Amount2}");
        }

    }
    public class Clothing : BigBazar
    {

        double GST_c = 8;
        public void GST3()
        {
            double GST_Amount3 = Clothing_amount * GST_c / 100;
            Console.WriteLine($"GST AMOUNT  of Clothing: {GST_Amount3}");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Food f = new Food();
            f.Food_amount = 590;
            f.GST1();

            Grocery g = new Grocery();
            g.Grocery_amount = 999;
            g.GST2();

            Clothing c = new Clothing();
            c.Clothing_amount = 9999;
            c.GST3();

            Console.ReadKey();
        }
    }
}
