using System;

namespace D1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i= 1;
            int pos = 0;
            int even = 0;
            int zero = 0;
            int max = int.MinValue;
            int min = int.MaxValue;
            bool check = true;
            int prev = 0;
            Console.Write("Enter the count");
            int count = int.Parse(Console.ReadLine());
            while (i <=count)
            {
                Console.WriteLine("enter " + i + " number");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num > 0)
                {
                    pos++;
                   
                }
                if (num == 0)
                {
                    zero++;
                    
                }

                if (num % 2 == 0)
                {
                    even++;
                   
                }
                
                if (num > max)
               {
                    max = num;
                   
                }
                 if (num < min)
                {
                    min = num;
                  
               }
                 if(num>prev && check ==true)
                { prev = num;
                   
                        }
                else
                {
                    check = false;
                    
                }
              
                i++;
                                 
            }
            Console.WriteLine("pos:" + pos + "zero:" + zero + "even:" + even+"max:"+max+"min:"+min+"check"+check);

        }
    }
}
