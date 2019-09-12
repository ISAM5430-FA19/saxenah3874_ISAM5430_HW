using System;

namespace c1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num2 = 1;

            while (num2 <= 10)
            {
                if (num2 % 2 == 0 && num2 != 0)
                {
                    Console.WriteLine(+num2);
                }
                num2++;
            }

        }
    }
}
