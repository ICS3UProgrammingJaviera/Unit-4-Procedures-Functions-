/*
 * Created by: Javiera Diaz
 * Created on: Day-Month-Year
 * Created for: ICS3U Programming
 * Daily Assignment – Day #30 - Area Procedure
 * This program takes the users input of degrees celsius and converts it to degrees farneheit, then displays the converted degrees in a message box that pops up when the "Convert" button is clicked.
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

namespace ConvertToFaren_Jav_
{
    public partial class frmConvertToFarenJav : Form
    {
        public frmConvertToFarenJav()
        {
            InitializeComponent();
        }

        //Function: ConvertToFarenheit
        //Input: double celsius
        //Output: Farenheit
        //Description: This function takes the input of degrees celsius from the user and converts it to farenheit.
        public void ConvertToFarenheit(double celsius)
        {
            //declare all global variables
            double farenheit;

            //convert user's celsius to farneheit
            farenheit = (9 / 5) * celsius + 32;

            //display a message box with the converted degrees
            MessageBox.Show("The converted temperature is: " + farenheit + " degrees Farenheit");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //declare local variables
            double usersCelsius;

            //convert inout degrees celsius from a string to a double and assign to variable
            usersCelsius = Convert.ToDouble(this.txtUsersCelsius.Text);

            //call the fucntion to convert the useres input of degrees celsius to degrees farenheit
            this.ConvertToFarenheit(usersCelsius);
        }

        private void frmConvertToFarenJav_Load(object sender, EventArgs e)
        {

        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
