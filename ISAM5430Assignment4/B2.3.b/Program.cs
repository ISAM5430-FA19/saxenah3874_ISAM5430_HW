using System;

namespace B2._3.b
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
                        if (a == 'A' && b != 'A' && b != 'E'||a=='E'&& b != 'A' && b != 'E'|| b == 'A' && a != 'A' && a != 'E' || b == 'E' && a != 'A' && a != 'E')
                        {
                            Console.WriteLine(a + " " + b);
                        }
                    }
                }
        }
    }
}
