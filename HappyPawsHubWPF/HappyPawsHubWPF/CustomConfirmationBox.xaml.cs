using System.Windows;

namespace HappyPawsHubWPF
{
    public partial class CustomConfirmationBox : Window
    {
        public bool IsConfirmed { get; private set; } = false;

        public CustomConfirmationBox(string message)
        {
            InitializeComponent();
            txtMessage.Text = message;
        }

        private void BtnYes_Click(object sender, RoutedEventArgs e)
        {
            IsConfirmed = true;
            this.DialogResult = true;
            this.Close();
        }

        private void BtnNo_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }
    }
}
