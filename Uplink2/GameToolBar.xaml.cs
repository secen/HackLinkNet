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
using Uplink2.Properties;

namespace Uplink2 {
    /// <summary>
    /// Interaction logic for GameToolBar.xaml
    /// </summary>
    public partial class GameToolBar : UserControl {
        public GameToolBar() {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            SettingsPage.BackToMenu(sender,e);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) {
            SettingsPage.BackToSettings(sender,e);
        }
    }
}
