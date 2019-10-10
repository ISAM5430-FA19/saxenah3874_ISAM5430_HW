using System;
using System.Collections.Generic;
using System.Text;

namespace Isam5430_assign5_c._3
{
    class Money
    {
        public int dollars { get; set; }
        public int cents { get; set; }
        public Money(int d, int c)
        {
            dollars = d;
            cents = c;
        }
        public Money(double m)
        {
            m = dollars + 0.01 * cents;
        }
        public void IncrementMoney(int d, int c)
        {
          
            dollars += d;
            cents += c;
            

        }
        public void DecrementMoney(int d, int c)
        {
          
            dollars -= d;
            cents -= c;
          

        }
        public override string ToString()
        {
            return ($"{dollars} dollars {cents} cents ");
        }
    }
    }
