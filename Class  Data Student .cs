using System;
using Student_Advisor_Manager__Quiz_;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Student_Advisor_Manager__Quiz_
{
    public class Student : Person
    {
        public string StudentID { get; set; }
        public double GPA { get; set; }
        public Advisor Advisor { get; private set; }

        public Student(string studentID, string fullName, string department, double gpa, Advisor advisor)
            : base(fullName, department)
        {
            StudentID = studentID;
            GPA = gpa;
            Advisor = advisor;
            advisor.AddAdvisee(this);
        }
    }
}
