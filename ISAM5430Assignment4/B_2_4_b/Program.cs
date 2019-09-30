using System;

namespace B_2_4_b
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j,sum=0;
            for (i = 1; i <= 5; i++)
            {
                for (j = i + 1; j <= 5; j++)
                {
                    if (i != j)
                    {
                        sum += i * j;
                        
                    }
                }
            }
            Console.WriteLine(+sum);
        }
    }
}
