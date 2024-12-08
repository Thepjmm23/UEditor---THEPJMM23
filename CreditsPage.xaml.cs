using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace UEditorApp
{
    public partial class CreditsPage : Page
    {
        public CreditsPage()
        {
            InitializeComponent();
        }
        private void JoinDiscordButton_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://discord.gg/Qr4SEYuDy2") { UseShellExecute = true });
            MessageBox.Show("You have been invited to the official UEditor discord!");
        }
    }
}
