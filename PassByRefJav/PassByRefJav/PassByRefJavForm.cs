/*
 * Created by: Javiera Diaz
 * Created on: Day-Month-Year
 * Created for: ICS3U Programming
 * Daily Assignment – Day #31 - Rounding Program
 * This program takes the inputed decimal the use gives and rounds it the number of decimal places that the user selects from the numeric-up-down box
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassByRefJav
{
    public partial class frmPassByRefJav : Form
    {
        public frmPassByRefJav()
        {
            InitializeComponent();
        }
        //Procedure: Round Decimals
        //Input: usersNum, usersNumDec
        //Ouput: usersNum rounded to usersNumDec places
        //Description: takes users decimal number and rounds it to the amount of places selected by user
        private void RoundDecimals(ref double usersDecimal, int usersChoiceDecimal)
        {

            //round the users number to the amount of decimal places selected
            usersDecimal = usersDecimal * Math.Pow(10, usersChoiceDecimal);
            usersDecimal = usersDecimal + 0.5;
            usersDecimal = Math.Truncate(usersDecimal);
            usersDecimal = usersDecimal / Math.Pow(10, usersChoiceDecimal);

            //display the rounded number in a message box
            MessageBox.Show("The rounded decimal is " + usersDecimal);
            
        }

        private void frmPassByRefJav_Load(object sender, EventArgs e)
        {

        }

        private void btnRound_Click(object sender, EventArgs e)
        {
            double usersNum;
            int usersNumDec;

            usersNum = Convert.ToDouble(txtUsersDec.Text);
            usersNumDec = Convert.ToInt16(nudUsersChoiceDec.Value);

            this.RoundDecimals(ref usersNum, usersNumDec);
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
