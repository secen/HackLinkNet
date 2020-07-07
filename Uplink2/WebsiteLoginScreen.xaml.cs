using NUnit.Framework.Constraints;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace Uplink2 {
    /// <summary>
    /// Interaction logic for WebsiteLoginScreen.xaml
    /// </summary>
    public partial class WebsiteLoginScreen : Page {
        Website associatedWebsite;

        public WebsiteLoginScreen() {
            InitializeComponent();
        }

        public WebsiteLoginScreen(DebugWebsite debugWebsite) {
            InitializeComponent();
            this.associatedWebsite = debugWebsite;
            this.webTitle.Content = associatedWebsite.name;
        }

        public void login() {
            foreach(User usr in associatedWebsite.users) {
                if (usr.name == this.loginScreen.usernameBox.Text && usr.password == this.loginScreen.passwordBox.Text) {
                    associatedWebsite.tryLogin(usr);
                }
            }
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e) {
            SettingsPage.BackToMenu(sender,e);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) {
            MainWindow window = (MainWindow)Application.Current.MainWindow;
            window.frame.Navigate(new SettingsPage());
        }
    }
}
