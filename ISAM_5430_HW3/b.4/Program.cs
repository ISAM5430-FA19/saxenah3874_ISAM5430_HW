using System;

namespace b._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int side1 = 0;
            int side2 = 0;
            int side3 = 0;
            Console.WriteLine("Enter side1");
            side1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter side2");
            side2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter side3");
            side3 = int.Parse(Console.ReadLine());
            while (side1 > 0 && side2 > 0 && side3 > 0)
            {
                if (side1 + side2 == side3 || side2 + side3 == side1 || side3 + side1 == side2)
                {
                    Console.WriteLine("Triangle is valid");
                }
                else
                {
                    Console.WriteLine("Traingle is not valid");
                }
                Console.WriteLine("Enter side1");
                side1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter side2");
                side2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter side3");
                side3 = int.Parse(Console.ReadLine());

            }
        }
    }
}
