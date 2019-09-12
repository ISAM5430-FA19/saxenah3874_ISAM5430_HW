using System;

namespace D2._12
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int count1 = 0;
            int count4 = 0;
            bool check = true;
            while (count < 5)
            {
                Console.WriteLine("Enter the number" + count);
                int num = int.Parse(Console.ReadLine());
                if (num == 1)
                {
                    count1++;
                   
                }
                if (num == 4)
                {
                    count4++;
                    
                }
                count++;
            }
            Console.WriteLine(+count1);
            Console.WriteLine(+count4);
            if (count1 > count4)
            {
                check = true;
                Console.WriteLine("check"+check);
            }
            else
            {
                check = false;
                Console.WriteLine("check" + check);
            }
        }
    }
}
