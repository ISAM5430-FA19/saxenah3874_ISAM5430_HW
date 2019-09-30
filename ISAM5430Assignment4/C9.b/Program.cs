using System;

namespace C9.b
{
    class Program
    {
        static void Main(string[] args)
        {
            int flag = 0;
            Console.WriteLine("Enter the sequence");
            while (true)
            {
                //Good condition: abcdefg, cabbaged, abcd, bag
                //Bad condition: abcdefgh, cabbagedh, hijklm, cable

                var KeyInfo = Console.ReadKey();
                char letter = char.ToUpperInvariant(KeyInfo.KeyChar);
                if (!char.IsLetter(letter)) break;
                //letter != 'G' was missed in your earlier code and it was passing the input 'cable', it should be failing. fixed by changing if condition
                if (!(letter >= 'A' && letter <= 'G'))
                    flag = 1;

            }
            if (!(flag == 1))
            {
                Console.WriteLine("Yes is musical");
            }


            else
            {
                Console.WriteLine("No is not musical");
            }
            Console.ReadLine();


        }
    }
    }

