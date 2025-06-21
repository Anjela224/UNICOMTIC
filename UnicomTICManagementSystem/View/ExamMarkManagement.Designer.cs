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
            this.dgvExam = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbSubject = new System.Windows.Forms.ComboBox();
            this.txtstudentName = new System.Windows.Forms.TextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblEx = new System.Windows.Forms.Label();
            this.grpAddMarks = new System.Windows.Forms.GroupBox();
            this.lblExam = new System.Windows.Forms.Label();
            this.cmbExam = new System.Windows.Forms.ComboBox();
            this.dgvMarks = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddMarks = new System.Windows.Forms.Button();
            this.numMarks = new System.Windows.Forms.NumericUpDown();
            this.cmbStudent = new System.Windows.Forms.ComboBox();
            this.lblStudent = new System.Windows.Forms.Label();
            this.lblMarks = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblstu = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.groupBox1.Location = new System.Drawing.Point(36, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(488, 308);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Exam Management";
            // 
            // dgvExam
            // 
            this.dgvExam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExam.Location = new System.Drawing.Point(49, 167);
            this.dgvExam.Name = "dgvExam";
            this.dgvExam.RowHeadersWidth = 51;
            this.dgvExam.RowTemplate.Height = 24;
            this.dgvExam.Size = new System.Drawing.Size(366, 120);
            this.dgvExam.TabIndex = 5;
            this.dgvExam.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExam_CellContentClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(352, 66);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(62, 28);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbSubject
            // 
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Location = new System.Drawing.Point(157, 106);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(112, 28);
            this.cmbSubject.TabIndex = 3;
            this.cmbSubject.SelectedIndexChanged += new System.EventHandler(this.cmbSubject_SelectedIndexChanged);
            // 
            // txtstudentName
            // 
            this.txtstudentName.Location = new System.Drawing.Point(179, 37);
            this.txtstudentName.Name = "txtstudentName";
            this.txtstudentName.Size = new System.Drawing.Size(90, 27);
            this.txtstudentName.TabIndex = 2;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(53, 114);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(62, 20);
            this.lblSubject.TabIndex = 1;
            this.lblSubject.Text = "Subject";
            this.lblSubject.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblEx
            // 
            this.lblEx.AutoSize = true;
            this.lblEx.Location = new System.Drawing.Point(45, 76);
            this.lblEx.Name = "lblEx";
            this.lblEx.Size = new System.Drawing.Size(91, 20);
            this.lblEx.TabIndex = 0;
            this.lblEx.Text = "ExamName";
            // 
            // grpAddMarks
            // 
            this.grpAddMarks.Controls.Add(this.lblExam);
            this.grpAddMarks.Controls.Add(this.cmbExam);
            this.grpAddMarks.Controls.Add(this.dgvMarks);
            this.grpAddMarks.Controls.Add(this.btnEdit);
            this.grpAddMarks.Controls.Add(this.btnAddMarks);
            this.grpAddMarks.Controls.Add(this.numMarks);
            this.grpAddMarks.Controls.Add(this.cmbStudent);
            this.grpAddMarks.Controls.Add(this.lblStudent);
            this.grpAddMarks.Controls.Add(this.lblMarks);
            this.grpAddMarks.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAddMarks.Location = new System.Drawing.Point(36, 339);
            this.grpAddMarks.Name = "grpAddMarks";
            this.grpAddMarks.Size = new System.Drawing.Size(488, 244);
            this.grpAddMarks.TabIndex = 1;
            this.grpAddMarks.TabStop = false;
            this.grpAddMarks.Text = "Marks Management";
            // 
            // lblExam
            // 
            this.lblExam.AutoSize = true;
            this.lblExam.Location = new System.Drawing.Point(53, 75);
            this.lblExam.Name = "lblExam";
            this.lblExam.Size = new System.Drawing.Size(49, 20);
            this.lblExam.TabIndex = 10;
            this.lblExam.Text = "Exam";
            // 
            // cmbExam
            // 
            this.cmbExam.FormattingEnabled = true;
            this.cmbExam.Location = new System.Drawing.Point(178, 75);
            this.cmbExam.Name = "cmbExam";
            this.cmbExam.Size = new System.Drawing.Size(112, 28);
            this.cmbExam.TabIndex = 9;
            this.cmbExam.SelectedIndexChanged += new System.EventHandler(this.cmbExam_SelectedIndexChanged_1);
            // 
            // dgvMarks
            // 
            this.dgvMarks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarks.Location = new System.Drawing.Point(57, 142);
            this.dgvMarks.Name = "dgvMarks";
            this.dgvMarks.RowHeadersWidth = 51;
            this.dgvMarks.RowTemplate.Height = 24;
            this.dgvMarks.Size = new System.Drawing.Size(365, 118);
            this.dgvMarks.TabIndex = 6;
            this.dgvMarks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMarks_CellContentClick);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(352, 107);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(62, 28);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAddMarks
            // 
            this.btnAddMarks.Location = new System.Drawing.Point(352, 43);
            this.btnAddMarks.Name = "btnAddMarks";
            this.btnAddMarks.Size = new System.Drawing.Size(62, 28);
            this.btnAddMarks.TabIndex = 5;
            this.btnAddMarks.Text = "ADD";
            this.btnAddMarks.UseVisualStyleBackColor = true;
            this.btnAddMarks.Click += new System.EventHandler(this.btnAddMarks_Click_1);
            // 
            // numMarks
            // 
            this.numMarks.Location = new System.Drawing.Point(178, 109);
            this.numMarks.Name = "numMarks";
            this.numMarks.Size = new System.Drawing.Size(120, 27);
            this.numMarks.TabIndex = 7;
            this.numMarks.ValueChanged += new System.EventHandler(this.numMarks_ValueChanged);
            // 
            // cmbStudent
            // 
            this.cmbStudent.FormattingEnabled = true;
            this.cmbStudent.Location = new System.Drawing.Point(178, 39);
            this.cmbStudent.Name = "cmbStudent";
            this.cmbStudent.Size = new System.Drawing.Size(112, 28);
            this.cmbStudent.TabIndex = 5;
            this.cmbStudent.SelectedIndexChanged += new System.EventHandler(this.cmbStudent_SelectedIndexChanged);
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Location = new System.Drawing.Point(53, 39);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(64, 20);
            this.lblStudent.TabIndex = 2;
            this.lblStudent.Text = "Student";
            this.lblStudent.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblMarks
            // 
            this.lblMarks.AutoSize = true;
            this.lblMarks.Location = new System.Drawing.Point(63, 116);
            this.lblMarks.Name = "lblMarks";
            this.lblMarks.Size = new System.Drawing.Size(54, 20);
            this.lblMarks.TabIndex = 3;
            this.lblMarks.Text = "Marks";
            this.lblMarks.Click += new System.EventHandler(this.lblMarks_Click);
            // 
            // lblstu
            // 
            this.lblstu.AutoSize = true;
            this.lblstu.Location = new System.Drawing.Point(45, 40);
            this.lblstu.Name = "lblstu";
            this.lblstu.Size = new System.Drawing.Size(110, 20);
            this.lblstu.TabIndex = 6;
            this.lblstu.Text = "Student Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(178, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(90, 27);
            this.textBox1.TabIndex = 7;
            // 
            // ExamMarkManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(889, 595);
            this.Controls.Add(this.grpAddMarks);
            this.Controls.Add(this.groupBox1);
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
        private System.Windows.Forms.ComboBox cmbExam;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblstu;
    }
}