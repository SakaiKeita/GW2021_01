using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace BookSearcher {
    /// <summary>
    /// Window4.xaml の相互作用ロジック
    /// </summary>
    public partial class Window4 : Window {







        public Window4() {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            Window1 sw = new Window1();
            sw.Show();
            this.Hide();
        }


        private void Button_Click_1(object sender, RoutedEventArgs e) {
            //  int a = int.Parse(tbISBN.Text);
            string a = tbISBN.Text;
            var reslut = Title_Click(a);
            foreach(var item in reslut) {
                tbTitle.Text = item;
          
            }
           
            var author = Author_Click(a);
            foreach(var items in author) {
                tbAuthor.Text = items;

            }

            var publisher = Publisher_Click(a);
            foreach(var itemsa in publisher) {
               tbPublisher.Text = itemsa;

            }
        }

    




    
    private static IEnumerable<string> Publisher_Click(string c) {
            using(var wc = new WebClient()) {
                wc.Headers.Add("Content-type", "charset=UTF-8");
                var uriString = string.Format(@"https://iss.ndl.go.jp/api/opensearch?isbn={0}", c);
                var url = new Uri(uriString);
                var stream = wc.OpenRead(url);

                XDocument xdoc = XDocument.Load(stream);
                var Author = xdoc.Root.Descendants("publisher");
                foreach(var Authors in Author) {


                    string s = Regex.Replace(Authors.Value, ":", "");

                    yield return s;
                }
            }
        }
            private static IEnumerable<string> Author_Click(string b) {
            using(var wc = new WebClient()) {
                wc.Headers.Add("Content-type", "charset=UTF-8");
                var uriString = string.Format(@"https://iss.ndl.go.jp/api/opensearch?isbn={0}", b);
                var url = new Uri(uriString);
                var stream = wc.OpenRead(url);

                XDocument xdoc = XDocument.Load(stream);              
                var Author = xdoc.Root.Descendants("author");
                foreach(var Authors in Author) {


                    string s = Regex.Replace(Authors.Value, ":", "");

                    yield return s;
                }
            }
        }
                private static IEnumerable<string> Title_Click(string a) {
            using(var wc = new WebClient()) {
                wc.Headers.Add("Content-type", "charset=UTF-8");
                var uriString = string.Format(@"https://iss.ndl.go.jp/api/opensearch?isbn={0}", a);
                var url = new Uri(uriString);
                var stream = wc.OpenRead(url);

                XDocument xdoc = XDocument.Load(stream);
                var nodes = xdoc.Root.Descendants("title");
               
                foreach(var node in nodes) {


                    string s = Regex.Replace(node.Value, ":", "");

                    yield return s;
                }


            }
        }

      
    }
}