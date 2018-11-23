/*
 * Created by: Javiera Diaz
 * Created on: Day-Month-Year
 * Created for: ICS3U Programming
 * Daily Assignment – Day #32 - Address Program
 * This program 
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

namespace OptParaJav
{
    public partial class frmOptParaJav : Form
    {
        public frmOptParaJav()
        {
            InitializeComponent();
        }
        //Procedure: DisplayAddress
        //Input: String address, province, postalCode, city, unitNum
        //Output: void
        //Description: This procedure displays a message box with the entire address the user inputs, including the unitNum.
        private void DisplayAddress(String address, String province, String postalCode, String city, String unitNum)
        {
            MessageBox.Show("Your address is:" + address + ", " + province + ", " + city + " "  + postalCode + ", " + "Unit # " + unitNum);
        }
        //Procedure: DisplayAddress
        //Input: String address, provinnce, city, postal code
        //Output: void
        //Description: This procedure displays a message box with the arguments input by the user: city, address, province, postalCode. Does not include unitNum.
        private void DisplayAddress(String address, String province, String postalCode, String city)
        {
            MessageBox.Show("Your address is:" + address + province + city + postalCode);
        }
        private void frmOptParaJav_Load(object sender, EventArgs e)
        {

        }

        private void btnEnterAddress_Click(object sender, EventArgs e)
        {
            //declare local variables
            String usersAddress, usersCity, usersProvince, usersPostalCode, usersUnitNum;

            //get variables from textboxes and assign them
            usersAddress = this.txtAddress.Text;
            usersCity = this.txtCity.Text;
            usersPostalCode = this.txtPostalCode.Text;
            usersProvince = this.txtProvince.Text;
            usersUnitNum = this.txtUnitNum.Text;

            //check that user entered address
            if (usersAddress == "")
            {
                MessageBox.Show("Please enter your address.", "Display Address Program");
            }
            else if (usersCity == "")
            {
                MessageBox.Show("Please enter your city.", "Dispplay Address Program");
            }
            else if (usersProvince == "")
            {
                MessageBox.Show("Please enter your province.", "Display Address Program");
            }
            else if (usersPostalCode == "")
            {
                MessageBox.Show("Please enter your postal code.", "Display Address Program");
            }
            else if (usersUnitNum == "")
            {
                DisplayAddress(usersAddress , usersProvince , usersCity , usersPostalCode);
            }
            else
            {
                DisplayAddress(usersAddress, usersProvince, usersCity, usersPostalCode, usersUnitNum);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
