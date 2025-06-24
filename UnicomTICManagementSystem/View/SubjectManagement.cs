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
    public partial class SubjectManagement : Form
    {
        SubjectController subjectController = new SubjectController();
        CourseController courseController = new CourseController();

        public SubjectManagement()
        {
            InitializeComponent();
            LoadSubject();
            LoadCourse();
        }

        private void SubjectManagement_Load(object sender, EventArgs e)
        {
            dgvSubjects.DataSource = null;
            dgvSubjects.DataSource = subjectController.GetAllSubjects();
        }
        private void LoadSubject()
        {
            dgvSubjects.DataSource = null;
            dgvSubjects.DataSource = subjectController.GetAllSubjects();
        }

        private void LoadCourse()
        {
            var courses = courseController.GetAllCourses();
            cmbCourse.DataSource = courses;
            cmbCourse.DisplayMember = "CourseName";
            cmbCourse.ValueMember = "CourseID";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSubjectName.Text) || cmbCourse.SelectedIndex == -1)
            {
                MessageBox.Show("Please enter subject name and select a course.");
                return;
            }

            var subject = new Subject()
            {
                SubjectName = txtSubjectName.Text.Trim(),
                CourseID = (int)cmbCourse.SelectedValue

            };

            subjectController.AddSubject(subject);
            MessageBox.Show("Subject added successfully.");

            LoadSubject();
            ClearForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvSubjects.CurrentRow == null)
            {
                MessageBox.Show("Please select a subject to update.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSubjectName.Text) || cmbCourse.SelectedIndex == -1)
            {
                MessageBox.Show("Please enter subject name and select a course.");
                return;
            }

            int subjectId = Convert.ToInt32(dgvSubjects.CurrentRow.Cells["SubjectID"].Value);

            var subject = new Subject()
            {
                SubjectID = subjectId,
                SubjectName = txtSubjectName.Text.Trim(),
                CourseID = (int)cmbCourse.SelectedValue
            };

            subjectController.UpdateSubject(subject);
            MessageBox.Show("Subject updated successfully.");

            LoadSubject();
            ClearForm();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgvSubjects.CurrentRow == null)
            {
                MessageBox.Show("Please select a subject to delete.");
                return;
            }

            int subjectId = Convert.ToInt32(dgvSubjects.CurrentRow.Cells["SubjectID"].Value);

            var confirmResult = MessageBox.Show("Are you sure to delete this subject?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                subjectController.DeleteSubject(subjectId);
                MessageBox.Show("Subject deleted successfully.");

                LoadSubject();
                ClearForm();
            }
        }

        private void dgvSubjects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0) // Ignore header row
            {
                var row = dgvSubjects.Rows[e.RowIndex];
                txtSubjectName.Text = row.Cells["SubjectName"].Value.ToString();
                cmbCourse.SelectedValue = Convert.ToInt32(row.Cells["CourseID"].Value);
            }
        }
        private void ClearForm()
        {
            txtSubjectName.Clear(); // Clears the textbox
            cmbCourse.SelectedIndex = -1; // Clears selection
            dgvSubjects.ClearSelection(); // Clears selection in DataGridView
        }
    }
 }


    

    

