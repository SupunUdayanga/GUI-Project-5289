using System;
using System.Collections.Generic;
using System.Windows;
using HappyPawsHubWPF.Models;
using HappyPawsHubWPF.Repositories;

namespace HappyPawsHubWPF
{
    public partial class Dashboard : Window
    {
        private User _currentUser;

        public Dashboard(User user)
        {
            InitializeComponent();
            _currentUser = user;
            LoadAppointments();
        }

        private void LoadAppointments()
        {
            List<Appointment> appointments = AppointmentRepository.GetAppointmentsByUser(_currentUser.Id);

            AppointmentsGrid.ItemsSource = null;
            AppointmentsGrid.ItemsSource = appointments;
            AppointmentsGrid.Items.Refresh();

            if (AppointmentsGrid.Columns.Count > 5)
            {
                AppointmentsGrid.Columns[5].Visibility = appointments.Count > 0 ? Visibility.Visible : Visibility.Collapsed;
            }
        }

        private void AddAppointment_Click(object sender, RoutedEventArgs e)
        {
            new AddAppointmentWindow(_currentUser).ShowDialog();
            LoadAppointments();
        }

        private void EditAppointment_Click(object sender, RoutedEventArgs e)
        {
            if (AppointmentsGrid.SelectedItem is Appointment appointment)
            {
                new EditAppointmentWindow(appointment).ShowDialog();
                LoadAppointments();
            }
        }

        private void DeleteAppointment_Click(object sender, RoutedEventArgs e)
        {
            if (AppointmentsGrid.SelectedItem is Appointment appointment)
            {
                // Show confirmation message BEFORE calling the repository
                CustomConfirmationBox confirmationBox = new CustomConfirmationBox("Are you sure you want to delete this appointment?");
                bool? result = confirmationBox.ShowDialog();

                if (result == true) // User clicked "Yes"
                {
                    // Now delete the appointment without re-triggering the confirmation
                    AppointmentRepository.DeleteAppointment(appointment.Id);
                    CustomMessageBox.ShowMessage("Appointment deleted successfully.");
                    LoadAppointments();
                }
            }
        }





        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            this.Close();
        }
    }
}
