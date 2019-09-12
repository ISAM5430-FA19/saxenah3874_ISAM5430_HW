using System;

namespace C1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            while (num < 20)
            {
                if (num % 3 != 0 && num%2!=0)
                {
                    Console.WriteLine(+num);
                }
                num++;
            }
        }
    }
}
