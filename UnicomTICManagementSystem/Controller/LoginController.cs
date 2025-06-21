using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTICManagementSystem.Data;
using static UnicomTICManagementSystem.Data.Dbconfig;

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
                            // Login success
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
                            // Login failed
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
        }

        public class LoginResult
        {
            public bool IsSuccess { get; set; }
            public string Role { get; set; }
            public string Message { get; set; }
        }
    }



