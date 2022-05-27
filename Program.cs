using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Random
{
    class Program
    {
        static void Main(string[] args)
        {
        start:
            Console.Clear();
            System.Random random = new System.Random();
            double a = random.Next(9);
            Console.WriteLine("   SINUNGALING O HINDI?");
            Console.WriteLine("Enter a random number(1-9)");
            double num = Convert.ToDouble(Console.ReadLine());
                      
            if (num == a)
            {
                Console.WriteLine("Sinungaling!");
            }
            else if(num != a)
            {
                Console.WriteLine("Hindi Ka Sinungaling!");
            }
            else
            {
                goto start;
            }
            Console.WriteLine(".....press any key to try again");
            string press = Console.ReadLine();
            string nothing = "qu97ads87ka98sdfgdfs6876faf1";
            if (press != nothing )
            {
                goto start;
            }
            Console.ReadKey();
        }
    }
}
