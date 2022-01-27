using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Defualt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void but_0_click(object sender, EventArgs e)
        {
            if (textBox.Text == "0") textBox.Text = (sender as Button).Text;
            else textBox.Text += (sender as Button).Text;
        }

        public string mathOp; // Для математических операций
        public double nam1 = 0;
        private void MathOperationSelect(object sender, EventArgs e)
        {
            mathOp = (sender as Button).Text;
            nam1 = Convert.ToDouble(textBox.Text);
            textBox.Clear();
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            double num2 = Convert.ToDouble(textBox.Text);
            switch (mathOp)
            {
                case "+":
                    textBox.Text = (num2 + nam1).ToString();
                    break;
                case "-":
                    textBox.Text = (num2 - nam1).ToString();
                    break;
                case "/":
                    textBox.Text = (nam1 / num2).ToString();
                    break;
                case "*":
                    textBox.Text = (num2 * nam1).ToString();
                    break;
            }
        }
        private void elButton_Click(object sender, EventArgs e)
        {
            textBox.Text=textBox.Text.Substring(0, textBox.Text.Length - 1);
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (textBox.Text == "") textBox.Text = "0";
        }
    }
}
