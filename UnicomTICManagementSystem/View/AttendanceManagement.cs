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
    public partial class AttendanceManagement : Form
    {
        private StudentController studentController = new StudentController();
        private SubjectController subjectController = new SubjectController();
        private AttendanceController attendanceController = new AttendanceController();

        private void LoadSubjects()
        {
            var subjects = subjectController.GetAllSubjects();
            cmbSubject.DataSource = subjects;
            cmbSubject.DisplayMember = "SubjectName";
            cmbSubject.ValueMember = "SubjectID";
        }
        private void LoadStudentsWithStatusColumn()
        {
            var students = studentController.GetAllStudents();
            dgvStudent.DataSource = students;

            if (dgvStudent.Columns.Contains("Status"))
                dgvStudent.Columns.Remove("Status");

            DataGridViewComboBoxColumn statusCol = new DataGridViewComboBoxColumn();
            statusCol.HeaderText = "Status";
            statusCol.Name = "Status";
            statusCol.Items.AddRange("Present", "Absent", "Late", "Excused");
            dgvStudent.Columns.Add(statusCol);
        }


        public AttendanceManagement()
        {
            InitializeComponent();
        }

        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            


        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

        }

        private void AttendanceManagement_Load(object sender, EventArgs e)
        {
            LoadSubjects();
            LoadStudentsWithStatusColumn();
        }

        private void cmbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            


        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            dtpDate.Value = DateTime.Today;

        }

        private void btnmark_Click(object sender, EventArgs e)
        {
            if (cmbSubject.SelectedValue == null)
            {
                MessageBox.Show("Please select a subject.");
                return;
            }

            int subjectId = Convert.ToInt32(cmbSubject.SelectedValue);
            string date = dtpDate.Value.ToString("yyyy-MM-dd");

            foreach (DataGridViewRow row in dgvStudent.Rows)
            {
                if (row.IsNewRow) continue;

                int studentId = Convert.ToInt32(row.Cells["StudentID"].Value);
                var status = row.Cells["Status"].Value?.ToString();

                if (string.IsNullOrEmpty(status)) continue;

                
                var existing = attendanceController.GetAttendance(subjectId, studentId, date);
                if (existing != null)
                {
                    MessageBox.Show($"Attendance already marked for student ID: {studentId}");
                    continue;
                }

                var attendance = new Attendance
                {
                    StudentID = studentId,
                    SubjectID = subjectId,
                    Date = date,
                    Status = status
                };

                attendanceController.AddAttendance(attendance);
            }

            MessageBox.Show("Attendance marked successfully!");

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

           
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvStudent.SelectedRows)
            {
                int studentId = Convert.ToInt32(row.Cells["StudentID"].Value);
                int subjectId = Convert.ToInt32(cmbSubject.SelectedValue);
                string date = dtpDate.Value.ToString("yyyy-MM-dd");

                var existing = attendanceController.GetAttendance(subjectId, studentId, date);
                if (existing != null)
                {
                    attendanceController.DeleteAttendance(existing.AttendanceID);
                }
            }

            MessageBox.Show("Selected attendance deleted.");
        }

        private void btnupdate_Click_1(object sender, EventArgs e)
        {
            int subjectId = Convert.ToInt32(cmbSubject.SelectedValue);
            string date = dtpDate.Value.ToString("yyyy-MM-dd");

            foreach (DataGridViewRow row in dgvStudent.Rows)
            {
                if (row.IsNewRow) continue;

                int studentId = Convert.ToInt32(row.Cells["StudentID"].Value);
                string status = row.Cells["Status"].Value?.ToString();

                var existing = attendanceController.GetAttendance(subjectId, studentId, date);
                if (existing != null)
                {
                    existing.Status = status;
                    attendanceController.UpdateAttendance(existing);
                }
            }

            MessageBox.Show("Attendance updated!");
        }
    }
    }
    
    

