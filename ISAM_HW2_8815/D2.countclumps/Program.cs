using System;

namespace D2.countclumps
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the count");
            int count = int.Parse(Console.ReadLine());
            int count1 = 0;
            int i=1;
            int prev = -1;
            bool flag = false;
            
            while (i<=count)
            {
                Console.WriteLine("Enter num" + i);
                
                int num = int.Parse(Console.ReadLine());
                if (prev == num && !flag)
                {
                    flag = true;
                    count1++;
                }
                else if (prev != num) flag = false;
                prev = num;
                i++;
            }
            Console.WriteLine(count1);
        }
    }
}
