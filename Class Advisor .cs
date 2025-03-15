using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Advisor_Manager__Quiz_
{
    // คลาสอาจารย์ที่ปรึกษาแยกในไฟล์ Class_Advisor
    public class Advisor
    {
        private List<Student> advisees = new List<Student>();

        public string FullName { get; set; }
        public string Department { get; set; }

        public Advisor(string fullName, string department)
        {
            FullName = fullName;
            Department = department;
        }

        public void AddAdvisee(Student student)
        {
            advisees.Add(student);
        }

        public List<Student> GetAdvisees()
        {
            return advisees;
        }
    }
}
