namespace UnicomTICManagementSystem.View
{
    partial class RegistrationForm
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
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtcpass = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.lblrole = new System.Windows.Forms.Label();
            this.lblcpass = new System.Windows.Forms.Label();
            this.lblpass = new System.Windows.Forms.Label();
            this.lbluser = new System.Windows.Forms.Label();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnregi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbRole);
            this.groupBox1.Controls.Add(this.txtpass);
            this.groupBox1.Controls.Add(this.txtcpass);
            this.groupBox1.Controls.Add(this.txtuser);
            this.groupBox1.Controls.Add(this.lblrole);
            this.groupBox1.Controls.Add(this.lblcpass);
            this.groupBox1.Controls.Add(this.lblpass);
            this.groupBox1.Controls.Add(this.lbluser);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(151, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 248);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registration Form";
            // 
            // cmbRole
            // 
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Location = new System.Drawing.Point(154, 157);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(169, 23);
            this.cmbRole.TabIndex = 8;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(154, 84);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(174, 23);
            this.txtpass.TabIndex = 7;
            // 
            // txtcpass
            // 
            this.txtcpass.Location = new System.Drawing.Point(154, 117);
            this.txtcpass.Name = "txtcpass";
            this.txtcpass.Size = new System.Drawing.Size(174, 23);
            this.txtcpass.TabIndex = 5;
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(154, 44);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(174, 23);
            this.txtuser.TabIndex = 4;
            // 
            // lblrole
            // 
            this.lblrole.AutoSize = true;
            this.lblrole.Location = new System.Drawing.Point(29, 165);
            this.lblrole.Name = "lblrole";
            this.lblrole.Size = new System.Drawing.Size(67, 15);
            this.lblrole.TabIndex = 3;
            this.lblrole.Text = "Select Role";
            // 
            // lblcpass
            // 
            this.lblcpass.AutoSize = true;
            this.lblcpass.Location = new System.Drawing.Point(29, 124);
            this.lblcpass.Name = "lblcpass";
            this.lblcpass.Size = new System.Drawing.Size(109, 15);
            this.lblcpass.TabIndex = 2;
            this.lblcpass.Text = "Confirm Password";
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.Location = new System.Drawing.Point(29, 87);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(61, 15);
            this.lblpass.TabIndex = 1;
            this.lblpass.Text = "Password";
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Location = new System.Drawing.Point(29, 47);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(62, 15);
            this.lbluser.TabIndex = 0;
            this.lbluser.Text = "Username";
            // 
            // btncancel
            // 
            this.btncancel.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Location = new System.Drawing.Point(373, 359);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(79, 29);
            this.btncancel.TabIndex = 2;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click_1);
            // 
            // btnregi
            // 
            this.btnregi.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregi.Location = new System.Drawing.Point(216, 359);
            this.btnregi.Name = "btnregi";
            this.btnregi.Size = new System.Drawing.Size(89, 29);
            this.btnregi.TabIndex = 3;
            this.btnregi.Text = "Registration";
            this.btnregi.UseVisualStyleBackColor = true;
            this.btnregi.Click += new System.EventHandler(this.btnregi_Click_1);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnregi);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.groupBox1);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtcpass;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Label lblrole;
        private System.Windows.Forms.Label lblcpass;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnregi;
    }
}