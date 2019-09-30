using System;

namespace B2._4.a
{
    class Program
    {
        static void Main(string[] args)
        {
            char a, b, c;
            for (a = 'A'; a <='H'; a++)
            {
                if(a!='A'&& a != 'E')
                {
                    for (b = 'A'; b <= 'H'; b++)
                    {
                        if (b == 'A' || b == 'E')
                        {
                            for (c = 'A'; c <= 'H'; c++)
                            {
                                if(c!='A'&& c != 'E')
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
}
