using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using UnicomTICManagementSystem.Controller;
using UnicomTICManagementSystem.Models;

namespace UnicomTICManagementSystem.View
{
    public partial class StudentManagement : Form
    {
        private StudentController studentController;
        private List<Course> courses;
        public StudentManagement()
        {
            InitializeComponent();
            studentController = new StudentController();
        
        }

        private void lbl_Click(object sender, EventArgs e)
        {

        }

        private void StudentManagement_Load(object sender, EventArgs e)
        {
            LoadCourses();    
            LoadStudents();  
        }

        private void LoadCourses()
        {
            var courseController = new CourseController();
            courses = courseController.GetAllCourses();

            cmbCourse.DataSource = courses;
            cmbCourse.DisplayMember = "CourseName";  
            cmbCourse.ValueMember = "CourseID";     
        }

        private void LoadStudents()
        {
            var students = studentController.GetAllStudents();
            dgvStudents.DataSource = students;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var student = new Student
            {
                Name = txtStudent.Text.Trim(),
                CourseID = (int)cmbCourse.SelectedValue
            };

            studentController.AddStudent(student);
            LoadStudents();
            ClearInputs();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow == null) return;

            int studentId = (int)dgvStudents.CurrentRow.Cells["StudentID"].Value;

            var student = new Student
            {
                StudentID = studentId,
                Name = txtStudent.Text.Trim(),
                CourseID = (int)cmbCourse.SelectedValue
            };

            studentController.UpdateStudent(student);
            LoadStudents();
            ClearInputs();
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow == null) return;

            int studentId = (int)dgvStudents.CurrentRow.Cells["StudentID"].Value;

            studentController.DeleteStudent(studentId);
            LoadStudents();
            ClearInputs();
        }

        private void dgvStudents_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow == null) return;

            txtStudent.Text = dgvStudents.CurrentRow.Cells["Name"].Value.ToString();
            cmbCourse.SelectedValue = (int)dgvStudents.CurrentRow.Cells["CourseID"].Value;
        }
        private void ClearInputs()
        {
            txtStudent.Text = "";
            if (cmbCourse.Items.Count > 0)
                cmbCourse.SelectedIndex = 0;
        }
    }
}
    
    
    
    

