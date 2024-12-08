using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace UEditorApp
{
    public partial class ChatBoxPage : Page
    {
        private string _messagesFilePath = "chatMessages.txt"; // File where messages are saved

        public ChatBoxPage()
        {
            InitializeComponent();
            LoadMessages();
        }

        // Load the chat messages from the file
        private void LoadMessages()
        {
            if (File.Exists(_messagesFilePath))
            {
                var messages = File.ReadAllLines(_messagesFilePath);
                foreach (var message in messages)
                {
                    ChatMessagesPanel.Children.Add(new TextBlock { Text = message });
                }
            }
        }

        // Send the message when the "Send" button is clicked
        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
            string message = MessageTextBox.Text;
            if (!string.IsNullOrEmpty(message))
            {
                AddMessageToChat(message);
                SaveMessage(message);
                MessageTextBox.Clear();
            }
        }

        // Handle Enter key press to send the message
        private void MessageTextBox_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Enter)
            {
                SendButton_Click(sender, e);
            }
        }

        // Add a new message to the chat panel
        private void AddMessageToChat(string message)
        {
            Dispatcher.Invoke(() =>
            {
                ChatMessagesPanel.Children.Add(new TextBlock { Text = message });
                ChatScrollViewer.ScrollToBottom(); // Auto-scroll to the latest message
            });
        }

        // Save the message to a file
        private void SaveMessage(string message)
        {
            try
            {
                // Append the message to the file
                File.AppendAllText(_messagesFilePath, message + Environment.NewLine);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving message: " + ex.Message);
            }
        }
    }
}
