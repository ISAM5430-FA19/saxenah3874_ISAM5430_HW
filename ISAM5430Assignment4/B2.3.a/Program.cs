using System;

namespace B2._3.a
{
    class Program
    {
        static void Main(string[] args)
        {
            char a, b;
            for (a = 'A'; a <= 'H'; a++)
            {
                for (b = 'A'; b <= 'H'; b++)
                {
                    if (a == 'A' || a == 'E' || b == 'A' || b == 'E')
                    {
                        Console.WriteLine(a + " " + b);
                    }
                }
            }
        }
    }
}
