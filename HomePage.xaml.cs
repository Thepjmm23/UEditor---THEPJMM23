using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace UEditorApp
{
    public partial class HomePage : Page
    {
        public HomePage()
        {
            InitializeComponent();
        }

        // Open Discord link when button is clicked
        private void JoinDiscordButton_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://discord.gg/Qr4SEYuDy2") { UseShellExecute = true });
        }
    }
}
