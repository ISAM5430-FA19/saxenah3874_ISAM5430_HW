using System;

namespace B2._3.c
{
    class Program
    {
        static void Main(string[] args)
        {
            char a, b;
            for (a = 'A'; a <= 'H'; a++)
            {
                if (a != 'A' && a != 'E')
                {
                    for (b = 'A'; b <= 'H'; b++)
                    {
                        if (b == 'A' || b == 'E')
                        {
                            Console.WriteLine(a + " " + b);
                        }
                    }
                }
            }
        }
    }
}
