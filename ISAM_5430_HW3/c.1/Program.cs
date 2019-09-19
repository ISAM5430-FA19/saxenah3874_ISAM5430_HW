using System;
using static System.Console;
namespace c._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;

            WriteLine("Enter the integer");
            num = int.Parse(ReadLine());
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= num; j++)
                {
                    if (j == num)
                    {
                        Console.WriteLine("X");

                    }
                    else
                    {
                        Console.Write("X");
                    }

                }
            }
        }
    }
}
    