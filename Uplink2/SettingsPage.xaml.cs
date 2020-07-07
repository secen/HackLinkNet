using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Uplink2 {
    /// <summary>
    /// Interaction logic for SettingsPage.xaml
    /// </summary>
    public partial class SettingsPage : Page {
        public SettingsPage() {
            InitializeComponent();
        }
        public static void Navigate(object content) {
            MainWindow window = (MainWindow)Application.Current.MainWindow;
            window.frame.Navigate(content);
        }
        public static void BackToSettings(object sender, RoutedEventArgs e) {
            MainWindow window = (MainWindow)Application.Current.MainWindow;
            window.frame.Navigate(new SettingsPage());
        }
        public static void BackToMenu(object sender, RoutedEventArgs e) {
            MainWindow window = (MainWindow)Application.Current.MainWindow;
            window.frame.Navigate(new MainPage());
        }
    }
}
