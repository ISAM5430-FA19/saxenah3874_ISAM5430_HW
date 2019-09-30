using System;

namespace B_2_4_a
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            for (i = 1; i <= 5; i++)
            {
                for(j=i+1;j<=5;j++)
                {
                    if (i != j)
                    {
                        Console.WriteLine(i + ", " + j);
                    }
                }
            }
        }
    }
}
