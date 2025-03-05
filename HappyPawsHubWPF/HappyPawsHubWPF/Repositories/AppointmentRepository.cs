using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Windows;
using HappyPawsHubWPF.Models;

namespace HappyPawsHubWPF.Repositories
{
    public class AppointmentRepository
    {
        // Add a new appointment
        public static void AddAppointment(Appointment appointment)
        {
            using (var connection = Data.DatabaseHelper.GetConnection())
            {
                connection.Open();
                string query = @"INSERT INTO Appointments (UserId, PetType, PetName, DoctorName, Date, Time) 
                                 VALUES (@UserId, @PetType, @PetName, @DoctorName, @Date, @Time)";
                connection.Execute(query, appointment);
            }
        }

        // Retrieve all appointments for a specific user
        public static List<Appointment> GetAppointmentsByUser(int userId)
        {
            using (var connection = Data.DatabaseHelper.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Appointments WHERE UserId = @UserId";
                return connection.Query<Appointment>(query, new { UserId = userId }).ToList();
            }
        }

        // Update an existing appointment
        public static void UpdateAppointment(Appointment appointment)
        {
            using (var connection = Data.DatabaseHelper.GetConnection())
            {
                connection.Open();
                string query = @"UPDATE Appointments 
                                 SET PetType = @PetType, PetName = @PetName, DoctorName = @DoctorName, Date = @Date, Time = @Time 
                                 WHERE Id = @Id";
                connection.Execute(query, appointment);
            }
        }

        // Delete an appointment with confirmation
        public static void DeleteAppointment(int appointmentId)
        {
            using (var connection = Data.DatabaseHelper.GetConnection())
            {
                connection.Open();
                string query = "DELETE FROM Appointments WHERE Id = @Id";
                connection.Execute(query, new { Id = appointmentId });
            }
        }


    }
}
