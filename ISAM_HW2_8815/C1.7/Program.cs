using System;

namespace C1._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i<26)
            {
                Console.Write(Convert.ToChar(i+97));
                i++;
            }

        }
    }
}
