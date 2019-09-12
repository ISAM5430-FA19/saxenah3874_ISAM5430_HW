using System;

namespace D2._11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the count");
            int count = int.Parse(Console.ReadLine());
            int i = 1;
            int prev = 0;
            bool check = false;
            while(i<=count)
            {
                Console.WriteLine("enter the number" + i);
                int num = int.Parse(Console.ReadLine());
                if (num == 2) {
                    if (prev == num)
                    {
                        check = true;
                    }
                    else
                    {
                        check = false;
                    }
                    
                }
                prev = num;
                i++;

            }
            Console.WriteLine("check"+check);

        }
    }
}
