using System;
using static System.Console;
namespace c._2
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
                    if (i > 0)
                    {
                        Write(+i * j);
                    }
                    else
                    {
                        Write(+j);
                    }
                }
                WriteLine("\n");
            }
        }
    }
}
