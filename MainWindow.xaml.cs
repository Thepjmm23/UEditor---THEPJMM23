using System.Windows;
using System.Windows.Input;

namespace UEditorApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // Set the default page to HomePage
            MainFrame.Navigate(new HomePage());
        }

        private void HomeButton_Click(object sender, MouseButtonEventArgs e)
        {
            MainFrame.Navigate(new HomePage());
        }

        private void InstallButton_Click(object sender, MouseButtonEventArgs e)
        {
            MainFrame.Navigate(new InstallPage());
        }

        private void CreditsButton_Click(object sender, MouseButtonEventArgs e)
        {
            MainFrame.Navigate(new CreditsPage());
        }

        private void ChatButton_Click(object sender, MouseButtonEventArgs e)
        {
            MainFrame.Navigate(new ChatBoxPage());
        }
    }
}
