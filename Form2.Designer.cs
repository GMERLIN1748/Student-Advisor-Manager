namespace WinFormsApp1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmbAdvisor1 = new ComboBox();
            button3 = new Button();
            label10 = new Label();
            txtPhone = new TextBox();
            label9 = new Label();
            button2 = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtKKUMail = new TextBox();
            txtclassadvisor = new TextBox();
            txtadvisor = new TextBox();
            txtGPA = new TextBox();
            txtDepartment = new TextBox();
            txtFullName = new TextBox();
            txtStudentID = new TextBox();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // cmbAdvisor1
            // 
            cmbAdvisor1.FormattingEnabled = true;
            cmbAdvisor1.Location = new Point(538, 119);
            cmbAdvisor1.Name = "cmbAdvisor1";
            cmbAdvisor1.Size = new Size(151, 28);
            cmbAdvisor1.TabIndex = 44;
            cmbAdvisor1.SelectedIndexChanged += cmbAdvisor1_SelectedIndexChanged;
            // 
            // button3
            // 
            button3.Location = new Point(499, 302);
            button3.Name = "button3";
            button3.Size = new Size(248, 51);
            button3.TabIndex = 43;
            button3.Text = "แสดงข้อมูลเกรดนักศึกษา";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(100, 359);
            label10.Name = "label10";
            label10.Size = new Size(64, 20);
            label10.TabIndex = 42;
            label10.Text = "เบอร์โทร :";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(163, 359);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(301, 27);
            txtPhone.TabIndex = 41;
            txtPhone.TextChanged += txtPhone_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(198, 78);
            label9.Name = "label9";
            label9.Size = new Size(248, 20);
            label9.TabIndex = 40;
            label9.Text = "มหาวิทยาลัยขอนแก่น วิทยาเขตหนองคาย ";
            // 
            // button2
            // 
            button2.Location = new Point(499, 250);
            button2.Name = "button2";
            button2.Size = new Size(248, 46);
            button2.TabIndex = 39;
            button2.Text = "แสดงข้อมูลนักศึกษาทั้งหมด";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(87, 326);
            label8.Name = "label8";
            label8.Size = new Size(77, 20);
            label8.TabIndex = 38;
            label8.Text = "KKU mail :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(63, 293);
            label7.Name = "label7";
            label7.Size = new Size(101, 20);
            label7.TabIndex = 37;
            label7.Text = "สาขา(อาจารย์) :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(54, 260);
            label6.Name = "label6";
            label6.Size = new Size(110, 20);
            label6.TabIndex = 36;
            label6.Text = "อาจารยที่ปรึกษา :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(91, 227);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 35;
            label5.Text = "เกรดเฉลี่ย :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(117, 193);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 34;
            label4.Text = "สาขา :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(76, 160);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 33;
            label3.Text = "ชื่อ-นามสกุล :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 127);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 32;
            label2.Text = "รหัสนักศึกษา :";
            // 
            // txtKKUMail
            // 
            txtKKUMail.Location = new Point(163, 326);
            txtKKUMail.Name = "txtKKUMail";
            txtKKUMail.Size = new Size(301, 27);
            txtKKUMail.TabIndex = 31;
            txtKKUMail.TextChanged += txtKKUMail_TextChanged;
            // 
            // txtclassadvisor
            // 
            txtclassadvisor.Location = new Point(163, 293);
            txtclassadvisor.Name = "txtclassadvisor";
            txtclassadvisor.Size = new Size(301, 27);
            txtclassadvisor.TabIndex = 30;
            txtclassadvisor.TextChanged += txtclassadvisor_TextChanged;
            // 
            // txtadvisor
            // 
            txtadvisor.Location = new Point(163, 260);
            txtadvisor.Name = "txtadvisor";
            txtadvisor.Size = new Size(301, 27);
            txtadvisor.TabIndex = 29;
            txtadvisor.TextChanged += txtadvisor_TextChanged;
            // 
            // txtGPA
            // 
            txtGPA.Location = new Point(163, 227);
            txtGPA.Name = "txtGPA";
            txtGPA.Size = new Size(301, 27);
            txtGPA.TabIndex = 28;
            txtGPA.TextChanged += txtGPA_TextChanged;
            // 
            // txtDepartment
            // 
            txtDepartment.Location = new Point(163, 193);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(301, 27);
            txtDepartment.TabIndex = 27;
            txtDepartment.TextChanged += txtDepartment_TextChanged;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(163, 160);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(301, 27);
            txtFullName.TabIndex = 26;
            txtFullName.TextChanged += txtFullName_TextChanged;
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(163, 127);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(301, 27);
            txtStudentID.TabIndex = 25;
            txtStudentID.TextChanged += txtStudentID_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(123, 44);
            label1.Name = "label1";
            label1.Size = new Size(388, 20);
            label1.TabIndex = 24;
            label1.Text = "แบบบันทึกข้อมูลนักศึกษาชั้นปีที่ 1 ประจำปีการศึกษา 2568 เทอม 1";
            // 
            // button1
            // 
            button1.Location = new Point(564, 359);
            button1.Name = "button1";
            button1.Size = new Size(125, 47);
            button1.TabIndex = 23;
            button1.Text = "บันทึกข้อมูล";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cmbAdvisor1);
            Controls.Add(button3);
            Controls.Add(label10);
            Controls.Add(txtPhone);
            Controls.Add(label9);
            Controls.Add(button2);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtKKUMail);
            Controls.Add(txtclassadvisor);
            Controls.Add(txtadvisor);
            Controls.Add(txtGPA);
            Controls.Add(txtDepartment);
            Controls.Add(txtFullName);
            Controls.Add(txtStudentID);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbAdvisor1;
        private Button button3;
        private Label label10;
        private TextBox txtPhone;
        private Label label9;
        private Button button2;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtKKUMail;
        private TextBox txtclassadvisor;
        private TextBox txtadvisor;
        private TextBox txtGPA;
        private TextBox txtDepartment;
        private TextBox txtFullName;
        private TextBox txtStudentID;
        private Label label1;
        private Button button1;
    }
}