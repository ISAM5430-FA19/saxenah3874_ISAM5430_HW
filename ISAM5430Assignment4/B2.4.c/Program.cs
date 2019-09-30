using System;

namespace B2._4.c
{
    class Program
    {
        static void Main(string[] args)
        {
            char a, b, c;
            for( a = 'A'; a <= 'H'; a++)
            {
                bool vowelA= a == 'A' || a == 'E' ;
                for (b = 'A'; b <= 'H'; b++)
                {
                    bool vowelB = b == 'A' || b == 'E';
                    {
                        for (c = 'A'; c <= 'H'; c++)
                        {
                            bool vowelC = c == 'A' || c == 'E';
                            int valA = (vowelA ? 1 : 0) + (vowelB ? 1 : 0) + (vowelC ? 1 : 0);
                            if (valA>0 && valA<=2)
                            {
                                Console.WriteLine(a + " " + b + " " + c);
                            }
                        }
                    }

                }
            }
        }
    }
}
