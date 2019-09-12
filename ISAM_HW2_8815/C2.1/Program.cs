using System;

namespace C2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            while (num < 100)
            {
                Console.WriteLine(+num);
                num = num + num;
                
            }
        }
    }
}
