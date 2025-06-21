using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTICManagementSystem.Data;
using UnicomTICManagementSystem.Models;
using static UnicomTICManagementSystem.Data.Dbconfig;

namespace UnicomTICManagementSystem.Controller
{
    internal class SubjectController

    {
        public List<Subject> GetAllSubjects()
        {
            var subjects = new List<Subject>();
            using (var conn = Dbconfig.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT * FROM Subjects", conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    subjects.Add(new Subject
                    {
                        SubjectID = reader["SubjectID"] != DBNull.Value ? Convert.ToInt32(reader["SubjectID"]) : 0,
                        SubjectName = reader["SubjectName"].ToString(),
                        CourseID = reader["CourseID"] != DBNull.Value ? Convert.ToInt32(reader["CourseID"]) : 0
                    });
                }
            }



            return subjects;

        }
            public void AddSubject(Subject subject)
            {
                using (var conn = Dbconfig.GetConnection())
                {
                    var cmd = new SQLiteCommand("INSERT INTO Subjects (SubjectName, CourseID) VALUES (@SubjectName, @CourseID)", conn);
                    cmd.Parameters.AddWithValue("@SubjectName", subject.SubjectName);
                    cmd.Parameters.AddWithValue("@CourseID", subject.CourseID);
                    cmd.ExecuteNonQuery();
                }
            }

            public void UpdateSubject(Subject subject)
            {
                using (var conn = Dbconfig.GetConnection())
                {
                    var cmd = new SQLiteCommand("UPDATE Subjects SET SubjectName = @SubjectName, CourseID = @CourseID WHERE SubjectID = @SubjectID", conn);
                    cmd.Parameters.AddWithValue("@SubjectName", subject.SubjectName);
                    cmd.Parameters.AddWithValue("@CourseID", subject.CourseID);
                    cmd.Parameters.AddWithValue("@SubjectID", subject.SubjectID);
                    cmd.ExecuteNonQuery();
                }
            }

            public void DeleteSubject(int subjectId)
            {
                using (var conn = Dbconfig.GetConnection())
                {
                    var cmd = new SQLiteCommand("DELETE FROM Subjects WHERE SubjectID = @SubjectID", conn);
                    cmd.Parameters.AddWithValue("@SubjectID", subjectId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }



