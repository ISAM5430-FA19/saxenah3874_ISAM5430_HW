using System;

namespace C3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            int fact = 1;
            while (fact<1000)
            {
                
                fact = fact * num;
                if (fact < 1000)
                {
                    Console.WriteLine(+fact);
                }
                num = num + 1;
                
            }
        }
    }
}
