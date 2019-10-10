using System;

namespace Isam5430_assign5_c._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int d, c, dollars, cents;
            
            Console.Write("Enter original amt in dollar");
            dollars = int.Parse(Console.ReadLine());
            Console.Write("Enter original amt in cents");
             cents=int.Parse(Console.ReadLine());
            Money money = new Money(dollars, cents);

            Console.Write("Enter decrement amount in dollar");
          d = int.Parse(Console.ReadLine());
            Console.Write("Enter decrement amount in cents");
            c = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"Original amount is {money.dollars}.{money.cents}");
            money.DecrementMoney(d, c);
            Console.WriteLine($"decremented amount is {money.dollars}.{money.cents}");
           
            Console.Write("Enter increment amount in dollar");
             d = int.Parse(Console.ReadLine());
            Console.Write("Enter increment amount in cents");
            c = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"Original amount is {money.dollars}.{money.cents}");
            money.IncrementMoney(d, c);
            //Money inc = m.IncrementMoney(d, c);
            Console.WriteLine($"incremented amount is {money.dollars}.{money.cents}");

            Console.WriteLine(money.ToString());


        }
    }
}
