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
    public partial class TimetableManagement : Form
    {
        private TimetableController timetableController;
        private SubjectController subjectController;

        public TimetableManagement()
        {
            InitializeComponent();
            timetableController = new TimetableController();
            subjectController = new SubjectController();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvTimetables.CurrentRow == null) return;

            if (cmbSub.SelectedValue == null || cmbRoom.SelectedValue == null || cmbTime.SelectedItem == null)
            {
                MessageBox.Show("Please select valid Subject, Room and TimeSlot.");
                return;
            }

            int timetableId = (int)dgvTimetables.CurrentRow.Cells["TimetableID"].Value;
            var timetable = new Timetable
            {
                TimetableID = timetableId,
                SubjectID = (int)cmbSub.SelectedValue,
                TimeSlot = cmbTime.SelectedItem.ToString(),
                RoomID = (int)cmbRoom.SelectedValue
            };

            timetableController.UpdateTimetable(timetable);
            LoadTimetable();
            ClearInputs();
        }
        

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void TimetableManagement_Load(object sender, EventArgs e)
        {
            LoadSubjects();
            LoadTimeSlots();
            LoadRooms();
            LoadTimetable();
        }
        private void LoadSubjects()
        {
            var subjects = subjectController.GetAllSubjects();
            cmbSub.DataSource = subjects;
            cmbSub.DisplayMember = "SubjectName";
            cmbSub.ValueMember = "SubjectID";
        }

        private void LoadTimeSlots()
        {
            
            cmbTime.Items.Clear();
            cmbTime.Items.AddRange(new string[] { "9:00 AM", "10:00 AM", "11:00 AM", "12:00 PM", "2:00 PM", "3:00 PM" });
            cmbTime.SelectedIndex = 0;
        }

        private void LoadRooms()
        {
            List<Room> rooms = new List<Room>()
        {
        new Room { RoomID = 101, RoomName = "Room 101" },
        new Room { RoomID = 102, RoomName = "Room 102" },
        new Room { RoomID = 103, RoomName = "Room 103" },
        new Room { RoomID = 104, RoomName = "Room 104" }
        };

            cmbRoom.DataSource = rooms;
            cmbRoom.DisplayMember = "RoomName";  
            cmbRoom.ValueMember = "RoomID";
        }
        private void LoadTimetable()
        {
            var timetableList = timetableController.GetAllTimetables();
            dgvTimetables.DataSource = timetableList;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbSub.SelectedValue == null || cmbRoom.SelectedValue == null || cmbTime.SelectedItem == null)
            {
                MessageBox.Show("Please select valid Subject, Room and TimeSlot.");
                return;
            }

            var timetable = new Timetable
            {
                SubjectID = (int)cmbSub.SelectedValue,
                TimeSlot = cmbTime.SelectedItem.ToString(),
                RoomID = (int)cmbRoom.SelectedValue
            };

            timetableController.AddTimetable(timetable);
            LoadTimetable();
            ClearInputs();
        }
        

        private void dgvTimetables_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTimetables.CurrentRow == null) return;

            var subjectVal = dgvTimetables.CurrentRow.Cells["SubjectID"].Value;
            if (subjectVal != null)
                cmbSub.SelectedValue = (int)subjectVal;

            var timeVal = dgvTimetables.CurrentRow.Cells["TimeSlot"].Value;
            if (timeVal != null)
                cmbTime.SelectedItem = timeVal.ToString();

            var roomVal = dgvTimetables.CurrentRow.Cells["RoomID"].Value;
            if (roomVal != null)
                cmbRoom.SelectedValue = (int)roomVal;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgvTimetables.CurrentRow == null) return;

            int timetableId = (int)dgvTimetables.CurrentRow.Cells["TimetableID"].Value;
            timetableController.DeleteTimetable(timetableId);
            LoadTimetable();
            ClearInputs();
        }
        private void ClearInputs()
        {
            if (cmbSub.Items.Count > 0) cmbSub.SelectedIndex = 0;
            if (cmbTime.Items.Count > 0) cmbTime.SelectedIndex = 0;
            if (cmbRoom.Items.Count > 0) cmbRoom.SelectedIndex = 0;
        }



    }
}

    
    

