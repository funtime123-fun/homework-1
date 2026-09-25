using System.Diagnostics;
using System.Windows;

namespace CustomDock
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            // Привязываем док к нижней части экрана
            this.Left = (SystemParameters.PrimaryScreenWidth - this.Width) / 2;
            this.Top = SystemParameters.PrimaryScreenHeight - this.Height - 20;
        }

        private void OpenBrowser(object sender, RoutedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("cmd", "/c start https://google.com") { CreateNoWindow = true });
        }

        private void OpenCode(object sender, RoutedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("cmd", "/c start vscode:") { CreateNoWindow = true });
        }

        private void OpenTelegram(object sender, RoutedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("cmd", "/c start tg:") { CreateNoWindow = true });
        }
    }
}