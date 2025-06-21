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
    internal class TimetableController
    {
            public void AddTimetable(Timetable timetable)
            {
                using (var conn = GetConnection())
                {
                    var cmd = new SQLiteCommand("INSERT INTO Timetable (SubjectID, TimeSlot, RoomID) VALUES (@SubjectID, @TimeSlot, @RoomID)", conn);
                    cmd.Parameters.AddWithValue("@SubjectID", timetable.SubjectID);
                    cmd.Parameters.AddWithValue("@TimeSlot", timetable.TimeSlot);
                    cmd.Parameters.AddWithValue("@RoomID", timetable.RoomID);
                    cmd.ExecuteNonQuery();
                }
            }

            public List<Timetable> GetAllTimetables()
            {
                var list = new List<Timetable>();
                using (var conn = Dbconfig.GetConnection())
                {
                    var cmd = new SQLiteCommand("SELECT * FROM Timetable", conn);
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                    list.Add(new Timetable
                    {
                        TimetableID = reader.GetInt32(0),
                        SubjectID = reader.GetInt32(1),
                        TimeSlot = !reader.IsDBNull(2) ? reader.GetString(2) : "",
                        RoomID = !reader.IsDBNull(3) ? reader.GetInt32(3) : 0
                    });

                }
            }
                return list;
            }
        public void UpdateTimetable(Timetable timetable)
        {
            using (var conn = GetConnection())
            {
                var cmd = new SQLiteCommand("UPDATE Timetable SET SubjectID = @SubjectID, TimeSlot = @TimeSlot, RoomID = @RoomID WHERE TimetableID = @TimetableID", conn);
                cmd.Parameters.AddWithValue("@SubjectID", timetable.SubjectID);
                cmd.Parameters.AddWithValue("@TimeSlot", timetable.TimeSlot);
                cmd.Parameters.AddWithValue("@RoomID", timetable.RoomID);
                cmd.Parameters.AddWithValue("@TimetableID", timetable.TimetableID);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteTimetable(int timetableId)
        {
            using (var conn = GetConnection())
            {
                var cmd = new SQLiteCommand("DELETE FROM Timetable WHERE TimetableID = @TimetableID", conn);
                cmd.Parameters.AddWithValue("@TimetableID", timetableId);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
        
    



