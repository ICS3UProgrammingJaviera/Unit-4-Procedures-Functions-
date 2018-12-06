/*
 * Created by: Javiera Diaz
 * Created on: 27/11/18
 * Created for: ICS3U Programming
 * Daily Assignment – Day #33 - Percentage Program
 * This program takes the input level from the user and displays equivalent mark in percentage.
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

namespace PercentageProgJav
{
    public partial class frmPercentageProgJav : Form
    {
        public frmPercentageProgJav()
        {
            InitializeComponent();
        }
        //Function: COnvertToPercent
        //Input: string level
        //Output: int percentage
        //Description: this function takes the input argument of the user which is the usersLevel and then returns it's equivalent percentage mark.
        private int ConvertToPercent(String level)
        {
            //declare local varuiable
            int percentage;

            //use swutch statment to convert users level to equivalent percentage
            switch(level)
            {
                case "4++":
                    percentage = 98;
                    break;
                case "4+":
                    percentage = 95;
                    break;
                case "4":
                    percentage = 87;
                    break;
                case "4-":
                    percentage = 83;
                    break;
                case "3+":
                    percentage = 78;
                    break;
                case "3":
                    percentage = 75;
                    break;
                case "3-":
                    percentage = 72;
                    break;
                case "2+":
                    percentage = 68;
                    break;
                case "2":
                    percentage = 65;
                    break;
                case "2-":
                    percentage = 62;
                    break;
                case "1+":
                    percentage = 58;
                    break;
                case "1":
                    percentage = 55;
                    break;
                case "1-":
                    percentage = 52;
                    break;
                case "0+":
                    percentage = 45;
                    break;
                case "0":
                    percentage = 40;
                    break;
                case "0-":
                    percentage = 35;
                    break;
                case "0--":
                    percentage = 30;
                    break;
                case "0---":
                    percentage = 20;
                    break;
                default:
                    percentage = 0;
                    break;
            }

            //return the procedure
            return percentage;
        }
        private void frmPercentageProgJav_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculatePercent_Click(object sender, EventArgs e)
        {
            //declare and assign local variables
            int userPrecentage;
            String usersLevel = this.txtUsersGrade.Text;

            //conduct error checking for an empty textbox, display a message box
            if (usersLevel == "")
            {
                MessageBox.Show("Please enter a mark");
            }
            //call the function and display a message box with the users mark and equivalent percentage mark.
            else
            {
                userPrecentage = ConvertToPercent(usersLevel);
                MessageBox.Show(usersLevel + " is equal to " + userPrecentage + "%");
            }

        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            //close the program
            this.Close();
        }
    }
}
