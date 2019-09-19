using System;

namespace b._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int prev = 0;
            int max = int.MinValue;
            Console.WriteLine("Enter the num");
            num = int.Parse(Console.ReadLine());
            while (num > prev)
            {
                prev = num;
                Console.WriteLine("Enter the num");
                num = int.Parse(Console.ReadLine());
                if (num > max)
                {
                    max = num;
                }
                if (num < prev)
                {

                    Console.WriteLine("Largest value is" + max);


                }
            }
        }
    }
}

