using System;
using System.Collections.Generic;
using System.Text;

namespace ISAM5430_assign_5C1
{
    class Student
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public int studentnumber { get; set; }
        public decimal GPA;
        private string classification;
        private string major;

        public Student(string fname,string lname,int std_num,decimal gpa)
        {
            firstname = fname;
            lastname = lname;
            studentnumber = std_num;
            GPA = gpa;
        }

    }
}
