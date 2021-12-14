using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Search_System {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            Bitmap bitmap = new Bitmap(@"\Users\infosys\source\repos\SakaiKeita\OOP2021\Library\library system\20E58PIC2ie53eT027d5c_PIC2018.jpg");

            this.BackgroundImage = bitmap;                  // 背景画像
            this.BackgroundImageLayout = ImageLayout.Tile;  // 配置
        }

        private void button1_Click(object sender, EventArgs e) {
            if(textBox1.Text == "abcde") {
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
            } else {

                MessageBox.Show("パスワードが間違っています。");

            }
        }

        private void Resetbutton_Click(object sender, EventArgs e) {
            textBox1.ResetText();
        }
    }
}
