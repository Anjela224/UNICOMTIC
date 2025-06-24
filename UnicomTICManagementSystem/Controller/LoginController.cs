using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTICManagementSystem.Data;
using static UnicomTICManagementSystem.Data.Dbconfig;
using UnicomTICManagementSystem.Controller;


namespace UnicomTICManagementSystem.Controller
{
    internal class LoginController
    {
        public LoginResult ValidateUser(string username, string password)
        {
            using (var conn = Dbconfig.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT UserID, Role FROM Users WHERE Username = @Username AND Password = @Password", conn);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {

                        var role = reader.GetString(1);
                        return new LoginResult
                        {
                            IsSuccess = true,
                            Role = role,
                            Message = "Login successful"
                        };
                    }
                    else
                    {

                        return new LoginResult
                        {
                            IsSuccess = false,
                            Role = null,
                            Message = "Invalid username or password"
                        };
                    }

                }
            }
        }
        public RegistrationResult RegisterUser(string username, string password, string confirmPassword, string role)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(role))
            {
                return new RegistrationResult { IsSuccess = false, Message = "All fields are required." };
            }

            if (password != confirmPassword)
            {
                return new RegistrationResult { IsSuccess = false, Message = "Passwords do not match." };
            }

            using (var conn = Dbconfig.GetConnection())
            {
                var checkCmd = new SQLiteCommand("SELECT COUNT(*) FROM Users WHERE Username = @Username", conn);
                checkCmd.Parameters.AddWithValue("@Username", username);
                long count = (long)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    return new RegistrationResult { IsSuccess = false, Message = "Username already exists." };
                }

                var insertCmd = new SQLiteCommand("INSERT INTO Users (Username, Password, Role) VALUES (@Username, @Password, @Role)", conn);
                insertCmd.Parameters.AddWithValue("@Username", username);
                insertCmd.Parameters.AddWithValue("@Password", password);
                insertCmd.Parameters.AddWithValue("@Role", role);

                try
                {
                    insertCmd.ExecuteNonQuery();
                    return new RegistrationResult { IsSuccess = true, Message = "Registration successful." };
                }
                catch (Exception ex)
                {
                    return new RegistrationResult { IsSuccess = false, Message = "Error: " + ex.Message };
                }


            }

        }
        public class LoginResult
        {
            public bool IsSuccess { get; set; }
            public string Role { get; set; }
            public string Message { get; set; }
        }

        public class RegistrationResult
        {
            public bool IsSuccess { get; set; }
            public string Message { get; set; }
        }

    }

}
