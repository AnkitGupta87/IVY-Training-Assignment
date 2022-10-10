using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_10_ass5
{
    abstract class Bank_Account
    {
        public abstract void Link_Aadhar_Bank_AccNo();
    }
    class Link : Bank_Account
    {
        double aadhar_no;
        public Link()
        {
            aadhar_no = Convert.ToDouble(Console.ReadLine());
        }
        public override void Link_Aadhar_Bank_AccNo()
        {
            Console.WriteLine("Aadhar Number {0} has been linked with Bank Account Successfully!",aadhar_no);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Link link = new Link();
            link.Link_Aadhar_Bank_AccNo();

            Console.ReadKey();
        }
    }
}
