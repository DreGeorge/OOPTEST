using System;
using System.Data.SQLite;

namespace AttendanceTracker
{
    public static class UserRepository
    {
        public static bool Register(User u)
        {
            using (var con = Db.GetConnection())
            {
                con.Open();
                string sql = @"
                INSERT INTO Users
                (UserID, FirstName, LastName, ContactNumber, Address, Email, PasswordHash, CreatedAt)
                VALUES
                (@UserID, @FirstName, @LastName, @ContactNumber, @Address, @Email, @PasswordHash, @CreatedAt);";

                using (var cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@UserID", u.UserID);
                    cmd.Parameters.AddWithValue("@FirstName", u.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", u.LastName);
                    cmd.Parameters.AddWithValue("@ContactNumber", u.ContactNumber);
                    cmd.Parameters.AddWithValue("@Address", u.Address);
                    cmd.Parameters.AddWithValue("@Email", u.Email);
                    cmd.Parameters.AddWithValue("@PasswordHash", u.PasswordHash);
                    cmd.Parameters.AddWithValue("@CreatedAt", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public static bool ValidateLogin(string id, string password)
        {
            using (var con = Db.GetConnection())
            {
                con.Open();
                string sql = "SELECT PasswordHash FROM Users WHERE UserID = @UserID;";

                using (var cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@UserID", id);

                    var result = cmd.ExecuteScalar();
                    if (result == null) return false;

                    string storedHash = result.ToString();
                    return PasswordHelper.Verify(password, storedHash);
                }
            }
        }

        public static bool UserExists(string id)
        {
            using (var con = Db.GetConnection())
            {
                con.Open();
                string sql = "SELECT COUNT(*) FROM Users WHERE UserID=@UserID;";
                using (var cmd = new SQLiteCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@UserID", id);
                    long count = (long)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }
    }
}
