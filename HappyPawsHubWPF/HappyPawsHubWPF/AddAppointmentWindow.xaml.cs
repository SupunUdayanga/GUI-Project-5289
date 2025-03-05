using System;
using System.Windows;
using System.Windows.Controls;
using HappyPawsHubWPF.Models;
using HappyPawsHubWPF.Repositories;

namespace HappyPawsHubWPF
{
    public partial class AddAppointmentWindow : Window
    {
        private User _currentUser;

        public AddAppointmentWindow(User user)
        {
            InitializeComponent();
            _currentUser = user;
        }

        private void SaveAppointment_Click(object sender, RoutedEventArgs e)
        {
            if (cbPetType.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtPetName.Text) ||
                cbDoctorName.SelectedItem == null ||
                dpDate.SelectedDate == null ||
                cbTime.SelectedItem == null)
            {
                CustomMessageBox.ShowMessage("Please fill all fields before saving.");
                return;
            }

            // Get selected values
            string petType = ((ComboBoxItem)cbPetType.SelectedItem).Content.ToString();
            string doctorName = ((ComboBoxItem)cbDoctorName.SelectedItem).Content.ToString();
            string appointmentDate = dpDate.SelectedDate?.ToString("yyyy-MM-dd") ?? "";
            string appointmentTime = ((ComboBoxItem)cbTime.SelectedItem).Content.ToString();

            // Create a new appointment object
            Appointment newAppointment = new Appointment
            {
                UserId = _currentUser.Id,
                PetType = petType,
                PetName = txtPetName.Text.Trim(),
                DoctorName = doctorName,
                Date = appointmentDate,
                Time = appointmentTime
            };

            // Save appointment
            AppointmentRepository.AddAppointment(newAppointment);
            CustomMessageBox.ShowMessage("Appointment added successfully!");
            this.Close();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
