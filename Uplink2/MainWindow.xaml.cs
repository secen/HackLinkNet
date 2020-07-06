using System.Windows;

namespace Uplink2 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            frame.NavigationUIVisibility = System.Windows.Navigation.NavigationUIVisibility.Hidden;
            frame.Navigate(new MainPage());
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
        }
    }
}
