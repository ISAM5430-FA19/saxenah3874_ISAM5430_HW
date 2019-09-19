using System;

namespace c._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            var input = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= input; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + ",");

                }

            }
            Console.WriteLine("Count is " + input * (input + 1) / 2);
        }
    }
}
