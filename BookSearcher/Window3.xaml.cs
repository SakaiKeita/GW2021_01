using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
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
        System.Windows.Data.CollectionViewSource librarySercherViewSource;

        public Window3() {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {

            infosys202101DataSet = ((BookSearcher.infosys202101DataSet)(this.FindResource("infosys202101DataSet")));
            //// テーブル CarReport にデータを読み込みます。必要に応じてこのコードを変更できます。
            infosys202101DataSetLibrarySercherTableAdapter = new BookSearcher.infosys202101DataSetTableAdapters.LibrarySercherTableAdapter();
            infosys202101DataSetLibrarySercherTableAdapter.Fill(infosys202101DataSet.LibrarySercher);
            librarySercherViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("librarySercherViewSource")));
            librarySercherViewSource.View.MoveCurrentToFirst();
           
        }
        private void btback_Click(object sender, RoutedEventArgs e) {
            this.Close();
        }

        //private void Window_Loaded_1(object sender, RoutedEventArgs e) {

        //    BookSearcher.infosys202101DataSet infosys202101DataSet = ((BookSearcher.infosys202101DataSet)(this.FindResource("infosys202101DataSet")));
        //    // テーブル LibrarySercher にデータを読み込みます。必要に応じてこのコードを変更できます。
        //    BookSearcher.infosys202101DataSetTableAdapters.LibrarySercherTableAdapter infosys202101DataSetLibrarySercherTableAdapter = new BookSearcher.infosys202101DataSetTableAdapters.LibrarySercherTableAdapter();
        //    infosys202101DataSetLibrarySercherTableAdapter.Fill(infosys202101DataSet.LibrarySercher);
        //    System.Windows.Data.CollectionViewSource librarySercherViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("librarySercherViewSource")));
        //    librarySercherViewSource.View.MoveCurrentToFirst();
        //}
        private void librarySercherDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e) {


            //DataRowView dr = (DataRowView)librarySercherViewSource.View.CurrentItem;
            //Memo.Text = dr[5].ToString();
           
        }
        private void btDelete_Click(object sender, RoutedEventArgs e) {

            try {
                DataRowView drv = (DataRowView)librarySercherViewSource.View.CurrentItem;
                //選択されたレコードの削除

                drv.Delete();

                //データベース更新
                infosys202101DataSetLibrarySercherTableAdapter.Update(infosys202101DataSet.LibrarySercher);
            }
            catch(Exception ex) {
                // 例外が発生した時の処理
                MessageBox.Show("この操作はできません");
            }

        }
       
        private void librarySercherDataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e) {
            DataRowView dr = (DataRowView)librarySercherViewSource.View.CurrentItem;
            Memo.Text = dr[5].ToString();

        }
    }
}
