using Dapper;
using System.Data.SQLite;
using System.Linq;
using HappyPawsHubWPF.Models;

namespace HappyPawsHubWPF.Repositories
{
    public class UserRepository
    {
        public static User Register(string name, string email, string password)
        {
            using (var connection = Data.DatabaseHelper.GetConnection())
            {
                connection.Open();
                string query = "INSERT INTO Users (Name, Email, Password) VALUES (@Name, @Email, @Password); SELECT last_insert_rowid();";
                int userId = connection.ExecuteScalar<int>(query, new { Name = name, Email = email, Password = password });
                return new User { Id = userId, Name = name, Email = email, Password = password };
            }
        }

        public static User Login(string email, string password)
        {
            using (var connection = Data.DatabaseHelper.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Users WHERE Email = @Email AND Password = @Password";
                return connection.Query<User>(query, new { Email = email, Password = password }).FirstOrDefault();
            }
        }
    }
}
