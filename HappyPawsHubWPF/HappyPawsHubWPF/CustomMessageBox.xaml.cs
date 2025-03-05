using System;
using System.Windows;
using System.Windows.Media.Animation;
using System.Windows.Media;

namespace HappyPawsHubWPF
{
    public partial class CustomMessageBox : Window
    {
        public CustomMessageBox(string message)
        {
            InitializeComponent();
            txtMessage.Text = message;
            AnimateWindowIn();
        }

        private void BtnOk_Click(object sender, RoutedEventArgs e)
        {
            AnimateWindowOut();
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            AnimateWindowOut();
        }

        private void AnimateWindowIn()
        {
            DoubleAnimation fadeIn = new DoubleAnimation(0, 1, TimeSpan.FromSeconds(0.3));
            TranslateTransform slideIn = new TranslateTransform();
            this.RenderTransform = slideIn;
            DoubleAnimation slideAnimation = new DoubleAnimation(30, 0, TimeSpan.FromSeconds(0.3));

            this.BeginAnimation(Window.OpacityProperty, fadeIn);
            slideIn.BeginAnimation(TranslateTransform.YProperty, slideAnimation);
        }

        private void AnimateWindowOut()
        {
            DoubleAnimation fadeOut = new DoubleAnimation(1, 0, TimeSpan.FromSeconds(0.2));
            fadeOut.Completed += (s, e) => this.Close();
            this.BeginAnimation(Window.OpacityProperty, fadeOut);
        }
        

        public static void ShowMessage(string message)
        {
            CustomMessageBox msgBox = new CustomMessageBox(message);
            msgBox.ShowDialog();
        }
    }
}
