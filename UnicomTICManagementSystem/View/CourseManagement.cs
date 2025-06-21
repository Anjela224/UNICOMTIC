using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem.Controller;
using UnicomTICManagementSystem.Models;

namespace UnicomTICManagementSystem.View
{
    public partial class CourseManagement : Form
    {
        private CourseController courseController = new CourseController();
        private int selectedCourseId = -1;

        public CourseManagement()
        {
            InitializeComponent();
            LoadCourses();
        }
        private void LoadCourses()
        {
            dgvCourse.DataSource = null;
            dgvCourse.DataSource = courseController.GetAllCourses();
        }
        private void CourseManagement_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCourseName.Text))
            {
                MessageBox.Show("Enter course name.");
                return;
            }

            Course course = new Course { CourseName = txtCourseName.Text.Trim() };
            courseController.AddCourse(course);
            MessageBox.Show("Course added successfully.");
            txtCourseName.Clear();
            LoadCourses();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedCourseId == -1)
            {
                MessageBox.Show("Please select a course to update.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtCourseName.Text))
            {
                MessageBox.Show("Enter course name.");
                return;
            }
            Course course = new Course
            {
                CourseID = selectedCourseId,
                CourseName = txtCourseName.Text.Trim()
            };
            courseController.UpdateCourse(course);
            MessageBox.Show("Course updated.");
            txtCourseName.Clear();
            selectedCourseId = -1;
            LoadCourses();


        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (selectedCourseId == -1)
            {
                MessageBox.Show("Select a course to delete.");
                return;
            }
            var confirm = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                courseController.DeleteCourse(selectedCourseId);
                MessageBox.Show("Course deleted.");
                txtCourseName.Clear();
                selectedCourseId = -1;
                LoadCourses();
            }
        }

        private void dgvCourse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCourse.Rows[e.RowIndex];
                selectedCourseId = Convert.ToInt32(row.Cells["CourseID"].Value);
                txtCourseName.Text = row.Cells["CourseName"].Value.ToString();
            }
        }
    }
}