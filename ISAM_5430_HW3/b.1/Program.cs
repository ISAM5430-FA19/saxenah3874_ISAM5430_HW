using System;

namespace b._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 0;
            int count = 0;

            int sum = 0;
            double avg = 0;
            int bestscore = int.MinValue;
            Console.WriteLine("Enter the score");
            score = int.Parse(Console.ReadLine());
            while (score <= 100 && score >= 0)
            {
                sum += score;
                count++;
                if (score > bestscore)
                {
                    bestscore = score;
                }
                Console.WriteLine("Enter the score");
                score = int.Parse(Console.ReadLine());
            }
            if (count > 0)
            {
                avg = (double)sum / count;
                Console.WriteLine("Avg is:" + avg);
                Console.WriteLine("Bestscore is:" + bestscore);
            }
            else
            {
                Console.WriteLine("Invalid score");
            }
            Console.ReadLine();

        }
    }
}
