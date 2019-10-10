using System;

namespace ISAM5430_assign_5C1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Himani", "Saxena", 1,4.0m);
            Student student2 = new Student("Parag", "Saxena", 2, 3.9m);

            Console.WriteLine($"{student1.studentnumber}  {student1.firstname} {student1.lastname} {student1.GPA }");
            Console.WriteLine($"{student2.studentnumber}  {student2.firstname} {student2.lastname} {student2.GPA }");

        }
    }
}
