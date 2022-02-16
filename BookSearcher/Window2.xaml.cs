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
    /// Window2.xaml の相互作用ロジック
    /// </summary>
    public partial class Window2 : Window {
        BookSearcher.infosys202101DataSet infosys202101DataSet1;
        BookSearcher.infosys202101DataSetTableAdapters.LibrarySercherTableAdapter infosys202101DataSetLibrarySercherTableAdapter;
        System.Windows.Data.CollectionViewSource ViewSource;
        
        public Window2() {
            InitializeComponent();
        }
        //private void Window_Loaded_1(object sender, RoutedEventArgs e) {

        //    BookSearcher.infosys202101DataSet infosys202101DataSet = ((BookSearcher.infosys202101DataSet)(this.FindResource("infosys202101DataSet")));
        //    // テーブル LibrarySercher にデータを読み込みます。必要に応じてこのコードを変更できます。
        //    BookSearcher.infosys202101DataSetTableAdapters.LibrarySercherTableAdapter infosys202101DataSetLibrarySercherTableAdapter = new BookSearcher.infosys202101DataSetTableAdapters.LibrarySercherTableAdapter();
        //    infosys202101DataSetLibrarySercherTableAdapter.Fill(infosys202101DataSet.LibrarySercher);
        //    System.Windows.Data.CollectionViewSource librarySercherViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("librarySercherViewSource")));
        //    librarySercherViewSource.View.MoveCurrentToFirst();
        //
        private void Window_Loaded(object sender, RoutedEventArgs e) {

            infosys202101DataSet1 = ((BookSearcher.infosys202101DataSet)(this.FindResource("infosys202101DataSet")));
            //// テーブル CarReport にデータを読み込みます。必要に応じてこのコードを変更できます。
            infosys202101DataSetLibrarySercherTableAdapter = new BookSearcher.infosys202101DataSetTableAdapters.LibrarySercherTableAdapter();
            infosys202101DataSetLibrarySercherTableAdapter.Fill(infosys202101DataSet1.LibrarySercher);
            ViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("ViewSource")));
            ViewSource.View.MoveCurrentToFirst();
        }
        private void btback_Click(object sender, RoutedEventArgs e) {
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e) {
            tbTitle.Text = "";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e) {
            tbAuthor.Text = "";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e) {
            tbPbulisher.Text = "";
        }   

        private void TitleSerch(object sender, RoutedEventArgs e) {
            this.infosys202101DataSetLibrarySercherTableAdapter.FillByTitle(this.infosys202101DataSet1.LibrarySercher, tbTitle.Text);
        }

        private void AuthorSerch(object sender, RoutedEventArgs e) {
            this.infosys202101DataSetLibrarySercherTableAdapter.FillByAuthor(this.infosys202101DataSet1.LibrarySercher, tbAuthor.Text);
        }

        private void PublisherSerch(object sender, RoutedEventArgs e) {
            this.infosys202101DataSetLibrarySercherTableAdapter.FillByPublisher(this.infosys202101DataSet1.LibrarySercher, tbPbulisher.Text);
        }

       
    }
}
