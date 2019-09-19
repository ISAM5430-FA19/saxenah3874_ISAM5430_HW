using System;
using static System.Console;
namespace c._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type 'a' = lower left triangle; 'b' = upper left triangle; " +
                                     "'c' = upper right triangle; 'd' = lower right triangle.");
            // char t = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("ENter the num");
            int num = int.Parse(Console.ReadLine());

            // if (t == 'a')
            {
                for (int i = 1; i <= num; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine(" ");
                }
                Console.WriteLine();
            }

            // else if (t == 'b')
            {
                for (int i = 1; i <= num; i++)
                {
                    for (int j = i; j <= num; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine(" ");
                }
            }
            Console.WriteLine();

            // else if (t == 'c')
            {
                for (int i = 0; i <= num; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(" ");
                    }

                    for (int j = 1; j <= num - i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            // else if (t == 'd')
            {

                for (int i = 0; i <= num; i++)
                {
                    for (int j = 1; j <= num - i; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            }
        }
}
