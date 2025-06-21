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
    public partial class RoomManagement : Form
    {
        RoomController roomController = new RoomController();  
        public RoomManagement()
        {
            InitializeComponent();
            cmbRoomType.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbRoomType.Items.AddRange(new string[] { "Lab", "Hall" });
            LoadRoom();
        }
        private void LoadRoom()
        {
            dgvRoom.DataSource = null;
            dgvRoom.DataSource = roomController.GetAllRooms(); 
            dgvRoom.ClearSelection();
        }



        private void RoomManagement_Load(object sender, EventArgs e)
        {
            dgvRoom.DataSource = null;
            dgvRoom.DataSource = roomController.GetAllRooms();
            dgvRoom.ClearSelection();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Room room = new Room
         {
                RoomName = txtRoomName.Text.Trim(),
                RoomType = cmbRoomType.SelectedItem?.ToString()
            };

            if (string.IsNullOrEmpty(room.RoomName) || string.IsNullOrEmpty(room.RoomType))
            {
                MessageBox.Show("Please enter room name and type.");
                return;
            }
            roomController.AddRoom(room);
            LoadRoom();
            ClearForm();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgvRoom.SelectedRows.Count == 0) return;

            int roomId = (int)dgvRoom.SelectedRows[0].Cells["RoomID"].Value;
            roomController.DeleteRoom(roomId);
            LoadRoom();
            ClearForm();
        }

        private void dgvRoom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRoom.SelectedRows.Count == 0) return;

            txtRoomName.Text = dgvRoom.SelectedRows[0].Cells["RoomName"].Value.ToString();
            cmbRoomType.SelectedItem = dgvRoom.SelectedRows[0].Cells["RoomType"].Value.ToString();
        }
        private void ClearForm()
        {
            txtRoomName.Clear();
            cmbRoomType.SelectedIndex = -1;
            dgvRoom.ClearSelection();
        }

        private void cmbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}    