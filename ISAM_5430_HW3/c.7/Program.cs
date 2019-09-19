using System;
using static System.Console;
namespace c._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Enter the number: ");
            int n = int.Parse(ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                for (int j = 1; j <= n; j++)
                {
                    if (j < n - (i - 1))
                    {
                        Console.Write(0 + ",");
                    }
                    else if (i == n)
                    {
                        Console.Write(i - (j - 1) + ",");
                    }
                    else
                    {
                        Console.Write((n + 1) - j + ",");
                    }
                }
            }
            ReadLine();
        }
    }
}
