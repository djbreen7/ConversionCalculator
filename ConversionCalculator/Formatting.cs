using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversionCalculator
{
    class Formatting : Form1
    {
        private void AddToInput(object sender, EventArgs e)
        {
            string s = (sender as Button).Text;
            inputTextBox.Text += s;

            inputTextBox.Focus();
            inputTextBox.Select(inputTextBox.Text.Length, inputTextBox.Text.Length);
        }
    }
}
