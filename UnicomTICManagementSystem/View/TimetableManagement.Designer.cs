namespace UnicomTICManagementSystem.View
{
    partial class TimetableManagement
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
            this.grpAddTT = new System.Windows.Forms.GroupBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.lblRoom = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.cmbRoom = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cmbSub = new System.Windows.Forms.ComboBox();
            this.cmbTime = new System.Windows.Forms.ComboBox();
            this.grpTTList = new System.Windows.Forms.GroupBox();
            this.dgvTimetables = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbldate = new System.Windows.Forms.Label();
            this.datetimepick = new System.Windows.Forms.DateTimePicker();
            this.grpAddTT.SuspendLayout();
            this.grpTTList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimetables)).BeginInit();
            this.SuspendLayout();
            // 
            // grpAddTT
            // 
            this.grpAddTT.Controls.Add(this.datetimepick);
            this.grpAddTT.Controls.Add(this.lbldate);
            this.grpAddTT.Controls.Add(this.btnDel);
            this.grpAddTT.Controls.Add(this.lblRoom);
            this.grpAddTT.Controls.Add(this.lblTime);
            this.grpAddTT.Controls.Add(this.lblSub);
            this.grpAddTT.Controls.Add(this.cmbRoom);
            this.grpAddTT.Controls.Add(this.btnAdd);
            this.grpAddTT.Controls.Add(this.btnUpdate);
            this.grpAddTT.Controls.Add(this.cmbSub);
            this.grpAddTT.Controls.Add(this.cmbTime);
            this.grpAddTT.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAddTT.Location = new System.Drawing.Point(88, 11);
            this.grpAddTT.Margin = new System.Windows.Forms.Padding(2);
            this.grpAddTT.Name = "grpAddTT";
            this.grpAddTT.Padding = new System.Windows.Forms.Padding(2);
            this.grpAddTT.Size = new System.Drawing.Size(400, 200);
            this.grpAddTT.TabIndex = 0;
            this.grpAddTT.TabStop = false;
            this.grpAddTT.Text = "Add Timetable";
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(202, 155);
            this.btnDel.Margin = new System.Windows.Forms.Padding(2);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(78, 28);
            this.btnDel.TabIndex = 9;
            this.btnDel.Text = "DELETE";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Location = new System.Drawing.Point(31, 119);
            this.lblRoom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(42, 16);
            this.lblRoom.TabIndex = 8;
            this.lblRoom.Text = "Room";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(32, 91);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(38, 16);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "Time";
            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.Location = new System.Drawing.Point(31, 32);
            this.lblSub.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(52, 16);
            this.lblSub.TabIndex = 6;
            this.lblSub.Text = "Subject";
            // 
            // cmbRoom
            // 
            this.cmbRoom.FormattingEnabled = true;
            this.cmbRoom.Location = new System.Drawing.Point(200, 111);
            this.cmbRoom.Margin = new System.Windows.Forms.Padding(2);
            this.cmbRoom.Name = "cmbRoom";
            this.cmbRoom.Size = new System.Drawing.Size(80, 24);
            this.cmbRoom.TabIndex = 2;
            this.cmbRoom.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(34, 155);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(63, 29);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(126, 155);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(67, 29);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbSub
            // 
            this.cmbSub.FormattingEnabled = true;
            this.cmbSub.Location = new System.Drawing.Point(200, 32);
            this.cmbSub.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSub.Name = "cmbSub";
            this.cmbSub.Size = new System.Drawing.Size(80, 24);
            this.cmbSub.TabIndex = 0;
            this.cmbSub.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmbTime
            // 
            this.cmbTime.FormattingEnabled = true;
            this.cmbTime.Location = new System.Drawing.Point(200, 83);
            this.cmbTime.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTime.Name = "cmbTime";
            this.cmbTime.Size = new System.Drawing.Size(80, 24);
            this.cmbTime.TabIndex = 1;
            this.cmbTime.SelectedIndexChanged += new System.EventHandler(this.cmbTime_SelectedIndexChanged);
            // 
            // grpTTList
            // 
            this.grpTTList.Controls.Add(this.dgvTimetables);
            this.grpTTList.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTTList.Location = new System.Drawing.Point(79, 215);
            this.grpTTList.Margin = new System.Windows.Forms.Padding(2);
            this.grpTTList.Name = "grpTTList";
            this.grpTTList.Padding = new System.Windows.Forms.Padding(2);
            this.grpTTList.Size = new System.Drawing.Size(409, 196);
            this.grpTTList.TabIndex = 1;
            this.grpTTList.TabStop = false;
            this.grpTTList.Text = "Timetable List";
            // 
            // dgvTimetables
            // 
            this.dgvTimetables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimetables.Location = new System.Drawing.Point(43, 30);
            this.dgvTimetables.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTimetables.Name = "dgvTimetables";
            this.dgvTimetables.RowHeadersWidth = 51;
            this.dgvTimetables.RowTemplate.Height = 24;
            this.dgvTimetables.Size = new System.Drawing.Size(260, 147);
            this.dgvTimetables.TabIndex = 0;
            this.dgvTimetables.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTimetables_CellContentClick);
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Location = new System.Drawing.Point(32, 63);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(35, 16);
            this.lbldate.TabIndex = 2;
            this.lbldate.Text = "Date";
            // 
            // datetimepick
            // 
            this.datetimepick.Location = new System.Drawing.Point(200, 58);
            this.datetimepick.Name = "datetimepick";
            this.datetimepick.Size = new System.Drawing.Size(195, 23);
            this.datetimepick.TabIndex = 2;
            this.datetimepick.ValueChanged += new System.EventHandler(this.datetimepick_ValueChanged);
            // 
            // TimetableManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(686, 422);
            this.Controls.Add(this.grpTTList);
            this.Controls.Add(this.grpAddTT);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TimetableManagement";
            this.Text = "TimetableManagement";
            this.Load += new System.EventHandler(this.TimetableManagement_Load);
            this.grpAddTT.ResumeLayout(false);
            this.grpAddTT.PerformLayout();
            this.grpTTList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimetables)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAddTT;
        private System.Windows.Forms.GroupBox grpTTList;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cmbSub;
        private System.Windows.Forms.ComboBox cmbTime;
        private System.Windows.Forms.ComboBox cmbRoom;
        private System.Windows.Forms.DataGridView dgvTimetables;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.DateTimePicker datetimepick;
        private System.Windows.Forms.Label lbldate;
    }
}