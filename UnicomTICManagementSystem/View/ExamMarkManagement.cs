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
    public partial class ExamMarkManagement : Form
    {
        private bool isFormLoaded = false;
        private int selectedMarkId = -1;
        private SubjectController subjectController = new SubjectController();
        private StudentController studentController = new StudentController();
        private ExamController examController = new ExamController();
        private MarkController markController = new MarkController();

        public ExamMarkManagement()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSubject.SelectedValue != null && int.TryParse(cmbSubject.SelectedValue.ToString(), out int subjectId))
            {
                LoadExams(subjectId);
            }
        }


        private void cmbStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isFormLoaded) return;
            if (cmbStudent.SelectedValue != null && int.TryParse(cmbStudent.SelectedValue.ToString(), out int studentId))
            {
                LoadMarksForStudent(studentId);
            }
        }



        private void numMarks_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblMarks_Click(object sender, EventArgs e)
        {

        }

        private void ExamMarkManagement_Load(object sender, EventArgs e)
        {
            LoadSubjects();
            LoadStudents();
            if (cmbSubject.Items.Count > 0)
                cmbSubject.SelectedIndex = 0;
            if (int.TryParse(cmbSubject.SelectedValue?.ToString(), out int subjectId))
            {
                LoadExams(subjectId);
            }

            if (cmbStudent.Items.Count > 0)
                cmbStudent.SelectedIndex = 0;

            isFormLoaded = true;
        }



        private void LoadSubjects()
        {
            var subjects = subjectController.GetAllSubjects();
            cmbSubject.DataSource = subjects;
            cmbSubject.DisplayMember = "SubjectName";
            cmbSubject.ValueMember = "SubjectID";
        }

        private void LoadStudents()
        {
            var students = studentController.GetAllStudents();
            cmbStudent.DataSource = students;
            cmbStudent.DisplayMember = "Name";
            cmbStudent.ValueMember = "StudentID";
            cmbStudent.SelectedIndex = -1;
        }
        private void LoadExams(int subjectId)
        {
            var exams = examController.GetExamsBySubject(subjectId);
            combexam.DataSource = exams;
            combexam.DisplayMember = "ExamName";
            combexam.ValueMember = "ExamID";
            combexam.SelectedIndex = -1;
        }

        private void LoadMarksForStudent(int studentId)
        {
            var marks = markController.GetMarksByStudent(studentId);
            dgvMarks.DataSource = marks;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(cmbStudent.SelectedValue?.ToString(), out int studentId) ||
                    !int.TryParse(combexam.SelectedValue?.ToString(), out int examId))
                {
                    MessageBox.Show("Please select both Student and Exam.");
                    return;
                }

                int score = (int)numMarks.Value;

                var mark = new Mark()
                {
                    StudentID = studentId,
                    ExamID = examId,
                    Score = score
                };

                markController.AddMark(mark);

                MessageBox.Show("Mark added successfully!");
                LoadMarksForStudent(studentId);
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void btnAddMarks_Click(object sender, EventArgs e)
        {

        }

        private void cmbExam_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void cmbExam_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void dgvExam_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvMarks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvMarks.Rows[e.RowIndex];
            selectedMarkId = Convert.ToInt32(row.Cells["MarkID"].Value);
            cmbStudent.SelectedValue = (int)row.Cells["StudentID"].Value;
            combexam.SelectedValue = (int)row.Cells["ExamID"].Value;
            numMarks.Value = Convert.ToDecimal(row.Cells["Score"].Value);
        }


        private void btnAddMarks_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (cmbStudent.SelectedValue == null || combexam.SelectedValue == null)
                {
                    MessageBox.Show("Please select both Student and Exam.");
                    return;
                }

                int studentId = Convert.ToInt32(cmbStudent.SelectedValue);
                int examId = Convert.ToInt32(combexam.SelectedValue);
                int score = (int)numMarks.Value;

                var mark = new Mark()
                {
                    StudentID = studentId,
                    ExamID = examId,
                    Score = score
                };

                markController.AddMark(mark);

                MessageBox.Show("Mark added successfully!");
                LoadMarksForStudent(studentId);
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ClearInputs()
        {
            numMarks.Value = 0;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedMarkId == -1)
            {
                MessageBox.Show("Please select a mark to update!");
                return;
            }
            try
            {
                int studentId = (int)cmbStudent.SelectedValue;
                int examId = (int)combexam.SelectedValue;
                int score = (int)numMarks.Value;

                var mark = new Mark()
                {
                    MarkID = selectedMarkId,
                    StudentID = studentId,
                    ExamID = examId,
                    Score = score
                };

                markController.UpdateMark(mark);

                MessageBox.Show("Mark updated successfully!");
                LoadMarksForStudent(studentId);
                ClearInputs();
                selectedMarkId = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void combexam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isFormLoaded) return;
            if (combexam.SelectedValue != null && int.TryParse(combexam.SelectedValue.ToString(), out int examId))
            {


            }
        }
    }
}

