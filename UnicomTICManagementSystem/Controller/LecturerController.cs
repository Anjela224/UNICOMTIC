using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTICManagementSystem.Models;
using static UnicomTICManagementSystem.Data.Dbconfig;


namespace UnicomTICManagementSystem.Controller
{
    internal class LecturerController
    {
        public List<Lecturer> GetAllLecturers()
        {
            var lecturers = new List<Lecturer>();
            using (var conn = GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT * FROM Lecturers", conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lecturers.Add(new Lecturer
                    {
                        LecturerID = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Username = reader.GetString(2),
                        Password = reader.GetString(3)
                    });
                }
            }
            return lecturers;
        }

        public void AddLecturer(Lecturer lecturer)
        {
            using (var conn = GetConnection())
            {
                var cmd = new SQLiteCommand("INSERT INTO Lecturers (Name, Username, Password) VALUES (@Name, @Username, @Password)", conn);
                cmd.Parameters.AddWithValue("@Name", lecturer.Name);
                cmd.Parameters.AddWithValue("@Username", lecturer.Username);
                cmd.Parameters.AddWithValue("@Password", lecturer.Password);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateLecturer(Lecturer lecturer)
        {
            using (var conn = GetConnection())
            {
                var cmd = new SQLiteCommand("UPDATE Lecturers SET Name = @Name, Username = @Username, Password = @Password WHERE LecturerID = @LecturerID", conn);
                cmd.Parameters.AddWithValue("@Name", lecturer.Name);
                cmd.Parameters.AddWithValue("@Username", lecturer.Username);
                cmd.Parameters.AddWithValue("@Password", lecturer.Password);
                cmd.Parameters.AddWithValue("@LecturerID", lecturer.LecturerID);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteLecturer(int lecturerId)
        {
            using (var conn = GetConnection())
            {
                var cmd = new SQLiteCommand("DELETE FROM Lecturers WHERE LecturerID = @LecturerID", conn);
                cmd.Parameters.AddWithValue("@LecturerID", lecturerId);
                cmd.ExecuteNonQuery();
            }
        }

        public Lecturer GetLecturerById(int lecturerId)
        {
            using (var conn = GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT * FROM Lecturers WHERE LecturerID = @LecturerID", conn);
                cmd.Parameters.AddWithValue("@LecturerID", lecturerId);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Lecturer
                        {
                            LecturerID = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Username = reader.GetString(2),
                            Password = reader.GetString(3)
                        };
                    }
                }
            }
            return null;
        }
    }
}

    

