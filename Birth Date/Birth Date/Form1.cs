using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Birth_Date
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void asdf_Click(object sender, EventArgs e)
        {

        }

        private void ShowDateButton_Click(object sender, EventArgs e)
        {
            //Declare a string variable
            string output;

            //Concatenate the input and build the output string.
            output = DayOfWeekTextBox.Text + ", " +
                NameOfMonthTextBox.Text + " " +
                DayOfMonthTextBox.Text + ", " +
                YearTextBox.Text;

            //Display the output string in the label control.
            DateOutputLabel.Text = output;
        }

        private void DateOutputLabel_Click(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            //Clear the TextBoxes.'
            DayOfWeekTextBox.Text = "";
            NameOfMonthTextBox.Text = "";
            DayOfMonthTextBox.Text = "";
            YearTextBox.Text = "";

            //Clear the dateOutputLabel
            DateOutputLabel.Text = "";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            //Close the form
            this.Close();
        }
    }
}
