using System;

namespace C4
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            double avg = 0.0;
            int count = 0;
            while (count < 5)
            {
                Console.WriteLine("Enter" + count+"number");
                int num = Convert.ToInt32(Console.ReadLine());
                
                sum = sum + num;
                
                count++;

            }
            Console.WriteLine(+sum);
            avg = (double)sum / count;
            Console.WriteLine(+avg);

           
        }
    }
}
