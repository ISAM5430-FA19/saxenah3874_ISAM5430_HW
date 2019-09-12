using System;

namespace C3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 1;
            int series = 0;
            int num3;
            Console.WriteLine(+num1);
            Console.WriteLine(+num2);
            while (series < 23)
            {
                num3 = num1 + num2;
                Console.WriteLine(+num3);
                num1 = num2;
                num2 = num3;
                series++;
            }
        }
    }
}
