using System.Windows;
using HappyPawsHubWPF.Repositories;
using HappyPawsHubWPF.Models;

namespace HappyPawsHubWPF
{
    public partial class RegisterWindow : Window
    {
        public RegisterWindow()
        {
            InitializeComponent();
        }

        private void BtnRegister_Click(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Password;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                CustomMessageBox.ShowMessage("Please fill all fields.");
                return;
            }

            User existingUser = UserRepository.Login(email, password);
            if (existingUser != null)
            {
                CustomMessageBox.ShowMessage("This email is already registered.");
                return;
            }

            User newUser = UserRepository.Register(name, email, password);
            CustomMessageBox.ShowMessage("Registration successful! Please log in.");
            this.Close();
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
