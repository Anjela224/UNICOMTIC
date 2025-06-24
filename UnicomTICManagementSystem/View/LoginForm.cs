using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace UnicomTICManagementSystem.View
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)

        {
            string username = txtusername.Text.Trim();
            string password = txtpassword.Text.Trim();

            if (password.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            using (var conn = Dbconfig.GetConnection())
            {
                string query = "SELECT Role FROM Users WHERE Username = @username AND Password = @password";
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    object result = cmd.ExecuteScalar();


                    if (result != null && result != DBNull.Value)
                    {
                        string role = result.ToString();

                        {
                            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            MainForm mainForm = new MainForm(username, role);
                            mainForm.ShowDialog();
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid credentials.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                    }
                }
            }
        
        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void grpLogin_Enter(object sender, EventArgs e)
        {

        }

        private void btnregi_Click(object sender, EventArgs e)
        {
            RegistrationForm regForm = new RegistrationForm();
            DialogResult result = regForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                MessageBox.Show("Registration completed.");
            }
        }

        }
    }
    

       
    

