using System;

namespace PracticeC3
{
    class Program
    {
        static void Main(string[] args)
        {
            int d = 0, n = 0,twopower=1,tenpower = 1,r=0,count=0;
            Console.WriteLine("Enter the value of d");
            d = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of n");
            n = int.Parse(Console.ReadLine());
        
                for (int i = 1; i <= d; i++)
                {
                twopower *= 2;
                tenpower *= 10;
                }
               
                r = n % tenpower;
            
            Console.WriteLine("Twopower is" + twopower);
            Console.WriteLine("Tenpower is" + tenpower);

            if (r % twopower == 0)
                {
                Console.WriteLine("No is divisible by " + twopower);
                }
            }
        }
    }

