using System;
using System.Data.SQLite;
using System.IO;

namespace HappyPawsHubWPF.Data
{
    public static class DatabaseHelper
    {
        private static string dbFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Database");
        private static string dbFile = Path.Combine(dbFolder, "HappyPaws.db");
        private static string connectionString = $"Data Source={dbFile};Version=3;";

        public static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(connectionString);
        }

        public static void InitializeDatabase()
        {
            // Ensure the Database folder exists
            if (!Directory.Exists(dbFolder))
            {
                Directory.CreateDirectory(dbFolder);
            }

            // Create the database file if it does not exist
            if (!File.Exists(dbFile))
            {
                SQLiteConnection.CreateFile(dbFile);
            }

            using (var connection = GetConnection())
            {
                connection.Open();

                string userTable = @"CREATE TABLE IF NOT EXISTS Users (
                                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                        Name TEXT NOT NULL,
                                        Email TEXT UNIQUE NOT NULL,
                                        Password TEXT NOT NULL
                                    );";

                string appointmentTable = @"CREATE TABLE IF NOT EXISTS Appointments (
                                              Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                              UserId INTEGER NOT NULL,
                                              PetType TEXT NOT NULL,
                                              PetName TEXT NOT NULL,
                                              DoctorName TEXT NOT NULL,
                                              Date TEXT NOT NULL,
                                              Time TEXT NOT NULL,
                                              FOREIGN KEY (UserId) REFERENCES Users(Id)
                                          );";

                using (var command = new SQLiteCommand(userTable, connection))
                {
                    command.ExecuteNonQuery();
                }
                using (var command = new SQLiteCommand(appointmentTable, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
