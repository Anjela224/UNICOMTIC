using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTICManagementSystem.Data;
using UnicomTICManagementSystem.Models;

namespace UnicomTICManagementSystem.Controller
{
    internal class AttendanceController
    {
        public Attendance GetAttendance(int subjectId, int studentId, string date)
        {
            using (var conn = Dbconfig.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT * FROM Attendance WHERE SubjectID = @SubjectID AND StudentID = @StudentID AND Date = @Date", conn);
                cmd.Parameters.AddWithValue("@SubjectID", subjectId);
                cmd.Parameters.AddWithValue("@StudentID", studentId);
                cmd.Parameters.AddWithValue("@Date", date);

                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new Attendance
                    {
                        AttendanceID = reader.GetInt32(0),
                        StudentID = reader.GetInt32(1),
                        SubjectID = reader.GetInt32(2),
                        Date = reader.GetString(3),
                        Status = reader.GetString(4)
                    };
                }
            }

            return null; 
        }

        public void AddAttendance(Attendance attendance)
            {
                using (var conn = Dbconfig.GetConnection())
                {
                
                string query = "INSERT INTO Attendance (StudentID, SubjectID, Date, Status) VALUES (@StudentID, @SubjectID, @Date, @Status)";
                    using (var cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@StudentID", attendance.StudentID);
                        cmd.Parameters.AddWithValue("@SubjectID", attendance.SubjectID);
                        cmd.Parameters.AddWithValue("@Date", attendance.Date);
                        cmd.Parameters.AddWithValue("@Status", attendance.Status);
                        cmd.ExecuteNonQuery();
                    }
                }
            }

            public List<Attendance> GetAttendanceByStudent(int studentId)
            {
                var list = new List<Attendance>();
                using (var conn = Dbconfig.GetConnection())
                {
                    
                    var cmd = new SQLiteCommand("SELECT * FROM Attendance WHERE StudentID = @StudentID", conn);
                    cmd.Parameters.AddWithValue("@StudentID", studentId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new Attendance
                            {
                                AttendanceID = Convert.ToInt32(reader["AttendanceID"]),
                                StudentID = Convert.ToInt32(reader["StudentID"]),
                                SubjectID = Convert.ToInt32(reader["SubjectID"]),
                                Date = reader["Date"].ToString(),
                                Status = reader["Status"].ToString()
                            });
                        }
                    }
                }
                return list;
            }

            public void UpdateAttendance(Attendance attendance)
            {
                using (var conn = Dbconfig.GetConnection())
                {
                    
                    var cmd = new SQLiteCommand("UPDATE Attendance SET Status = @Status WHERE AttendanceID = @AttendanceID", conn);
                    cmd.Parameters.AddWithValue("@Status", attendance.Status);
                    cmd.Parameters.AddWithValue("@AttendanceID", attendance.AttendanceID);
                    cmd.ExecuteNonQuery();
                }
            }

            public void DeleteAttendance(int attendanceId)
            {
                using (var conn = Dbconfig.GetConnection())
                {
                    
                    var cmd = new SQLiteCommand("DELETE FROM Attendance WHERE AttendanceID = @AttendanceID", conn);
                    cmd.Parameters.AddWithValue("@AttendanceID", attendanceId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }

