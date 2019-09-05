using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1_8815
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number 1");
            //string input = ;//returns string
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number 2");
            //input = Console.ReadLine();//reads line from keybooard and assigns to input variable
            int num2 =int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the operator:(+,-,/,*)");
            string op = Console.ReadLine();
            if (op == "+")
            {
                int tot = num1 + num2;
                Console.WriteLine($"{num1} {op} {num2} = { tot} ");
                Console.ReadLine();

            }
            if (op == "-")
            {
                int sub = num1 - num2;
                Console.WriteLine($"{num1} {op} {num2} = { sub } .");
                Console.ReadLine();
            }
            if (op == "*")
            {
                int mul = num1 * num2;
                Console.WriteLine($"{num1} {op} {num2} =  { mul}.");
                Console.ReadLine();
            }
            if (op == "/")
            {
                double div1 = 0.0;
                    div1= (double) num1 / num2;
                Console.WriteLine($"{num1} {op} {num2} =  {div1} .");
                Console.ReadLine();
            }

        }
    }
}

