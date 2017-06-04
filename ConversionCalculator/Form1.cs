using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ConversionCalculator
{
    public partial class Form1 : Form
    {
        private const int DecimalPlaces = 4;

        public Form1()
        {
            InitializeComponent();
        }

        private void ClearInput(object sender, EventArgs e)
        {
            inputTextBox.Text = "";
        }

        private void DeleteLastDigit(object sender, EventArgs e)
        {
            inputTextBox.Text = inputTextBox.Text.Remove(inputTextBox.Text.Length - 1);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ftToInchButton_Click(object sender, EventArgs e)
        {
            var input = Convert.ToDecimal(inputTextBox.Text);
            var result = decimal.Round(input * 12, DecimalPlaces, MidpointRounding.AwayFromZero);

            outputTextBox.Text = result.ToString();
            inputTextBox.Focus();
        }

        private void inchToFtButton_Click(object sender, EventArgs e)
        {
            var input = Convert.ToDecimal(inputTextBox.Text);
            var result = decimal.Round(input / 12, DecimalPlaces, MidpointRounding.AwayFromZero);

            outputTextBox.Text = result.ToString();
            inputTextBox.Focus();
        }

        private void mmToInch_Click(object sender, EventArgs e)
        {
            var input = Convert.ToDecimal(inputTextBox.Text);
            var result = Math.Round(input / 25.4m, DecimalPlaces, MidpointRounding.AwayFromZero);

            outputTextBox.Text = result.ToString();
            inputTextBox.Focus();
        }

        private void inchToMmButton_Click(object sender, EventArgs e)
        {
            var input = Convert.ToDecimal(inputTextBox.Text);
            var result = Math.Round(input * 25.4m, DecimalPlaces, MidpointRounding.AwayFromZero);

            outputTextBox.Text = result.ToString();
            inputTextBox.Focus();
        }

        private void sqInToSqFtButton_Click(object sender, EventArgs e)
        {
            var input = Convert.ToDouble(inputTextBox.Text);
            var result = Math.Round(Math.Pow(input,2) / Math.Pow(12,2), DecimalPlaces, MidpointRounding.AwayFromZero);

            outputTextBox.Text = result.ToString();
            inputTextBox.Focus();
        }

        private void sqFtToSqInButton_Click(object sender, EventArgs e)
        {
            var input = Convert.ToDouble(inputTextBox.Text);
            var result = Math.Round(Math.Pow(input, 2) * Math.Pow(12, 2), DecimalPlaces, MidpointRounding.AwayFromZero);

            outputTextBox.Text = result.ToString();
            inputTextBox.Focus();
        }

        private void sqCmToSqFtButton_Click(object sender, EventArgs e)
        {
            var input = Convert.ToDouble(inputTextBox.Text);
            var result = Math.Round(Math.Pow(input, 2) / Math.Pow(30.48d, 2), DecimalPlaces, MidpointRounding.AwayFromZero);

            outputTextBox.Text = result.ToString();
            inputTextBox.Focus();
        }

        private void sqFtToSqCmButton_Click(object sender, EventArgs e)
        {
            var input = Convert.ToDouble(inputTextBox.Text);
            var result = Math.Round(Math.Pow(input, 2) * Math.Pow(30.48d, 2), DecimalPlaces, MidpointRounding.AwayFromZero);

            outputTextBox.Text = result.ToString();
            inputTextBox.Focus();
        }

        private void AddToInput(object sender, EventArgs e)
        {
            inputTextBox.Text += (sender as Button).Text;
        }

        private void InputValidation(object sender, EventArgs e)
        {
            List<Button> buttons = new List<Button>();
            foreach (Button button in this.Controls.OfType<Button>())
            {
                if (button.Tag?.ToString() == "Calculate")
                {
                    buttons.Add(button);
                }
            }

            foreach (Button b in buttons)
            {
                b.Enabled = (inputTextBox.Text.Length > 0);
            }
        }
    }
}