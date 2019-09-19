using System;
using static System.Console;
namespace b._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int item = 0;
            int num = 0;
            int diff = 0;
            int closenum = 0;
            int mindiff = int.MaxValue;
            WriteLine("enter the item");
            item = int.Parse(ReadLine());
            WriteLine("Enter the num");
            num = int.Parse(ReadLine());
            while (num != item)
            {
                WriteLine("Num is" + num);
                diff = item - num;

                if (diff < mindiff)
                {
                    mindiff = diff;
                    closenum = num;
                }
                WriteLine("Enter the num");
                num = int.Parse(ReadLine());
            }
            WriteLine("Closest num is:" + closenum);
            WriteLine("Closest diff is" + mindiff);
        }
    }
}
