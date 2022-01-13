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

namespace BookSearcher {
    /// <summary>
    /// Window1.xaml の相互作用ロジック
    /// </summary>
    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
 
            Window2 sw = new Window2();
            sw.Show();
            this.Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) {
            Window3 sw = new Window3();
            sw.Show();
            this.Hide();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e) {
            Window4 sw = new Window4();
            sw.Show();
            this.Hide();
        }
    }
}
