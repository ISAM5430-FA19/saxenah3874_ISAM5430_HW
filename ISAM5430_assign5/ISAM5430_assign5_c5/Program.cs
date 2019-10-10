using System;

namespace ISAM5430_assign5_c5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter month");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter day");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter year");
            int y = int.Parse(Console.ReadLine());
            Date date = new Date(m, d, y);
            Console.WriteLine("Display" + date.DisplayDate());
        }
    }
}
