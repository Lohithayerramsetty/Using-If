using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Data.Common;

namespace Week1_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;

            Console.WriteLine("Enter the Numerical Mark:");
            num1 = Convert.ToInt32(Console.ReadLine());

            if (num1 == 9 || num1 == 10)
                Console.WriteLine("Excellent");

            else if (num1 == 7 || num1 == 8)
                Console.WriteLine("Notable");

            else if (num1 == 6)
                Console.WriteLine("Good");

            else if (num1 == 5)
                Console.WriteLine("Pass");

            else if (num1 < 5)
                Console.WriteLine("Fail");

            else
                Console.WriteLine("Invalid numerical mark");

        }
    }
}     