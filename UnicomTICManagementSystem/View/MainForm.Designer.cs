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
            this.btnexma = new System.Windows.Forms.Button();
            this.btnCourse = new System.Windows.Forms.Button();
            this.btnlecturer = new System.Windows.Forms.Button();
            this.btnSubject = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.lblwelcom = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnroom = new System.Windows.Forms.Button();
            this.btntt = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.panel1sidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1sidebar
            // 
            this.panel1sidebar.BackColor = System.Drawing.SystemColors.WindowFrame;
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
            this.panel1sidebar.Name = "panel1sidebar";
            this.panel1sidebar.Size = new System.Drawing.Size(261, 450);
            this.panel1sidebar.TabIndex = 0;
            this.panel1sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnexma
            // 
            this.btnexma.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexma.Location = new System.Drawing.Point(12, 274);
            this.btnexma.Name = "btnexma";
            this.btnexma.Size = new System.Drawing.Size(208, 35);
            this.btnexma.TabIndex = 5;
            this.btnexma.Text = "Exam/Marks Management";
            this.btnexma.UseVisualStyleBackColor = true;
            this.btnexma.Click += new System.EventHandler(this.btnexma_Click);
            // 
            // btnCourse
            // 
            this.btnCourse.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCourse.Location = new System.Drawing.Point(12, 71);
            this.btnCourse.Name = "btnCourse";
            this.btnCourse.Size = new System.Drawing.Size(208, 35);
            this.btnCourse.TabIndex = 4;
            this.btnCourse.Text = "Course Management";
            this.btnCourse.UseVisualStyleBackColor = true;
            this.btnCourse.Click += new System.EventHandler(this.btnCourse_Click);
            // 
            // btnlecturer
            // 
            this.btnlecturer.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlecturer.Location = new System.Drawing.Point(12, 315);
            this.btnlecturer.Name = "btnlecturer";
            this.btnlecturer.Size = new System.Drawing.Size(208, 35);
            this.btnlecturer.TabIndex = 3;
            this.btnlecturer.Text = "Lecturer Management";
            this.btnlecturer.UseVisualStyleBackColor = true;
            this.btnlecturer.Click += new System.EventHandler(this.btnlecturer_Click);
            // 
            // btnSubject
            // 
            this.btnSubject.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubject.Location = new System.Drawing.Point(12, 112);
            this.btnSubject.Name = "btnSubject";
            this.btnSubject.Size = new System.Drawing.Size(208, 35);
            this.btnSubject.TabIndex = 2;
            this.btnSubject.Text = "Subject Management";
            this.btnSubject.UseVisualStyleBackColor = true;
            this.btnSubject.Click += new System.EventHandler(this.btnSubject_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudent.Location = new System.Drawing.Point(12, 153);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(208, 35);
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
            this.lblwelcom.Location = new System.Drawing.Point(3, 9);
            this.lblwelcom.Name = "lblwelcom";
            this.lblwelcom.Size = new System.Drawing.Size(256, 17);
            this.lblwelcom.TabIndex = 0;
            this.lblwelcom.Text = "UNICOMTIC MANAGEMENT SYSTEM";
            this.lblwelcom.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(261, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 450);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // btnroom
            // 
            this.btnroom.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnroom.Location = new System.Drawing.Point(12, 194);
            this.btnroom.Name = "btnroom";
            this.btnroom.Size = new System.Drawing.Size(208, 34);
            this.btnroom.TabIndex = 6;
            this.btnroom.Text = "Room Management";
            this.btnroom.UseVisualStyleBackColor = true;
            this.btnroom.Click += new System.EventHandler(this.btnroom_Click);
            // 
            // btntt
            // 
            this.btntt.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntt.Location = new System.Drawing.Point(12, 234);
            this.btntt.Name = "btntt";
            this.btntt.Size = new System.Drawing.Size(208, 34);
            this.btntt.TabIndex = 7;
            this.btntt.Text = "Timetable Management";
            this.btntt.UseVisualStyleBackColor = true;
            this.btntt.Click += new System.EventHandler(this.btntt_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.Location = new System.Drawing.Point(76, 388);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(98, 37);
            this.btnlogout.TabIndex = 8;
            this.btnlogout.Text = "Logout";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel1sidebar);
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
    }
}