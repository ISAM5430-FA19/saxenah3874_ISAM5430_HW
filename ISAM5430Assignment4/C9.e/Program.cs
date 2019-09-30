using System;

namespace C9.e
{
    class Program
    {
        static void Main(string[] args)
        {
             //Good condition: feed, noon, abcd, deef
            //Bad condition: abcg, bad, good, car
            char prev = '\0';
            int flag = 0;
            Console.WriteLine("Enter the sequence");
            while (true)
            {
                var keysInfo = Console.ReadKey();
                char letter = char.ToUpperInvariant(keysInfo.KeyChar);

                if (!char.IsLetter(letter)) break;

                if ((prev - letter) >= -1 && (prev - letter) <= 1)
                    flag = 1;
                else
                    flag = 0; // added else loop, as bad conditions were also showing as 'transition is smooth'
                prev = letter;

            }
            if (flag == 1)
            {
                Console.WriteLine("Transition is smooth");
            }
            else
            {
                Console.WriteLine("Transition is not smooth"); // added to display for bad conditions
            }
            Console.ReadLine();
        }
    }
}
