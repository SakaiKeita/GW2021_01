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
//9784774187587
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

            var publisher = Publisher_Click(tbISBN.Text);
            tbPublisher.Text = publisher;
        }


        private string Publisher_Click(string c) {
            
            using(var wc = new WebClient()) {
                wc.Headers.Add("Content-type", "charset=UTF-8");
                var uriString = string.Format(@"https://iss.ndl.go.jp/api/opensearch?isbn={0}", c);
                var url = new Uri(uriString);
                var stream = wc.OpenRead(url);

                XDocument xdoc = XDocument.Load(stream);
                var descriptions = xdoc.Root.Descendants("description");
                var Author = xdoc.Root.Descendants("author");
                var node = xdoc.Root.Descendants("title");
                foreach(var Authors in Author) {


                    string s = Regex.Replace(Authors.Value, ":", "");

                    tbAuthor.Text = s;
                }
                
                foreach(var nodes in node) {


                    string s = Regex.Replace(nodes.Value, ":", "");

                    tbTitle.Text = s;
                }
                int i = 0;
                foreach(var item in descriptions) {
                    string s = Regex.Replace(item.Value, "【¦】", "");
                    char[] separator = new char[] { ',', '<', '>' };
                    string[] splitted = s.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                    if(i == 0) {
                        i++;
                    } else {
                        c = splitted[1].ToString();
                        if(c.Length < 3) {
                            c = splitted[2].ToString();
                        }
                    }
                }
                return c;           
            }
        }
    }
}