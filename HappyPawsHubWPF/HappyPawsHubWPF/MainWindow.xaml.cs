using System.Windows;
using HappyPawsHubWPF.Repositories;
using HappyPawsHubWPF.Models;

namespace HappyPawsHubWPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Data.DatabaseHelper.InitializeDatabase();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            var user = UserRepository.Login(txtEmail.Text, txtPassword.Password);
            if (user != null)
            {
                CustomMessageBox.ShowMessage("Welcome, " + user.Name + "!");
                new Dashboard(user).Show();
                this.Close();
            }
            else
            {
                CustomMessageBox.ShowMessage("Invalid login credentials."); // Changed to CustomMessageBox
            }
        }

        private void BtnRegister_Click(object sender, RoutedEventArgs e)
        {
            RegisterWindow registerWindow = new RegisterWindow();
            registerWindow.ShowDialog();
        }
    }
}
