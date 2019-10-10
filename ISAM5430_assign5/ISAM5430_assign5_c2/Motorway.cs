using System;
using System.Collections.Generic;
using System.Text;

namespace ISAM5430_assign5_c2
{
    class Motorway
    {

        public string motorway_name { get; set; }
        public string type { get; set; }
        public string direction { get; set; }
        public string surface { get; set; }
        public int lane { get; set; }
        public string toll { get; set; }
        public string party { get; set; }

        public Motorway(string mot_name, string mot_t, int mot_lane, string mot_toll)
        {
            motorway_name = mot_name;
            type = mot_t;
            lane = mot_lane;
            toll = mot_toll;
        }
        public void Name(string name)
        {
            motorway_name = name;
        }
        public void Namet(string name1, string toll1)
        {
            motorway_name = name1;
            toll = toll1;
        }
        public void Nametr(string name2, int lane1)
        {
            motorway_name = name2;
            lane = lane1;

        }
        public override string ToString()
        {
            return ($"{motorway_name} {type} {lane} {toll}");
        }
    }
}


