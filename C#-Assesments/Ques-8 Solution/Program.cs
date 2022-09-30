using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name : ");
            string name = Console.ReadLine();
            string fileName = @"C:\\Users\\ankit.gupta\\source\\repos\\" + name + ".txt";
            try
            {
                StreamWriter sw = File.AppendText(fileName);

                sw.WriteLine("first line has been added");
                sw.WriteLine("Second line has been added");
                sw.WriteLine("Third Line has been added");
                sw.WriteLine("fourth line has been added");
                sw.WriteLine("fifth line has been added");
                sw.WriteLine("sixth line has been added");
                sw.WriteLine("seventh line has been added");
                sw.WriteLine("eighth line has been added");
                sw.WriteLine("ninth line has been added");
                sw.WriteLine("tenth line has been added");
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                using (StreamReader SR = File.OpenText(fileName))
                {
                    string s = "";
                    while ((s = SR.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                    SR.Close();
                }
            }
            
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Enter the text you want to remove :");
            string oldText = Console.ReadLine();



            Console.WriteLine("Enter the text you want to add : ");
            string newText = Console.ReadLine();



            string text = File.ReadAllText(fileName);
            text = text.Replace(oldText, newText);
            File.WriteAllText(fileName, text);

            Console.ReadKey();
        }
    }
}
