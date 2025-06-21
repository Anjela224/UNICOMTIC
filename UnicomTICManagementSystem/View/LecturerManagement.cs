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
    public partial class LecturerManagement : Form
    {
        private LecturerController lecturerController;

        public LecturerManagement()
        {
            InitializeComponent();
            lecturerController = new LecturerController();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblUname_Click(object sender, EventArgs e)
        {

        }

        private void LecturerManagement_Load(object sender, EventArgs e)
        {
            LoadLecturers();
        }
        private void LoadLecturers()
        {
            var lecturers = lecturerController.GetAllLecturers();
            dgvLecturer.DataSource = null;
            dgvLecturer.DataSource = lecturers;

            // Optionally hide password column
            if (dgvLecturer.Columns["Password"] != null)
                dgvLecturer.Columns["Password"].Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var lecturer = new Lecturer
            {
                Name = txtLname.Text,
                Username = txtUname.Text,
                Password = txtPword.Text
            };

            lecturerController.AddLecturer(lecturer);
            LoadLecturers();
            ClearInputs();
            MessageBox.Show("Lecturer added successfully!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvLecturer.CurrentRow == null)
            {
                MessageBox.Show("Please select a lecturer from the list.");
                return;
            }

            int id = Convert.ToInt32(dgvLecturer.CurrentRow.Cells["LecturerID"].Value);

            var lecturer = new Lecturer
            {
                LecturerID = id,
                Name = txtLname.Text,
                Username = txtUname.Text,
                Password = txtPword.Text
            };

            lecturerController.UpdateLecturer(lecturer);
            LoadLecturers();
            ClearInputs();
            MessageBox.Show("Lecturer updated successfully!");
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgvLecturer.CurrentRow == null)
            {
                MessageBox.Show("Please select a lecturer from the list.");
                return;
            }

            int id = Convert.ToInt32(dgvLecturer.CurrentRow.Cells["LecturerID"].Value);
            var confirmResult = MessageBox.Show("Are you sure to delete this lecturer?", "Confirm Delete", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                lecturerController.DeleteLecturer(id);
                LoadLecturers();
                ClearInputs();
                MessageBox.Show("Lecturer deleted successfully!");
            }
        }

        private void dgvLecturer_CellContentClick(object sender, DataGridViewCellEventArgs e)

        {
            if (dgvLecturer.CurrentRow != null)
            {
                txtLname.Text = dgvLecturer.CurrentRow.Cells["Name"].Value.ToString();
                txtUname.Text = dgvLecturer.CurrentRow.Cells["Username"].Value.ToString();
                txtPword.Text = dgvLecturer.CurrentRow.Cells["Password"].Value.ToString();
            }
        }
        private void ClearInputs()
        {
            txtLname.Text = "";
            txtUname.Text = "";
            txtPword.Text = "";
        }

        private void txtLname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    
    

