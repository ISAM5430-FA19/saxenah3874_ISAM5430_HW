using System;

namespace B3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the decimal number between 0 and 4");
            decimal GPA = Decimal.Parse(Console.ReadLine());
            if(GPA< 0 || GPA > 4)
            {
                Console.WriteLine("GPA is invalid");
            }
            int tGPA = (int)(3 * GPA + 0.5m);
string grade="";
            if (tGPA > 10)
            {
                grade = "A";
                
                    if (tGPA < 12)
                    {
                        grade += "-";

                    }
                

            }
           else if (tGPA > 7)
            {
                grade = "B";

                if (tGPA < 9)
                {
                    grade += "-";

                }
                else if
                    (tGPA>9 && tGPA <=10)
                {
                    grade += "+";

                }


            }
           else if (tGPA > 4)
            {
                grade = "C";

                if (tGPA < 6)
                {
                    grade += "-";

                }
                else if
                   (tGPA > 6 && tGPA <= 7)
                {
                    grade += "+";



                }
            }
              else  if (tGPA > 2)
            {
                grade = "D";

                 if
                    (tGPA > 3 && tGPA <=4)
                    {
                        grade += "+";



                    }
                   

            }
            else
            {
                grade = "F";
            }




            Console.WriteLine(tGPA+"The grade is"+grade);
            
        }
    }
}
