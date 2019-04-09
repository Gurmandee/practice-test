using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
       

        static void Main(string[] args)
        {
            Console.WriteLine(" this program will give the sum total of 5 prices");

            Console.WriteLine(" enter the price of item 1");
            Console.WriteLine(" enter the price of item 2");
            Console.WriteLine("enter the price of item 3");
            Console.WriteLine(" enter the price of item 4");
            Console.WriteLine(" enter the price of item 5");
             
            int i, n, sum = 0;
            double avg;
             
            Console.Write("\n\n");
            Console.Write("Read 5 numbers and calculate sum and average:\n");
            Console.Write("----------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input the 5 numbers : \n");
            for (i = 1; i <= 5; i++)
            {
                Console.Write("Number-{0} :", i);

                n = Convert.ToInt32(Console.ReadLine());
                sum += n;
            }
            avg = sum / 5.0;
            Console.Write("The sum of 5 no is : {0}\nThe Average is : {1}\n", sum, avg);
        }
    }
}
