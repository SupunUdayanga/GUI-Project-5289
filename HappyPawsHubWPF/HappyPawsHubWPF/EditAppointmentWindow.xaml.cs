using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using HappyPawsHubWPF.Repositories;
using HappyPawsHubWPF.Models;

namespace HappyPawsHubWPF
{
    public partial class EditAppointmentWindow : Window
    {
        private Appointment _appointment;

        public EditAppointmentWindow(Appointment appointment)
        {
            InitializeComponent();
            _appointment = appointment;
            LoadDoctorNames();
            LoadAppointmentData();
        }

        private void LoadDoctorNames()
        {
            // Ensure the ComboBox is cleared before adding new items
            cbDoctorName.Items.Clear();

            // Add predefined doctor names as strings
            string[] doctors = { "Dr. 1", "Dr. 2", "Dr. 3", "Dr. 4", "Dr. 5" };

            foreach (var doctor in doctors)
            {
                cbDoctorName.Items.Add(doctor);
            }
        }

        private void LoadAppointmentData()
        {
            // Set pet type from ComboBoxItem
            cbPetType.SelectedItem = cbPetType.Items.Cast<ComboBoxItem>()
                .FirstOrDefault(item => item.Content.ToString() == _appointment.PetType);

            txtPetName.Text = _appointment.PetName;

            // Select the doctor if it exists in the ComboBox
            cbDoctorName.SelectedItem = _appointment.DoctorName;

            // Set date
            dpDate.SelectedDate = DateTime.Parse(_appointment.Date);

            // Set time from ComboBoxItem
            cbTime.SelectedItem = cbTime.Items.Cast<ComboBoxItem>()
                .FirstOrDefault(item => item.Content.ToString() == _appointment.Time);
        }

        private void SaveChanges_Click(object sender, RoutedEventArgs e)
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

            _appointment.PetType = ((ComboBoxItem)cbPetType.SelectedItem).Content.ToString();
            _appointment.PetName = txtPetName.Text.Trim();
            _appointment.DoctorName = cbDoctorName.SelectedItem.ToString();
            _appointment.Date = dpDate.SelectedDate?.ToString("yyyy-MM-dd") ?? "";
            _appointment.Time = ((ComboBoxItem)cbTime.SelectedItem).Content.ToString();

            AppointmentRepository.UpdateAppointment(_appointment);
            CustomMessageBox.ShowMessage("Appointment updated successfully!");
            this.Close();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
