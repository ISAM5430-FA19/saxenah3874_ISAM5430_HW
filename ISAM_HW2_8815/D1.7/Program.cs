using System;

namespace D1._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the count");
            int count = int.Parse(Console.ReadLine());
            int i = 1;
            int half = count / 2;
            int sumhalf = 0;
            int otherhalf = 0;
            int skipPointer = half + 1;
            while (i<=count)
            {
                Console.WriteLine("Enter the number" + i);
                int num = int.Parse(Console.ReadLine());
                if (i <= half)
                {
                    sumhalf += num;
                }
                else if(count%2!=0 && i != skipPointer)
                {
                    otherhalf += num;
                }
                else if (count % 2 == 0)
                {
                    otherhalf += num;
                }
                i++;

            }
            if (sumhalf == otherhalf)
            {
                Console.WriteLine("Its true");
            }
        }
    }
}
