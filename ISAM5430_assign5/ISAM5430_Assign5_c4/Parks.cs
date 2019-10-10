using System;
using System.Collections.Generic;
using System.Text;

namespace ISAM5430_Assign5_c4
{
    class Parks
    {
        public string name { get; set; }
        private string type;
        public string location { get; set; }
       
        public decimal fee { get; set; }
        public int emp { get; set; }
        public int visitor { get; set; }
        public double budget { get; set; }

        public string Type
        {
            get { return type; }
            set
            {
                if (value.Equals("National") || value.Equals("State") || value.Equals("Local")) type = value;
            }
        }

        public Parks(string n,string t,string l,decimal f,int e,int v,int b)
        {
            name = n;
            type = t;
            location = l;
            fee = f;
            emp = e;
            visitor = v;
            budget = b;
        }

        public string Display1()
        {
            return ("Name of Park "  + name +  " Location "  + location +  " Type "  + type);
        }
        public string Displayfa()
        {
            return ("Name of Park "  + name +  " Location "  + location +  " Facilities "  + type) ;
        }
        public double visitcost()
        {
            return (double)visitor * fee;
        }
        public override string ToString()
        {
            return ($"{name} {type} {location} {fee} {emp}{visitor}{budget}");
        }
    }
    
}
