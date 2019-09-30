using System;

namespace C9.c
{
    class Program
    {
        static void Main(string[] args)
        {
            //Good condition: nonsupports, xyz, pop, toy
            //Bad condition: baby, jio, popeys, abcd
            int flag = 0;
            Console.WriteLine("Enter the sequence");
            while (true)
            {

                var keyInfo = Console.ReadKey();
                char letter = char.ToUpperInvariant(keyInfo.KeyChar);
                if (!char.IsLetter(letter)) break;

                //Changed the if condition to letter <= 'z' and displayed output outside while loop
                //if (letter >'m' && letter <'z')
                if (!(letter >= 'N' && letter <= 'Z'))
                    flag = 1;
                
            }
            if (flag == 0)
                Console.WriteLine("It falls in second half");
            else
                Console.WriteLine("It does not fall in second half");
            Console.ReadLine();
            
        }
    }
}
