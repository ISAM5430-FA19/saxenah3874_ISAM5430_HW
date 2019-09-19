using System;
using static System.Console;
namespace b._6
{
    class Program
    {
        static void Main(string[] args)
        {

            string output = "";
            int count = 0;
            int num = 1;
            int flag = 0;

            int minnum = int.MaxValue;
            WriteLine("Enter the num");
            while (num > 0)
            {
                flag = 0;
                num = int.Parse(ReadLine());
                if (minnum == 0 || num < minnum)
                {
                    minnum = num;
                }
                else if (num >= minnum * minnum)
                {
                    count++;

                    output += num + "|";
                    WriteLine("Enter new set");
                    num = 1;
                    flag = 1;
                    minnum = int.MaxValue;


                }

                if (flag == 0)
                {
                    output += num + ",";
                }
            }

            WriteLine("Final Output is " + output);
            WriteLine("Count is" + count);
        }
    }
}
