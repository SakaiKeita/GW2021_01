﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        BookSearcher.infosys202101DataSet infosys202101DataSet1;
        BookSearcher.infosys202101DataSetTableAdapters.LibrarySercherTableAdapter infosys202101DataSetLibrarySercherTableAdapter;
        System.Windows.Data.CollectionViewSource ViewSource;
        public MainWindow() {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            if(PassWord.Text == "a") {
                Window1 sw = new Window1();
                this.Close();
                sw.ShowDialog();
                
            } else {

                MessageBox.Show("パスワードが間違っています。");

            }
        }
 
        private void Resetbutton_Click(object sender, RoutedEventArgs e) {
            PassWord.Clear();
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e) {
            PassWord.Text = "";
        }
    }
}
