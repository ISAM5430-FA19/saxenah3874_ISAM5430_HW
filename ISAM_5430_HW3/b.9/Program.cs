﻿using System;
using static System.Console;
namespace b._9
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter the number: ");
            int input = int.Parse(ReadLine());
            string output = "";
            int rev = 0, flag = 0;

            if (input % 2 == 0) flag = 1;

            while (input > 0)
            {
                output += input % 2;
                input = input / 2;
            }

            int value = int.Parse(output);
            while (value > 0)
            {
                rev = (rev * 10) + (value % 10);
                value = value / 10;
            }


            if (flag == 1)
                WriteLine("Output: " + rev + "0");
            else
                WriteLine("Output: " + rev);

            ReadLine();
        }
    }
}
