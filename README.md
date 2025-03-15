# Student Management System

### นาย กฤติน อินทร์ตระกูล
### 673450030-6

# คำอธิบายโปรเจคต์
โปรแกรมสำหรับ อาจารย์ ใช้บันทึกข้อมูล นักศึกษา ตามหลักการ OOP โดยมีคุณสมบัติดังนี้:
-บันทึก รหัสนักศึกษา, ชื่อ-นามสกุล, สาขา, อาจารย์ที่ปรึกษา
-บันทึก ข้อมูลอาจารย์ที่ปรึกษา (ชื่อ-นามสกุล, สาขา, รายชื่อนักศึกษา)
-นักศึกษามีที่ปรึกษาได้ 1 คน, อาจารย์ดูแลนักศึกษาได้หลายคน
-แสดงรายชื่อนักศึกษาทั้งหมดของอาจารย์ที่ปรึกษา
-แสดงนักศึกษาที่มี GPA สูงสุด


# โครงสร้างโปรแกรม
## Encapsulation (การห่อหุ้มข้อมูล)

-ข้อมูลของนักศึกษา (Student) และอาจารย์ที่ปรึกษา (Advisor) ถูกเก็บเป็น private fields
-มี properties และ methods สำหรับเข้าถึงข้อมูล เช่น GetAdvisees() ใน Advisor
-ป้องกันการเปลี่ยนแปลงค่าภายในโดยตรงจากภายนอก

## Abstraction (การซ่อนรายละเอียด)

-คลาส Person ถูกใช้เป็นคลาสแม่ของ Student และ Advisor
-ซ่อนรายละเอียดการทำงาน เช่น รายชื่อนักศึกษาในที่ปรึกษาจะถูกจัดการผ่าน AddStudent() และ GetAdvisees() แทนการเข้าถึง List<Student> ตรง ๆ

## Polymorphism (พหุนิยม)

ใช้เมธอด DisplayInfo() ใน Person และ Override ใน Student และ Advisor
สามารถเรียก DisplayInfo() ผ่านตัวแปรประเภท Person ได้ ไม่ว่าจะเป็น Student หรือ Advisor

## Inheritance (การสืบทอดคลาส)

คลาส Student และ Advisor สืบทอดจาก Person
ทำให้สามารถใช้คุณสมบัติพื้นฐานร่วมกัน เช่น ชื่อ (FullName) และสาขา (Major)
Advisor มีคุณสมบัติเพิ่มเติม เช่น AdviseeList เพื่อเก็บนักศึกษาที่ตนเองดูแล

/StudentAdvisorManager
│── Program.cs       // Entry point ของโปรแกรม
│── Form1.cs         // UI หลักของโปรแกรม (WinForms)
│── Student.cs       // คลาสสำหรับจัดการข้อมูลนักศึกษา
│── Advisor.cs       // คลาสสำหรับจัดการข้อมูลอาจารย์ที่ปรึกษา
│── Person.cs        // คลาสแม่ (Base Class) ของ Student และ Advisor
│── README.md        // คำอธิบายโปรเจกต์
│── ClassDiagram.png // ไฟล์ Class Diagram

# class Diagram

+----------------------+
|       Form1         |
|----------------------|
| - students: List<Student> |
| - advisors: List<Advisor> |
|----------------------|
| + LoadData()        |
| + button1_Click()   |
| + button2_Click()   |
+----------------------+

        | contains
        v
+----------------------+
|      Student        |
|----------------------|
| - StudentID: string |
| - FullName: string  |
| - Department: string|
| - GPA: double       |
| - Advisor: Advisor  |
+----------------------+

        | associated with
        v
+----------------------+
|      Advisor        |
|----------------------|
| - FullName: string  |
| - Department: string|
| - AdviseeList: List<Student> |
|----------------------|
| + GetAdvisees(): List<Student> |
+----------------------+



## การใช้หลักการเขียนโปรแกรมเชิงวัตถุ (OOP) ในโปรแกรมนี้
โปรแกรมนี้ออกแบบและพัฒนาตามหลักการ Object-Oriented Programming (OOP) โดยมีการนำแนวคิดหลักมาใช้อย่างครบถ้วน ดังนี้

### Encapsulation (การห่อหุ้มข้อมูล)

คลาส Student และ Advisor มี private fields และใช้ properties หรือ methods ในการเข้าถึงข้อมูล
ข้อมูลนักศึกษาและที่ปรึกษาไม่สามารถเข้าถึงหรือเปลี่ยนแปลงจากภายนอกได้โดยตรง

### Abstraction (การซ่อนรายละเอียด)

ใช้คลาส Person เป็น คลาสแม่ และให้ Student และ Advisor สืบทอด
รายละเอียดการจัดการข้อมูล เช่น รายชื่อนักศึกษาในที่ปรึกษา ถูกซ่อนไว้ และเข้าถึงได้ผ่านเมธอด AddStudent() และ GetAdvisees()

### Polymorphism (พหุนิยม)

ใช้เมธอด DisplayInfo() ใน Person และ Override ใน Student และ Advisor
สามารถเรียก DisplayInfo() ผ่านตัวแปรประเภท Person ได้ แม้จะเป็น Student หรือ Advisor

### Inheritance (การสืบทอดคลาส)

คลาส Student และ Advisor สืบทอดจาก Person
ทำให้สามารถใช้คุณสมบัติพื้นฐานร่วมกัน เช่น FullName และ Major
Advisor มีคุณสมบัติเพิ่มเติม เช่น รายชื่อนักศึกษาที่ปรึกษา (List<Student>)

















