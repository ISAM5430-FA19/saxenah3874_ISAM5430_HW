using System;

namespace C1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            while (num <= 100)
            {
                if (num % 10 == 0)
                {
                    Console.WriteLine(+num);
                }
                num++;
            }
        }
    }
}
