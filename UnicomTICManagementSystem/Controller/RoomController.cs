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
        internal class RoomController
        {
            public List<Room> GetAllRooms()
            {
                var rooms = new List<Room>();
                using (var conn = Dbconfig.GetConnection())
                {
                    var cmd = new SQLiteCommand("SELECT * FROM Rooms", conn);
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        rooms.Add(new Room
                        {
                            RoomID = reader.GetInt32(0),
                            RoomName = reader.GetString(1),
                            RoomType = reader.GetString(2)
                        });
                    }
                }
                return rooms;
            }
        public void AddRoom(Room room)
        {
            using (var conn = Dbconfig.GetConnection())
            {
                var cmd = new SQLiteCommand("INSERT INTO Rooms (RoomName, RoomType) VALUES (@RoomName, @RoomType)", conn);
                cmd.Parameters.AddWithValue("@RoomName", room.RoomName);
                cmd.Parameters.AddWithValue("@RoomType", room.RoomType);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateRoom(Room room)
        {
            using (var conn = Dbconfig.GetConnection())
            {
                var cmd = new SQLiteCommand("UPDATE Rooms SET RoomName = @RoomName, RoomType = @RoomType WHERE RoomID = @RoomID", conn);
                cmd.Parameters.AddWithValue("@RoomName", room.RoomName);
                cmd.Parameters.AddWithValue("@RoomType", room.RoomType);
                cmd.Parameters.AddWithValue("@RoomID", room.RoomID);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteRoom(int roomId)
        {
            using (var conn = Dbconfig.GetConnection())
            {
                var cmd = new SQLiteCommand("DELETE FROM Rooms WHERE RoomID = @RoomID", conn);
                cmd.Parameters.AddWithValue("@RoomID", roomId);
                cmd.ExecuteNonQuery();
            }
        }

    }
}



