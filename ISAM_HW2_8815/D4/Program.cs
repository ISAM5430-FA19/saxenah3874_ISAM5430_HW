using System;

namespace D4
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 1;
            int prev = 0;
            while (count < 5)
            {
                Console.WriteLine(+count);
                prev = count;
                count++;
            }
                if (count > prev)
                {
                    Console.WriteLine("increaseing order");
                }
                //Console.WriteLine("Enter" + count + "number");
                //int num = Convert.ToInt32(Console.ReadLine());
               
                
                //count++;
                //if (num > prev)
                //{
                //    Console.WriteLine("increaseing order");
                   
                //}
                //prev = num;

            }
        }
    }

