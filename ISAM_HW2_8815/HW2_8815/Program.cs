using System;

namespace HW2_8815
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int num2 = int.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine(num1+ " is greater");
            }
            else if
                (num2 > num1)
                {
                    Console.WriteLine(num2 + " is greater");
                }
                else
                {
                    Console.WriteLine("both numbers are same");
                }
        }
    }
}
