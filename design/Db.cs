using System.Data.SQLite;

namespace AttendanceTracker
{
    public static class Db
    {
        public static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(DbInitializer.ConnectionString);
        }
    }
}
