using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Advisor_Manager__Quiz_
{
    public abstract class Person
    {
        public string FullName { get; set; }
        public string Department { get; set; }

        protected Person(string fullName, string department)
        {
            FullName = fullName;
            Department = department;
        }
    }
}
