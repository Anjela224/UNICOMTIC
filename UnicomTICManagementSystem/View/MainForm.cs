﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnicomTICManagementSystem.View
{
    public partial class MainForm : Form
    {
        private string username;
        private string role;
        public MainForm(string username, string role)
        {
            InitializeComponent();
            this.username = username;
            this.role = role;
            SetupRoleBasedUI();

        }
        private void SetupRoleBasedUI()
        {
            
            if (role == "Admin")
            {
                
            }
            else if (role == "Staff")
            {
                btnStudent.Visible = false;
                btnCourse.Visible = false;
                btnSubject.Visible = false;
                btnlecturer.Visible = false;
                btnroom.Visible = false;
                btnAttend.Visible = false;
            }
            else if (role == "Lecturer")
            {
                btnStudent.Visible = false;
                btnCourse.Visible = false;
                btnSubject.Visible = false;
                btnlecturer.Visible = false;
                btnroom.Visible = false;
                btnexma.Visible = true;
                btntt.Visible = true;
                btnAttend.Visible = true;   
            }
            else if (role == "Student")
            {
                btnStudent.Visible = true; 
                btnCourse.Visible = false;
                btnSubject.Visible = false;
                btnlecturer.Visible = false;
                btnroom.Visible = false;
                btnexma.Visible = false;  
                btntt.Visible = true; 
                btnAttend.Visible = true;
                btnAttend.Text = "View Attendance";
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        { }




        private void LoadFormInPanel(Form form)
        {
            panel1.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
            form.Show();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new StudentManagement());
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnStudent_Click_1(object sender, EventArgs e)
        {
            LoadFormInPanel(new StudentManagement());
        }

        private void btnSubject_Click(object sender, EventArgs e)

        {
            LoadFormInPanel(new SubjectManagement());
        }

        private void btnlecturer_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new LecturerManagement());
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new CourseManagement());

        }

        private void btnexma_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new ExamMarkManagement());
        }

        private void btnroom_Click(object sender, EventArgs e)

        {
            LoadFormInPanel(new RoomManagement());
        }

        private void btntt_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new TimetableManagement());
        }

        private void btnlogout_Click(object sender, EventArgs e)

        {
            var result = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide(); // hide current
                LoginForm login = new LoginForm();
                login.ShowDialog(); // wait for login
                this.Close(); // now close current form
            }
        }

        private void btnAttend_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new AttendanceManagement());
        }
    }
}
    


