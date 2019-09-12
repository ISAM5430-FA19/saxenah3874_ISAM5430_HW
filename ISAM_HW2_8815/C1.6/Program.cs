using System;

namespace C1._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            while (num < 100)
            {
                if(num%3!=0 && num%5!=0 || num%15==0)
                {
                    Console.WriteLine(+num);
                }
                num++;
            }
        }
    }
}
