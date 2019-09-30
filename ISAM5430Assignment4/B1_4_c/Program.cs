using System;

namespace B1_4_c
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, z, sum = 0;
            for (i = 1; i <= 5; i++)
            {

                for (j = 1; j <= 5; j++)
                {

                    sum += i * j;
                    
                }
            }
            Console.WriteLine("Sum is " + sum);
        }
    }
}
