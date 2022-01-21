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

            textBox.Text += (sender as Button).Text;
        }

        public string mathOp; // Для математических операций

        private void MathOperationSelect(object sender, EventArgs e)
        {
            
        }
    }
}
