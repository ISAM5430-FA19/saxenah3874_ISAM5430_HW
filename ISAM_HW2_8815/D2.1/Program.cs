using System;

namespace D2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the count");
            int count = int.Parse(Console.ReadLine());
            int i = 1;
            int sum = 0;
            int max = int.MinValue;
            int min = int.MaxValue;
            while (i<=count)
            {
                Console.WriteLine("Enter number" + i);
                int num = int.Parse(Console.ReadLine());
                           
                sum += num;
                max = Math.Max(max, num);
                min = Math.Min(min, num);
                i++;
                
            }
            Console.WriteLine("sum" + sum);
            Console.WriteLine("max" + max);
            Console.WriteLine("min" + min);
           
          int avg = sum - (max+min);
            Console.WriteLine(+avg/(count-2));

    
        }
    }
}
