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
using System.Windows.Shapes;

namespace BookSearcher {
    /// <summary>
    /// Window3.xaml の相互作用ロジック
    /// </summary>
    public partial class Window3 : Window{
        BookSearcher.infosys202101DataSet infosys202101DataSet;
       BookSearcher.infosys202101DataSetTableAdapters.LibrarySercherTableAdapter infosys202101DataSetLibrarySercherTableAdapter;
        System.Windows.Data.CollectionViewSource LibrarySercherViewSource;



        public Window3() {
            InitializeComponent();
        }



        private void Window_Loaded(object sender, RoutedEventArgs e) {

            infosys202101DataSet = ((BookSearcher.infosys202101DataSet)(this.FindResource("infosys202101DataSet")));
            //// テーブル CarReport にデータを読み込みます。必要に応じてこのコードを変更できます。
            infosys202101DataSetLibrarySercherTableAdapter = new BookSearcher.infosys202101DataSetTableAdapters.LibrarySercherTableAdapter();
            infosys202101DataSetLibrarySercherTableAdapter.Fill(infosys202101DataSet.LibrarySercher);
            LibrarySercherViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource(" LibrarySercherViewSource")));
            LibrarySercherViewSource.View.MoveCurrentToFirst();
        }
        private void Button_Click(object sender, RoutedEventArgs e) {
            Window1 sw = new Window1();
            sw.Show();
            this.Hide();
        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e) {

            BookSearcher.infosys202101DataSet infosys202101DataSet = ((BookSearcher.infosys202101DataSet)(this.FindResource("infosys202101DataSet")));
            // テーブル LibrarySercher にデータを読み込みます。必要に応じてこのコードを変更できます。
            BookSearcher.infosys202101DataSetTableAdapters.LibrarySercherTableAdapter infosys202101DataSetLibrarySercherTableAdapter = new BookSearcher.infosys202101DataSetTableAdapters.LibrarySercherTableAdapter();
            infosys202101DataSetLibrarySercherTableAdapter.Fill(infosys202101DataSet.LibrarySercher);
            System.Windows.Data.CollectionViewSource librarySercherViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("librarySercherViewSource")));
            librarySercherViewSource.View.MoveCurrentToFirst();
        }
    }
}
