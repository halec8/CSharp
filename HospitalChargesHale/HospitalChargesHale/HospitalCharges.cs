using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/***************************************************************
* Name        : HospitalChargeCalculatorHale
* Author      : Cody Hale
* Created     : 11/17/2019
* Course      : CIS 169 - C#
* Version     : 1.0
* OS          : Windows 10
* Copyright   : This is my own original work based on            *               specifications issued by our instructor
* Description : calculates and displays various hospital charges
*               Input:  days stayed
                        medication cost
                        surgical cost
                        lab cost
                        rehabilitation cost
*               Output: cost of days stayed
                        cost of misc charges
                        cost of total charges

* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or * * unmodified. I have not given other fellow student(s) access to * my program.         
***************************************************************/


namespace HospitalChargesHale
{

    /***************************************************************
* Name        : HospitalCharges
* Author      : Cody Hale
* Created     : 9/25/2019
***************************************************************/

    public partial class HospitalCharges : Form
    {
        // declares a constant for the base charge for each spent in the hospital.
        public const decimal DAILY_BASE_CHARGE = 350m;


        public HospitalCharges()
        {
            InitializeComponent();

        }

        /**************************************************************
* Name: CalcMiscCharges
* Description: value-returning method that stores various costs.
* Input: decimals.
         cost of meds.
         cost of surgical.
         cost of labs.
         cost of rehab.
* Output: total cost of the misc items.
***************************************************************/

        public decimal CalcMiscCharges(string
            meds, string surgical, string lab, string rehab)
        {

            decimal myMeds;
            decimal mySurgical;
            decimal myLab;
            decimal myRehab;

            var medsParse = decimal.TryParse(meds, out myMeds);
            var surgicalParse = decimal.TryParse(surgical, out mySurgical);
            var labParse = decimal.TryParse(lab, out myLab);
            var rehabParse = decimal.TryParse(rehab, out myRehab);

            if (medsParse && surgicalParse && labParse && rehabParse)
            {
                return myMeds + mySurgical + myLab + myRehab;
            }

            throw new ArgumentException("Enter valid input");
        }



        /**************************************************************
    * Name: CalcStayCharges
    * Description: value-returning method that stores the cost of however
               you spent in the hospital.
    * Input: decimal.
         number of days spent in the hospital.
    * Output: decimal in the form of currency.
          total cost of how many days spent in the hospital.
    ***************************************************************/

        public decimal CalcStayCharges(string days)

        {
            decimal myDays;

            var daysParse = decimal.TryParse(days, out myDays);
         
            if (daysParse)
            {
                return myDays * DAILY_BASE_CHARGE;
            }

            throw new ArgumentException("Enter valid input");

        }


        /**************************************************************
* Name: CalcTotalCharges
* Description: takes the total charges of each text box and calculates the sum.
* Input: decimals.
         days stayed
         medication charges.
         surgical charges.
         lab charges.
         rehabilitation charges.

* Output: The sum of all charges.
***************************************************************/


        public decimal CalcTotalCharges(string days, string meds, string surgical, string lab, string rehab)

        {
            decimal myDays;
            decimal myMeds;
            decimal mySurgical;
            decimal myLab;
            decimal myRehab;

            var daysParse = decimal.TryParse(days, out myDays);
            var medsParse = decimal.TryParse(meds, out myMeds);
            var surgicalParse = decimal.TryParse(surgical, out mySurgical);
            var labParse = decimal.TryParse(lab, out myLab);
            var rehabParse = decimal.TryParse(rehab, out myRehab);

            if (daysParse && medsParse && surgicalParse && labParse && rehabParse)
            {
                return (myDays * DAILY_BASE_CHARGE) + mySurgical + myLab + myRehab;
            }

            throw new ArgumentException("Enter valid input");


        }

        /**************************************************************
* Name: CalculateButton
* Description: Performs calculations that calls the methods and returns the value to each method.
               Then displays the cost per each method being called.
* Input: N/A all previous input is being called.
* Output: Displays the total cost of CalcTotalCharges, CalcMiscCharges and CalcStayCharges
         
***************************************************************/

        public void CalculateButton_Click(object sender, EventArgs e)
        {

            var medCharges = medChargesTextbox.Text;
            var surgicalCharges = surgicalChargeTextbox.Text;
            var labCharge = labFeeTextbox.Text;
            var physRehabCharge = physRehabTextbox.Text;
            var daysSpent = daysTextbox.Text;

            // get the sum of the total charges.

            var totalCharges = CalcTotalCharges(daysSpent, medCharges, surgicalCharges, labCharge,
                 physRehabCharge);

            totalChargeLabel.Text = totalCharges.ToString("c2");

            // get the sum of the total stay charges.

            var totalDays = CalcStayCharges(daysSpent);

            totalStayChargesLabel.Text = totalDays.ToString("c2");

            // get the sum of the total misc charges.

            var totalMisc = CalcMiscCharges(medCharges, surgicalCharges, labCharge, physRehabCharge);

            totalMiscChargesLabel.Text = totalMisc.ToString("c2");

        }

        /**************************************************************
* Name: ClearButton
* Description: clears the text boxes and refocuses.
***************************************************************/


        void ClearButton_Click(object sender, EventArgs e)
        {

            // clears the text boxes.

            daysTextbox.Text = String.Empty;
            medChargesTextbox.Text = String.Empty;
            surgicalChargeTextbox.Text = String.Empty;
            labFeeTextbox.Text = String.Empty;
            physRehabTextbox.Text = String.Empty;
            totalChargeLabel.Text = String.Empty;
            totalMiscChargesLabel.Text = String.Empty;
            totalStayChargesLabel.Text = String.Empty;

            // refocuses to the daysTextBox.
            daysTextbox.Focus();

        }

        /**************************************************************
* Name: ExitButton
* Description: closes the program.
* Output: Displays a message before closing the program.
***************************************************************/

        private void ExitButton_Click(object sender, EventArgs e)
        {
            // displays a message before the program closes.
            MessageBox.Show("Thank you for using the ''Hospital Charge Calculator!''");

            // closes the program.
            this.Close();

        }
    }
}
