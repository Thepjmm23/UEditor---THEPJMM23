using System.Windows;
using System.Windows.Controls;

namespace UEditorApp
{
    public partial class InstallPage : Page
    {
        public InstallPage()
        {
            InitializeComponent();
        }

        // Install button functionality
        private void InstallButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Install button clicked!");
        }
    }
}
