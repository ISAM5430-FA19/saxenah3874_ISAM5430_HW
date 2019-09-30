using System;

namespace B2._5.b
{
    class Program
    {
        static void Main(string[] args)
        {
            char a, b, c;
            for (a = 'A'; a <= 'H'; a++)
            {
                if (a != 'A' && a != 'E')
                {
                    for (b = 'A'; b <= 'H'; b++)
                    {
                        if (b == 'A'|| b== 'E')
                        {
                            Console.WriteLine(a + " " + b );
                        }
                       
                        
                        for (c = 'A'; c <= 'H'; c++)
                        {
                            
                           
                            if (c=='A'||c=='E')
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
