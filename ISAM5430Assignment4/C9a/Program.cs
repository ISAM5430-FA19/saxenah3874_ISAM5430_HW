using System;

namespace C9a
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //Good condition: 'aegilops', 'abcdefgh', 'mprsz', 'axz'
            //Bad condition: 'aeegilops', 'aegiloss', 'zxbcde', 'zxmb'
            char prev = '\0';
            int flag = 0;
            Console.WriteLine("Enter sequence");
            while (true)
            {
                var keyInfo = Console.ReadKey();
                char letter = char.ToUpperInvariant(keyInfo.KeyChar);
                if (!char.IsLetter(letter)) break;

                if (letter > prev && prev != letter)
                    prev = letter;
                else
                    flag = 1;
            }
            if (!(flag == 1))
                Console.WriteLine("\nIncreasing order");
            else
                Console.WriteLine("\nNot in increasing order");
            Console.ReadLine();
            
        }
    }
}
