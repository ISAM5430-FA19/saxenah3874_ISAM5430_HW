using System;
using static System.Console;
namespace b._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int revnum = 0;
            int r = 0;

            WriteLine("Enter the num");
            num = int.Parse(ReadLine());
            for (int i = num; i != 0; i = i / 10)
            {
                r = i % 10;
                revnum = revnum * 10 + r;
            }
            WriteLine("Revnum is " + revnum);
        }
    }
}
