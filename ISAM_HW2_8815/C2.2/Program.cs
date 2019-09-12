using System;

namespace C2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 100;
            while (num>=0)
            {
                Console.WriteLine(+num);
                if (num == 0) break;
              
                
                num =num / 2;

            }
        }
    }
}
