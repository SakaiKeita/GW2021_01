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
    /// Window5.xaml の相互作用ロジック
    /// </summary>
    public partial class Window5 : Window {
      
        public Window5() {
            InitializeComponent();
        }
       
        private void Window_Loaded(object sender, RoutedEventArgs e) {

            BookSearcher.infosys202101DataSet infosys202101DataSet = ((BookSearcher.infosys202101DataSet)(this.FindResource("infosys202101DataSet")));
            // テーブル LibrarySercher にデータを読み込みます。必要に応じてこのコードを変更できます。
            BookSearcher.infosys202101DataSetTableAdapters.LibrarySercherTableAdapter infosys202101DataSetLibrarySercherTableAdapter = new BookSearcher.infosys202101DataSetTableAdapters.LibrarySercherTableAdapter();
            infosys202101DataSetLibrarySercherTableAdapter.Fill(infosys202101DataSet.LibrarySercher);
            System.Windows.Data.CollectionViewSource librarySercherViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("librarySercherViewSource")));
            librarySercherViewSource.View.MoveCurrentToFirst();
        }
    }
}
