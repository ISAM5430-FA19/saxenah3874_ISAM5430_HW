using System;

namespace C9.d
{
    class Program
    {
        static void Main(string[] args)
        {
            //Good condition: abide, badic
            //Bad condition: aeiou, bcdef, abidc
            char prev = '\0';
            int count = 0;
            int flag = 0;
            int valA = 0, valB = 0, valC = 0, valD = 0; //Moved this line above while(true), whenever you enter each character, your valA/B/C/D is resetting to 0, hence failing the condition
            Console.WriteLine("Enter the sequence");
            while (true)
            {
                
                var keysInfo = Console.ReadKey();
                char letter = char.ToUpperInvariant(keysInfo.KeyChar);
                if (!char.IsLetter(letter)) break;
                bool vowel = letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U' || letter == 'Y';
                bool consonant = letter != 'A' && letter != 'E' && letter != 'I' && letter != 'O' && letter != 'U' && letter != 'Y';

                if (count % 2 == 0)
                {
                    valA = (vowel ? 1 : 0);
                    valB = (consonant ? 1 : 0);
                }
                if (count % 2 != 0)
                {
                    valC = (consonant ? 1 : 0);
                    valD = (vowel ? 1 : 0);

                }
                if ((valA == valC || valB == valD) && flag == 0 && count != 0)
                {
                    flag = 1;
                }
                else if((valA != valC || valB != valD)&&(count != 0)) //When count == 0, you do not have second character to compare, so give count!=0
                {
                    flag = 0;
                }
                count++;
                prev = letter;

            }
            if (flag == 1)
            {
                Console.WriteLine("\nYes. Alternate vowels and consonants");
            }
            else
            {
                Console.WriteLine("\nNo. Its not alternate vowels and consonants");
            }

            Console.ReadLine();


        }
    }
}
