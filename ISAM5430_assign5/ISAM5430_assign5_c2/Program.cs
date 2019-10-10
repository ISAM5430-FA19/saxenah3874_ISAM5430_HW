using System;

namespace ISAM5430_assign5_c2
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorway motorway = new Motorway("Himani","Road",4,"No toll");
            //Motorway motorway2 = new Motorway("Parag", "Sea", 6, "No toll");
            //Motorway motorway3 = new Motorway("Jake", "Street", 2, "No toll");
            Console.WriteLine("Enter the name");
            string name = Convert.ToString(Console.ReadLine());
            motorway.Name(name);
            string name1 = Convert.ToString(Console.ReadLine());
           
            Console.WriteLine("Enter the if it takes toll");
            string toll1 = Convert.ToString(Console.ReadLine());
            motorway.Namet(name1, toll1);
           
            Console.WriteLine(motorway.ToString());



        }
    }
}
