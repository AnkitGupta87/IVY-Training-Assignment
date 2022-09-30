using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assesment_10
{

    class Program
    {
         static async Task Main(string[] args)
        {
            flowerDecoration();
            cheifGuestPicked();
            foodArea();
            giftArranged();
            functionStarted();
        }
        static async void flowerDecoration()
        {
            Console.WriteLine("Flower Decortion Completed...");
        }
        static async void cheifGuestPicked()
        {
            Console.WriteLine("Cheif Guest Picked...");
            await Task.Delay(5000);
            Console.WriteLine("Chief Guest Arrived...");
        }
        static async void giftArranged()
        {
            await Task.Delay(4000);
            Console.WriteLine("Gifts are Arranged");
        }
        static async void functionStarted()
        {
            await Task.Delay(6000);
            Console.WriteLine("Function started...");
        }
        static async void foodArea()
        {
            Console.WriteLine("Food Area is Set...");
        }
    }
}
