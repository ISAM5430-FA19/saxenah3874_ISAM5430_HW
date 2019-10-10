using System;
using System.Collections.Generic;
using System.Text;

namespace ISAM5430_assign5_c5
{
    class Date
    {
        private int month;
        private int day;
        public int year { get; set; }
        public int Month
        {
            get
            {
                return month;
            }
            set
            {
                if (value >= 1 && value <= 12)month = value;
            }
        }
        public int Day
        {
            get { return day; }
            set
            {
                if (value >= 1 && value <= 31) day = value;
            }
        }
        public Date(int m,int d,int y)
        {
            month = m;
            day = d;
            year = y;
        }
        public string DisplayDate()
        {
            //return ($"{ month}/{ day}/{ year}");
            DateTime dt = new DateTime(year, month, day);
            return dt.ToString("d");
        }
    }
}
