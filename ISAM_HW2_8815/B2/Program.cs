using System;

namespace B2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number");
            int num3 = int.Parse(Console.ReadLine());
            if (num1 > num2 && num3 > num2 && num3 > num1)
            {
                Console.WriteLine(num1 + "is in middle of all 3 numbers");
            }
           else if (num2>num1 && num3 > num2 && num3>num1)
            {
                Console.WriteLine(num2+ "is in middle of all 3 numbers");
                            }
            else if (num1 > num2 && num2 < num3 && num1 > num3)
            {
                Console.WriteLine(num3 + "is in middle of all 3 numbers");
            }



        }
    }
}
