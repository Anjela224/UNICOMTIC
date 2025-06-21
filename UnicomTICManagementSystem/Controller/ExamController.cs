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
        internal class ExamController
        {
        public List<Exam> GetExamsBySubject(int subjectId)
        {
                var exams = new List<Exam>();
                using (var conn = Dbconfig.GetConnection())
                {
                    var cmd = new SQLiteCommand("SELECT * FROM Exams", conn);
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        exams.Add(new Exam
                        {
                            ExamID = reader.GetInt32(0),
                            ExamName = reader.GetString(1),
                            SubjectID = reader.GetInt32(2)
                        });
                    }
                }
                return exams;
            }

            public void AddExam(Exam exam)
            {
                using (var conn = Dbconfig.GetConnection())
                {
                    var cmd = new SQLiteCommand("INSERT INTO Exams (ExamName, SubjectID) VALUES (@ExamName, @SubjectID)", conn);
                    cmd.Parameters.AddWithValue("@ExamName", exam.ExamName);
                    cmd.Parameters.AddWithValue("@SubjectID", exam.SubjectID);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }



