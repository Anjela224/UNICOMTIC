namespace UnicomTICManagementSystem.View
{
    partial class MainForm
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
            this.panel1sidebar = new System.Windows.Forms.Panel();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btntt = new System.Windows.Forms.Button();
            this.btnroom = new System.Windows.Forms.Button();
            this.btnexma = new System.Windows.Forms.Button();
            this.btnCourse = new System.Windows.Forms.Button();
            this.btnlecturer = new System.Windows.Forms.Button();
            this.btnSubject = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.lblwelcom = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAttend = new System.Windows.Forms.Button();
            this.panel1sidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1sidebar
            // 
            this.panel1sidebar.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1sidebar.Controls.Add(this.btnAttend);
            this.panel1sidebar.Controls.Add(this.btnlogout);
            this.panel1sidebar.Controls.Add(this.btntt);
            this.panel1sidebar.Controls.Add(this.btnroom);
            this.panel1sidebar.Controls.Add(this.btnexma);
            this.panel1sidebar.Controls.Add(this.btnCourse);
            this.panel1sidebar.Controls.Add(this.btnlecturer);
            this.panel1sidebar.Controls.Add(this.btnSubject);
            this.panel1sidebar.Controls.Add(this.btnStudent);
            this.panel1sidebar.Controls.Add(this.lblwelcom);
            this.panel1sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1sidebar.Location = new System.Drawing.Point(0, 0);
            this.panel1sidebar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1sidebar.Name = "panel1sidebar";
            this.panel1sidebar.Size = new System.Drawing.Size(216, 481);
            this.panel1sidebar.TabIndex = 0;
            this.panel1sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnlogout
            // 
            this.btnlogout.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.Location = new System.Drawing.Point(62, 377);
            this.btnlogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(74, 30);
            this.btnlogout.TabIndex = 8;
            this.btnlogout.Text = "Logout";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btntt
            // 
            this.btntt.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntt.Location = new System.Drawing.Point(9, 190);
            this.btntt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btntt.Name = "btntt";
            this.btntt.Size = new System.Drawing.Size(156, 28);
            this.btntt.TabIndex = 7;
            this.btntt.Text = "Timetable Management";
            this.btntt.UseVisualStyleBackColor = true;
            this.btntt.Click += new System.EventHandler(this.btntt_Click);
            // 
            // btnroom
            // 
            this.btnroom.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnroom.Location = new System.Drawing.Point(9, 158);
            this.btnroom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnroom.Name = "btnroom";
            this.btnroom.Size = new System.Drawing.Size(156, 28);
            this.btnroom.TabIndex = 6;
            this.btnroom.Text = "Room Management";
            this.btnroom.UseVisualStyleBackColor = true;
            this.btnroom.Click += new System.EventHandler(this.btnroom_Click);
            // 
            // btnexma
            // 
            this.btnexma.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexma.Location = new System.Drawing.Point(9, 223);
            this.btnexma.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnexma.Name = "btnexma";
            this.btnexma.Size = new System.Drawing.Size(156, 28);
            this.btnexma.TabIndex = 5;
            this.btnexma.Text = "Exam/Marks Management";
            this.btnexma.UseVisualStyleBackColor = true;
            this.btnexma.Click += new System.EventHandler(this.btnexma_Click);
            // 
            // btnCourse
            // 
            this.btnCourse.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourse.Location = new System.Drawing.Point(9, 58);
            this.btnCourse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCourse.Name = "btnCourse";
            this.btnCourse.Size = new System.Drawing.Size(156, 28);
            this.btnCourse.TabIndex = 4;
            this.btnCourse.Text = "Course Management";
            this.btnCourse.UseVisualStyleBackColor = true;
            this.btnCourse.Click += new System.EventHandler(this.btnCourse_Click);
            // 
            // btnlecturer
            // 
            this.btnlecturer.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlecturer.Location = new System.Drawing.Point(9, 256);
            this.btnlecturer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnlecturer.Name = "btnlecturer";
            this.btnlecturer.Size = new System.Drawing.Size(156, 28);
            this.btnlecturer.TabIndex = 3;
            this.btnlecturer.Text = "Lecturer Management";
            this.btnlecturer.UseVisualStyleBackColor = true;
            this.btnlecturer.Click += new System.EventHandler(this.btnlecturer_Click);
            // 
            // btnSubject
            // 
            this.btnSubject.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubject.Location = new System.Drawing.Point(9, 91);
            this.btnSubject.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSubject.Name = "btnSubject";
            this.btnSubject.Size = new System.Drawing.Size(156, 28);
            this.btnSubject.TabIndex = 2;
            this.btnSubject.Text = "Subject Management";
            this.btnSubject.UseVisualStyleBackColor = true;
            this.btnSubject.Click += new System.EventHandler(this.btnSubject_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudent.Location = new System.Drawing.Point(9, 124);
            this.btnStudent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(156, 28);
            this.btnStudent.TabIndex = 1;
            this.btnStudent.Text = "Student Management";
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click_1);
            // 
            // lblwelcom
            // 
            this.lblwelcom.AutoSize = true;
            this.lblwelcom.Font = new System.Drawing.Font("Cambria", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblwelcom.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblwelcom.Location = new System.Drawing.Point(2, 7);
            this.lblwelcom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblwelcom.Name = "lblwelcom";
            this.lblwelcom.Size = new System.Drawing.Size(203, 14);
            this.lblwelcom.TabIndex = 0;
            this.lblwelcom.Text = "UNICOMTIC MANAGEMENT SYSTEM";
            this.lblwelcom.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(216, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 481);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // btnAttend
            // 
            this.btnAttend.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttend.Location = new System.Drawing.Point(9, 289);
            this.btnAttend.Name = "btnAttend";
            this.btnAttend.Size = new System.Drawing.Size(156, 27);
            this.btnAttend.TabIndex = 0;
            this.btnAttend.Text = "Attendance Management";
            this.btnAttend.UseVisualStyleBackColor = true;
            this.btnAttend.Click += new System.EventHandler(this.btnAttend_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 481);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel1sidebar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1sidebar.ResumeLayout(false);
            this.panel1sidebar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1sidebar;
        private System.Windows.Forms.Label lblwelcom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnexma;
        private System.Windows.Forms.Button btnCourse;
        private System.Windows.Forms.Button btnlecturer;
        private System.Windows.Forms.Button btnSubject;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button btntt;
        private System.Windows.Forms.Button btnroom;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnAttend;
    }
}