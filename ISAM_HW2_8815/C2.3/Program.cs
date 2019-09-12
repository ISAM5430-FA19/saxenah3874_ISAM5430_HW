using System;

namespace C2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            float num = 100;
            while (num > 1)
            {
                Console.WriteLine(+num);
                num = num / 2;
            }
        }
    }
}
