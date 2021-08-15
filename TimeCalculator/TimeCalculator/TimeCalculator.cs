using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeCalculator
{
    public partial class TimeCalculator : Form
    {
        public TimeCalculator()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            int seconds;
            int minutes;
            int hours;
            int days;

            if (int.TryParse(secondsTextBox.Text, out seconds)) 
            {
                days = (seconds / 86400);
                displayDayLabel.Text = days.ToString();
                seconds %= 86400;

                hours = seconds / 3600;
                displayHoursLabel.Text = hours.ToString();
                seconds %= 3600;

                minutes = seconds  / 60;
                displayMinutesLabel.Text = minutes.ToString();

                seconds %= 60;
                displaySecondsLabel.Text = seconds.ToString();
            }           
            else
            {
                MessageBox.Show("Enter a whole number only");
                secondsTextBox.Text = "";
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            displayDayLabel.Text = "";
            displayHoursLabel.Text = "";
            displayMinutesLabel.Text = "";
            displaySecondsLabel.Text = "";
        }
    }
}
