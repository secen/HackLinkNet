using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Navigation;

namespace Uplink2 {
    /// <summary>
    /// Interaction logic for LoginScreen.xaml
    /// </summary>
    public partial class StartMenuLoginScreen : UserControl {
        public StartMenuLoginScreen() {
            InitializeComponent();
        }

        public DebugWebsite Website { get; set; } = new DebugWebsite();

        private void loginButton_Click(object sender, RoutedEventArgs e) {
            Website.tryLogin(new User { name = this.usernameBox.Text, password = passwordBox.Text });
            
            WebsiteLoginScreen login = Website.loginScreen;
            MainWindow window =(MainWindow)Application.Current.MainWindow;
            window.frame.Navigate(login);
        }
    }
}
