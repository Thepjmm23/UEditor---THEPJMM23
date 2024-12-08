using System.Windows;

namespace UEditorApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // Load the Home page by default
            MainFrame.Navigate(new HomePage());
        }

        // Navigate to HomePage when "Home" is clicked
        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new HomePage());
        }

        // Navigate to InstallPage when "Install" is clicked
        private void InstallButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new InstallPage());
        }
    }
}
