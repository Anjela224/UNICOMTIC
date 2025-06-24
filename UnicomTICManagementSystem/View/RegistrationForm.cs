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

namespace UnicomTICManagementSystem.View
{
    public partial class RegistrationForm : Form
    {
        private readonly LoginController controller = new LoginController();

        public RegistrationForm()
        {
            InitializeComponent();
            cmbRole.Items.AddRange(new string[] { "Admin", "Staff", "Student", "Lecturer" });
            cmbRole.SelectedIndex = 0;
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void btnregi_Click(object sender, EventArgs e)
        {

        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            var username = txtuser.Text.Trim();
            var password = txtpass.Text;
            var confirmPassword = txtcpass.Text;
            var role = cmbRole.SelectedItem?.ToString();

            var result = controller.RegisterUser(username, password, confirmPassword, role);
            MessageBox.Show(result.Message);

            if (result.IsSuccess)
            {
                this.DialogResult = DialogResult.OK;
                this.Close(); 
            }
        }

        private void btncancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnregi_Click_1(object sender, EventArgs e)
        {
            var username = txtuser.Text.Trim();
            var password = txtpass.Text;
            var confirmPassword = txtcpass.Text;
            var role = cmbRole.SelectedItem?.ToString();

            var result = controller.RegisterUser(username, password, confirmPassword, role);
            MessageBox.Show(result.Message);

            if (result.IsSuccess)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
  }

    

