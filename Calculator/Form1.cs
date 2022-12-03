using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void onNumClick(object sender, EventArgs e) {
            Button buttonPressed = (Button) sender;
            if (textBox.Text == "0" && buttonPressed.Text != ".") 
                textBox.Clear();
            textBox.Text = textBox.Text + buttonPressed.Text;
        }

        private void onBackspaceClick(object sender, EventArgs e)
        {
            if (textBox.Text == "")
                return;
            textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1,1);
        }
    }
}
