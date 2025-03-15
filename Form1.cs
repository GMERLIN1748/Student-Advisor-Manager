namespace Student_Advisor_Manager__Quiz_
{
    public partial class Form1 : Form
    {
        private List<Student> students = new List<Student>();
        private List<Advisor> advisors = new List<Advisor>();
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            // สร้างอาจารย์ 20 คน
            for (int i = 1; i <= 20; i++)
            {
                advisors.Add(new Advisor($"ดร.อาจารย์{i} สมศรี (ตัวอย่าง)", $"สาขาที่{i % 5 + 1}"));
            }

            Random random = new Random();
            // สร้างนักศึกษา 20 คน และสุ่มที่ปรึกษา
            for (int i = 1; i <= 20; i++)
            {
                Advisor advisor = advisors[random.Next(advisors.Count)];
                students.Add(new Student($"65{i:03}", $"นักศึกษา{i} ทดสอบ", $"สาขาที่{i % 5 + 1}", Math.Round(random.NextDouble() * 2 + 2, 2), advisor));
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // รับข้อมูลนักศึกษาใหม่จากผู้ใช้
            string studentID = Microsoft.VisualBasic.Interaction.InputBox("กรอกรหัสนักศึกษา:", "เพิ่มนักศึกษา");
            string fullName = Microsoft.VisualBasic.Interaction.InputBox("กรอกชื่อนามสกุลนักศึกษา:", "เพิ่มนักศึกษา");
            string department = Microsoft.VisualBasic.Interaction.InputBox("กรอกสาขาที่เรียน:", "เพิ่มนักศึกษา");
            string gpaInput = Microsoft.VisualBasic.Interaction.InputBox("กรอกเกรดเฉลี่ย (GPA):", "เพิ่มนักศึกษา");
            double gpa;
            if (!double.TryParse(gpaInput, out gpa))
            {
                MessageBox.Show("กรุณากรอกเกรดเฉลี่ยเป็นตัวเลข", "ข้อผิดพลาด");
                return;
            }

            // เลือกอาจารย์ที่ปรึกษาแบบสุ่ม
            Random random = new Random();
            Advisor advisor = advisors[random.Next(advisors.Count)];

            // เพิ่มนักศึกษาใหม่
            Student newStudent = new Student(studentID, fullName, department, gpa, advisor);
            students.Add(newStudent);

            MessageBox.Show($"เพิ่มนักศึกษาเรียบร้อยแล้ว:\n{fullName} ({studentID})\nGPA: {gpa}\nที่ปรึกษา: {advisor.FullName}", "เพิ่มนักศึกษา");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // แสดงข้อมูลนักศึกษาในที่ปรึกษา
            string result = "";
            foreach (var advisor in advisors)
            {
                result += $"อาจารย์ที่ปรึกษา: {advisor.FullName}\n";
                foreach (var student in advisor.GetAdvisees())
                {
                    result += $" - {student.FullName} ({student.StudentID})\n";
                }
                result += "\n";
            }
            MessageBox.Show(result, "รายชื่อนักศึกษาในที่ปรึกษา");
        }
    }
}
