using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pay_and_Bonus
{
    public partial class PayAndBonus : Form
    {
        // constant field for the contribution rate that will be used
        public const decimal CONTRIB_RATE = .05m;

        public PayAndBonus()
        {
            InitializeComponent();
        }

        public bool InputIsValid(ref decimal pay, ref decimal bonus)
        {
            bool inputGood = false;

            // grossPayTextBox.Text = pay.ToString();
           // bonusTextBox.Text = bonus.ToString();

            if (decimal.TryParse(grossPayTextBox.Text, out pay))
               if (decimal.TryParse(bonusTextBox.Text, out bonus))
               {
                    inputGood = true;
               }
               else
               {
                    MessageBox.Show("Bonus amount is invalid.");
               }
            else
            {
                MessageBox.Show("Gross amount is invalid.");
            }

            return inputGood;
        }

        public void CalculateButton_Click(object sender, EventArgs e)
        {
            decimal pay = 0m, bonus = 0m, contributions = 0m;

            if (InputIsValid(ref pay, ref bonus))
            {
                contributions = (pay + bonus) * CONTRIB_RATE;



                contributionLabel.Text = contributions.ToString("c");
            }
        }
        

    private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
