using System;

namespace b._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int num = 0;
            int num1 = 0;
            Console.WriteLine("Enter the num");
            num = int.Parse(Console.ReadLine());
            while (num != num1)
            {
                sum += num;

                num1 = num;
                Console.WriteLine("Enter the num");
                num = int.Parse(Console.ReadLine());
                if (num1 == num)
                {
                    Console.WriteLine("Sum is" + sum);
                }
            }
        }
    }
}
