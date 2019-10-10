using System;

namespace ISAM5430_Assign5_c4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name");
            string n = Console.ReadLine();
            Console.WriteLine("Enter the type");
            string t = Console.ReadLine();
            Console.WriteLine("Enter the location");
            string l = Console.ReadLine();
            Console.WriteLine("Enter the fee");
            decimal f = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter the employee count");
            int e  = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the visitors");
            int v = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the budget");
            int b = int.Parse(Console.ReadLine());

            Parks parks = new Parks(n,t,l,f,e,v,b);
           Console.WriteLine (parks.Display1());
            Console.WriteLine(parks.Displayfa());
            Console.WriteLine(parks.visitcost());
            Console.WriteLine(parks.ToString());
        }
    }
}
