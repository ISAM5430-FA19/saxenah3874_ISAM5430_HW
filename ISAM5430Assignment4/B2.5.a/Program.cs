using System;

namespace B2._5.a
{
    class Program
    {
        static void Main(string[] args)
        {
            char a, b, c;
            for (a = 'A'; a <= 'H'; a++)
            {
                bool vowelA = a == 'A' || a == 'E';
                for (b = 'A'; b <= 'H'; b++)
                {
                    bool vowelB = b == 'A' || b == 'E';
                    int vala = (vowelA ? 1 : 0) + (vowelB ? 1 : 0);
                    if (vala > 0)
                    {
                        Console.WriteLine(a + " " + b);
                    }
                    for (c = 'A'; c <= 'H'; c++)
                    {
                        bool vowelC = c == 'A' || c == 'E';
                        int valb = (vowelA ? 1 : 0) + (vowelB ? 1 : 0) + (vowelC ? 1 : 0);
                        if (valb > 0)
                        {
                            Console.WriteLine(a + " " + b+" "+c);
                        }

                    }
                       
                }
            }
        }
    }
}
