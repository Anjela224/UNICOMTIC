using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTICManagementSystem.Data
{
    public static class Migration
    {
        public static void CreateTables()
        {
            using (var conn = Dbconfig.GetConnection())
            {
                var cmd = conn.CreateCommand();

                cmd.CommandText = @"
                CREATE TABLE IF NOT EXISTS Users (
                    UserID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Username TEXT NOT NULL,
                    Password TEXT NOT NULL,
                    Role TEXT NOT NULL
                );
                
                CREATE TABLE IF NOT EXISTS Students (
                    StudentID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL,
                    CourseID INTEGER,
                    Email TEXT,
                    FOREIGN KEY(CourseID)REFERENCES Courses(CourseID)

                );

                CREATE TABLE IF NOT EXISTS Lecturers (
                    LecturerID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL,
                    Username TEXT NOT NULL,
                    Password TEXT NOT NULL,
                    Email TEXT
                );

               CREATE TABLE IF NOT EXISTS Subjects (
                    SubjectID INTEGER PRIMARY KEY AUTOINCREMENT,
                    SubjectName TEXT NOT NULL,
                    LecturerID INTEGER,
                    CourseID INTEGER,
                    FOREIGN KEY (LecturerID) REFERENCES Lecturers(LecturerID),
                    FOREIGN KEY (CourseID) REFERENCES Courses(CourseID)
                );
                CREATE TABLE IF NOT EXISTS Exams (
                    ExamID INTEGER PRIMARY KEY AUTOINCREMENT,
                    SubjectID INTEGER NOT NULL,
                    ExamName TEXT NOT NULL,
                    ExamDate TEXT,
                    FOREIGN KEY (SubjectID) REFERENCES Subjects(SubjectID)
                );
                CREATE TABLE IF NOT EXISTS Marks (
                    MarkID INTEGER PRIMARY KEY AUTOINCREMENT,
                    StudentID INTEGER NOT NULL,
                    ExamID INTEGER NOT NULL,
                    Score INTEGER NOT NULL,
                    FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
                    FOREIGN KEY (ExamID) REFERENCES Exams(ExamID)
);

                

                CREATE TABLE IF NOT EXISTS Timetable (
                    TimetableID INTEGER PRIMARY KEY AUTOINCREMENT,
                    SubjectID INTEGER,
                    Date TEXT,
                    RoomID INTEGER,
                    TimeSlot TEXT,
                    FOREIGN KEY (SubjectID) REFERENCES Subjects(SubjectID),
                    FOREIGN KEY (RoomID) REFERENCES Rooms(RoomID)
                );

                CREATE TABLE IF NOT EXISTS Attendance (
                    AttendanceID INTEGER PRIMARY KEY AUTOINCREMENT,
                    StudentID INTEGER,
                    SubjectID INTEGER,
                    Date TEXT,
                    Status TEXT,
                    FOREIGN KEY(StudentID) REFERENCES Students(StudentID),
                    FOREIGN KEY(SubjectID) REFERENCES Subjects(SubjectID)
                
                );
                CREATE TABLE IF NOT EXISTS Courses (
                    CourseID INTEGER PRIMARY KEY AUTOINCREMENT,
                    CourseName TEXT NOT NULL
                );
                CREATE TABLE IF NOT EXISTS Rooms (
                    RoomID INTEGER PRIMARY KEY AUTOINCREMENT,
                    RoomName TEXT NOT NULL,
                    RoomType TEXT NOT NULL
                );

                ";

                cmd.ExecuteNonQuery();
            }
        }
    }
}
