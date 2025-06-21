using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTICManagementSystem.Data;
using UnicomTICManagementSystem.Models;
using UnicomTICManagementSystem.Repositories;
using static UnicomTICManagementSystem.Data.Dbconfig;

namespace UnicomTICManagementSystem.Controller
{
        internal class MarkController
        {
            public void AddMark(Mark mark)
            {
                using (var conn = Dbconfig.GetConnection())
                {
                    var cmd = new SQLiteCommand("INSERT INTO Marks (StudentID, ExamID, Score) VALUES (@StudentID, @ExamID, @Score)", conn);
                    cmd.Parameters.AddWithValue("@StudentID", mark.StudentID);
                    cmd.Parameters.AddWithValue("@ExamID", mark.ExamID);
                    cmd.Parameters.AddWithValue("@Score", mark.Score);
                    cmd.ExecuteNonQuery();
                }
            }
        public void UpdateMark(Mark mark)
        {
            string query = "UPDATE Marks SET Score = @Score WHERE MarkID = @MarkID";

            using (var conn = Dbconfig.GetConnection())
            {
                conn.Open();
                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Score", mark.Score);
                    cmd.Parameters.AddWithValue("@MarkID", mark.MarkID);
                    cmd.ExecuteNonQuery();
                }
            }
        }
            public List<Mark> GetMarksByStudent(int studentId)
            {
                var marks = new List<Mark>();
                using (var conn = Dbconfig.GetConnection())
                {
                    var cmd = new SQLiteCommand("SELECT * FROM Marks WHERE StudentID = @StudentID", conn);
                    cmd.Parameters.AddWithValue("@StudentID", studentId);
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        marks.Add(new Mark
                        {
                            MarkID = reader.GetInt32(0),
                            StudentID = reader.GetInt32(1),
                            ExamID = reader.GetInt32(2),
                            Score = reader.GetInt32(3)
                        });
                    }
                }
                return marks;
            }
        }
    }



