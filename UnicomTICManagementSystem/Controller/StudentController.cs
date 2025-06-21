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
        internal class StudentController
        {
            public List<Student> GetAllStudents()
            {
                var students = new List<Student>();
                using (var conn = Dbconfig.GetConnection())
                {
                    var cmd = new SQLiteCommand(@"
                    SELECT s.StudentID, s.Name, s.CourseID, c.CourseName
                    FROM Students s
                    LEFT JOIN Courses c ON s.CourseID = c.CourseID", conn);

                using (var reader = cmd.ExecuteReader())

                    while (reader.Read())
                    {
                        students.Add(new Student
                        {
                            StudentID = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            CourseID = reader.GetInt32(2),
                            CourseName = reader.IsDBNull(3) ? "" : reader.GetString(3)
                        });
                    }
                }
                return students;
            }

            public void AddStudent(Student student)
            {
                using (var conn = Dbconfig.GetConnection())
                {
                    var cmd = new SQLiteCommand("INSERT INTO Students (Name, CourseID) VALUES (@Name, @CourseID)", conn);
                    cmd.Parameters.AddWithValue("@Name", student.Name);
                    cmd.Parameters.AddWithValue("@CourseID", student.CourseID);
                    cmd.ExecuteNonQuery();
                }
            }

            public void UpdateStudent(Student student)
            {
                using (var conn = Dbconfig.GetConnection())
                {
                    var cmd = new SQLiteCommand("UPDATE Students SET Name = @Name, CourseID = @CourseID WHERE StudentID = @StudentID", conn);
                    cmd.Parameters.AddWithValue("@Name", student.Name);
                    cmd.Parameters.AddWithValue("@CourseID", student.CourseID);
                    cmd.Parameters.AddWithValue("@StudentID", student.StudentID);
                    cmd.ExecuteNonQuery();
                }
            }

            public void DeleteStudent(int studentId)
            {
                using (var conn = Dbconfig.GetConnection())
                {
                    var cmd = new SQLiteCommand("DELETE FROM Students WHERE StudentID = @StudentID", conn);
                    cmd.Parameters.AddWithValue("@StudentID", studentId);
                    cmd.ExecuteNonQuery();
                }
            }

            public Student GetStudentById(int studentId)
            {
                using (var conn = Dbconfig.GetConnection())
                {
                    var cmd = new SQLiteCommand("SELECT * FROM Students WHERE StudentID = @StudentID", conn);
                    cmd.Parameters.AddWithValue("@StudentID", studentId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Student
                            {
                                StudentID = reader.GetInt32(0),
                                Name = reader.GetString(1),
                                CourseID = reader.GetInt32(2)
                            };
                        }
                    }
                }

                return null;
            }
        }
    }



