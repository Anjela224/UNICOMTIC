namespace UnicomTICManagementSystem.View
{
    partial class ExamMarkManagement
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblstu = new System.Windows.Forms.Label();
            this.dgvExam = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbSubject = new System.Windows.Forms.ComboBox();
            this.txtstudentName = new System.Windows.Forms.TextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblEx = new System.Windows.Forms.Label();
            this.grpAddMarks = new System.Windows.Forms.GroupBox();
            this.lblExam = new System.Windows.Forms.Label();
            this.dgvMarks = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddMarks = new System.Windows.Forms.Button();
            this.numMarks = new System.Windows.Forms.NumericUpDown();
            this.cmbStudent = new System.Windows.Forms.ComboBox();
            this.lblStudent = new System.Windows.Forms.Label();
            this.lblMarks = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.combexam = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExam)).BeginInit();
            this.grpAddMarks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMarks)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.lblstu);
            this.groupBox1.Controls.Add(this.dgvExam);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.cmbSubject);
            this.groupBox1.Controls.Add(this.txtstudentName);
            this.groupBox1.Controls.Add(this.lblSubject);
            this.groupBox1.Controls.Add(this.lblEx);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(366, 250);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Exam Management";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(134, 59);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(68, 23);
            this.textBox1.TabIndex = 7;
            // 
            // lblstu
            // 
            this.lblstu.AutoSize = true;
            this.lblstu.Location = new System.Drawing.Point(34, 32);
            this.lblstu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblstu.Name = "lblstu";
            this.lblstu.Size = new System.Drawing.Size(94, 16);
            this.lblstu.TabIndex = 6;
            this.lblstu.Text = "Student Name";
            // 
            // dgvExam
            // 
            this.dgvExam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExam.Location = new System.Drawing.Point(37, 136);
            this.dgvExam.Margin = new System.Windows.Forms.Padding(2);
            this.dgvExam.Name = "dgvExam";
            this.dgvExam.RowHeadersWidth = 51;
            this.dgvExam.RowTemplate.Height = 24;
            this.dgvExam.Size = new System.Drawing.Size(274, 98);
            this.dgvExam.TabIndex = 5;
            this.dgvExam.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExam_CellContentClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(264, 54);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(46, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbSubject
            // 
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Location = new System.Drawing.Point(118, 86);
            this.cmbSubject.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(85, 24);
            this.cmbSubject.TabIndex = 3;
            this.cmbSubject.SelectedIndexChanged += new System.EventHandler(this.cmbSubject_SelectedIndexChanged);
            // 
            // txtstudentName
            // 
            this.txtstudentName.Location = new System.Drawing.Point(134, 30);
            this.txtstudentName.Margin = new System.Windows.Forms.Padding(2);
            this.txtstudentName.Name = "txtstudentName";
            this.txtstudentName.Size = new System.Drawing.Size(68, 23);
            this.txtstudentName.TabIndex = 2;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(40, 93);
            this.lblSubject.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(52, 16);
            this.lblSubject.TabIndex = 1;
            this.lblSubject.Text = "Subject";
            this.lblSubject.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblEx
            // 
            this.lblEx.AutoSize = true;
            this.lblEx.Location = new System.Drawing.Point(34, 62);
            this.lblEx.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEx.Name = "lblEx";
            this.lblEx.Size = new System.Drawing.Size(77, 16);
            this.lblEx.TabIndex = 0;
            this.lblEx.Text = "ExamName";
            // 
            // grpAddMarks
            // 
            this.grpAddMarks.Controls.Add(this.combexam);
            this.grpAddMarks.Controls.Add(this.lblExam);
            this.grpAddMarks.Controls.Add(this.dgvMarks);
            this.grpAddMarks.Controls.Add(this.btnEdit);
            this.grpAddMarks.Controls.Add(this.btnAddMarks);
            this.grpAddMarks.Controls.Add(this.numMarks);
            this.grpAddMarks.Controls.Add(this.cmbStudent);
            this.grpAddMarks.Controls.Add(this.lblStudent);
            this.grpAddMarks.Controls.Add(this.lblMarks);
            this.grpAddMarks.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAddMarks.Location = new System.Drawing.Point(27, 275);
            this.grpAddMarks.Margin = new System.Windows.Forms.Padding(2);
            this.grpAddMarks.Name = "grpAddMarks";
            this.grpAddMarks.Padding = new System.Windows.Forms.Padding(2);
            this.grpAddMarks.Size = new System.Drawing.Size(366, 198);
            this.grpAddMarks.TabIndex = 1;
            this.grpAddMarks.TabStop = false;
            this.grpAddMarks.Text = "Marks Management";
            // 
            // lblExam
            // 
            this.lblExam.AutoSize = true;
            this.lblExam.Location = new System.Drawing.Point(40, 61);
            this.lblExam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExam.Name = "lblExam";
            this.lblExam.Size = new System.Drawing.Size(41, 16);
            this.lblExam.TabIndex = 10;
            this.lblExam.Text = "Exam";
            // 
            // dgvMarks
            // 
            this.dgvMarks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarks.Location = new System.Drawing.Point(43, 115);
            this.dgvMarks.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMarks.Name = "dgvMarks";
            this.dgvMarks.RowHeadersWidth = 51;
            this.dgvMarks.RowTemplate.Height = 24;
            this.dgvMarks.Size = new System.Drawing.Size(274, 96);
            this.dgvMarks.TabIndex = 6;
            this.dgvMarks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMarks_CellContentClick);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(264, 87);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(46, 23);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAddMarks
            // 
            this.btnAddMarks.Location = new System.Drawing.Point(264, 35);
            this.btnAddMarks.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddMarks.Name = "btnAddMarks";
            this.btnAddMarks.Size = new System.Drawing.Size(46, 23);
            this.btnAddMarks.TabIndex = 5;
            this.btnAddMarks.Text = "ADD";
            this.btnAddMarks.UseVisualStyleBackColor = true;
            this.btnAddMarks.Click += new System.EventHandler(this.btnAddMarks_Click_1);
            // 
            // numMarks
            // 
            this.numMarks.Location = new System.Drawing.Point(134, 89);
            this.numMarks.Margin = new System.Windows.Forms.Padding(2);
            this.numMarks.Name = "numMarks";
            this.numMarks.Size = new System.Drawing.Size(90, 23);
            this.numMarks.TabIndex = 7;
            this.numMarks.ValueChanged += new System.EventHandler(this.numMarks_ValueChanged);
            // 
            // cmbStudent
            // 
            this.cmbStudent.FormattingEnabled = true;
            this.cmbStudent.Location = new System.Drawing.Point(134, 32);
            this.cmbStudent.Margin = new System.Windows.Forms.Padding(2);
            this.cmbStudent.Name = "cmbStudent";
            this.cmbStudent.Size = new System.Drawing.Size(85, 24);
            this.cmbStudent.TabIndex = 5;
            this.cmbStudent.SelectedIndexChanged += new System.EventHandler(this.cmbStudent_SelectedIndexChanged);
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Location = new System.Drawing.Point(40, 32);
            this.lblStudent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(55, 16);
            this.lblStudent.TabIndex = 2;
            this.lblStudent.Text = "Student";
            this.lblStudent.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblMarks
            // 
            this.lblMarks.AutoSize = true;
            this.lblMarks.Location = new System.Drawing.Point(47, 94);
            this.lblMarks.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMarks.Name = "lblMarks";
            this.lblMarks.Size = new System.Drawing.Size(44, 16);
            this.lblMarks.TabIndex = 3;
            this.lblMarks.Text = "Marks";
            this.lblMarks.Click += new System.EventHandler(this.lblMarks_Click);
            // 
            // combexam
            // 
            this.combexam.FormattingEnabled = true;
            this.combexam.Location = new System.Drawing.Point(134, 63);
            this.combexam.Name = "combexam";
            this.combexam.Size = new System.Drawing.Size(85, 24);
            this.combexam.TabIndex = 2;
            this.combexam.SelectedIndexChanged += new System.EventHandler(this.combexam_SelectedIndexChanged);
            // 
            // ExamMarkManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(695, 487);
            this.Controls.Add(this.grpAddMarks);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ExamMarkManagement";
            this.Text = "ExamMarkManagement";
            this.Load += new System.EventHandler(this.ExamMarkManagement_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExam)).EndInit();
            this.grpAddMarks.ResumeLayout(false);
            this.grpAddMarks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMarks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMarks;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblEx;
        private System.Windows.Forms.GroupBox grpAddMarks;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbSubject;
        private System.Windows.Forms.TextBox txtstudentName;
        private System.Windows.Forms.Button btnAddMarks;
        private System.Windows.Forms.NumericUpDown numMarks;
        private System.Windows.Forms.ComboBox cmbStudent;
        private System.Windows.Forms.DataGridView dgvExam;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridView dgvMarks;
        private System.Windows.Forms.Label lblExam;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblstu;
        private System.Windows.Forms.ComboBox combexam;
    }
}