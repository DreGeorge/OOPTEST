using System;
using System.Data.SQLite;
using System.IO;

namespace AttendanceTracker
{
    public static class DbInitializer
    {
        public static string DbPath =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Database", "attendance.db");

        public static string ConnectionString =>
            $"Data Source={DbPath};Version=3;";

        public static void Initialize()
        {
            // ensure folder exists
            string folder = Path.GetDirectoryName(DbPath);
            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);

            // create db file if missing
            if (!File.Exists(DbPath))
                SQLiteConnection.CreateFile(DbPath);

            using (var con = new SQLiteConnection(ConnectionString))
            {
                con.Open();

                string createUsers = @"
                CREATE TABLE IF NOT EXISTS Users (
                    UserID TEXT PRIMARY KEY,
                    FirstName TEXT NOT NULL,
                    LastName TEXT NOT NULL,
                    ContactNumber TEXT,
                    Address TEXT,
                    Email TEXT UNIQUE NOT NULL,
                    PasswordHash TEXT NOT NULL,
                    CreatedAt TEXT NOT NULL
                );";

                string createAttendance = @"
                CREATE TABLE IF NOT EXISTS AttendanceRecords (
                    AttendanceID INTEGER PRIMARY KEY AUTOINCREMENT,
                    UserID TEXT NOT NULL,
                    Date TEXT NOT NULL,
                    TimeIn TEXT,
                    TimeOut TEXT,
                    Status TEXT NOT NULL,
                    Remarks TEXT,
                    FOREIGN KEY(UserID) REFERENCES Users(UserID)
                );";

                using (var cmd = new SQLiteCommand(createUsers, con))
                    cmd.ExecuteNonQuery();

                using (var cmd = new SQLiteCommand(createAttendance, con))
                    cmd.ExecuteNonQuery();
            }
        }
    }
}
