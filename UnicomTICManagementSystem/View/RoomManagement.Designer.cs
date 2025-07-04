﻿namespace UnicomTICManagementSystem.View
{
    partial class RoomManagement
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
            this.lblRname = new System.Windows.Forms.Label();
            this.lblRtype = new System.Windows.Forms.Label();
            this.txtRoomName = new System.Windows.Forms.TextBox();
            this.cmbRoomType = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.grpRoom = new System.Windows.Forms.GroupBox();
            this.dgvRoom = new System.Windows.Forms.DataGridView();
            this.grpRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRname
            // 
            this.lblRname.AutoSize = true;
            this.lblRname.Location = new System.Drawing.Point(22, 28);
            this.lblRname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRname.Name = "lblRname";
            this.lblRname.Size = new System.Drawing.Size(81, 16);
            this.lblRname.TabIndex = 0;
            this.lblRname.Text = "Room Name";
            // 
            // lblRtype
            // 
            this.lblRtype.AutoSize = true;
            this.lblRtype.Location = new System.Drawing.Point(22, 62);
            this.lblRtype.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRtype.Name = "lblRtype";
            this.lblRtype.Size = new System.Drawing.Size(75, 16);
            this.lblRtype.TabIndex = 1;
            this.lblRtype.Text = "Room Type";
            // 
            // txtRoomName
            // 
            this.txtRoomName.Location = new System.Drawing.Point(105, 28);
            this.txtRoomName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.Size = new System.Drawing.Size(144, 23);
            this.txtRoomName.TabIndex = 2;
            // 
            // cmbRoomType
            // 
            this.cmbRoomType.FormattingEnabled = true;
            this.cmbRoomType.Location = new System.Drawing.Point(105, 59);
            this.cmbRoomType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbRoomType.Name = "cmbRoomType";
            this.cmbRoomType.Size = new System.Drawing.Size(164, 24);
            this.cmbRoomType.TabIndex = 3;
            this.cmbRoomType.SelectedIndexChanged += new System.EventHandler(this.cmbRoomType_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(35, 146);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(76, 34);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(192, 146);
            this.btnDel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(76, 34);
            this.btnDel.TabIndex = 5;
            this.btnDel.Text = "DELETE";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // grpRoom
            // 
            this.grpRoom.Controls.Add(this.lblRtype);
            this.grpRoom.Controls.Add(this.lblRname);
            this.grpRoom.Controls.Add(this.btnDel);
            this.grpRoom.Controls.Add(this.txtRoomName);
            this.grpRoom.Controls.Add(this.btnAdd);
            this.grpRoom.Controls.Add(this.cmbRoomType);
            this.grpRoom.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRoom.Location = new System.Drawing.Point(40, 10);
            this.grpRoom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpRoom.Name = "grpRoom";
            this.grpRoom.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpRoom.Size = new System.Drawing.Size(344, 199);
            this.grpRoom.TabIndex = 6;
            this.grpRoom.TabStop = false;
            this.grpRoom.Text = "Add Room";
            // 
            // dgvRoom
            // 
            this.dgvRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoom.Location = new System.Drawing.Point(40, 223);
            this.dgvRoom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvRoom.Name = "dgvRoom";
            this.dgvRoom.RowHeadersWidth = 51;
            this.dgvRoom.RowTemplate.Height = 24;
            this.dgvRoom.Size = new System.Drawing.Size(337, 128);
            this.dgvRoom.TabIndex = 7;
            this.dgvRoom.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoom_CellContentClick);
            // 
            // RoomManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.dgvRoom);
            this.Controls.Add(this.grpRoom);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RoomManagement";
            this.Text = "RoomManagement";
            this.Load += new System.EventHandler(this.RoomManagement_Load);
            this.grpRoom.ResumeLayout(false);
            this.grpRoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblRname;
        private System.Windows.Forms.Label lblRtype;
        private System.Windows.Forms.TextBox txtRoomName;
        private System.Windows.Forms.ComboBox cmbRoomType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.GroupBox grpRoom;
        private System.Windows.Forms.DataGridView dgvRoom;
    }
}