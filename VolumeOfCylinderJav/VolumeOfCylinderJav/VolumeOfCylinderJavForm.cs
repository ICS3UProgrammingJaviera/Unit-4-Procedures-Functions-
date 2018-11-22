/*
 * Created by: Javiera Diaz
 * Created on: 11-11-18
 * Created for: ICS3U Programming
 * Daily Assignment – Day #33 - Volume of a Cylinder
 * This program takes the argument radius and height given by the user and calculates the voloume by calling the CalculateVolume function.
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

namespace VolumeOfCylinderJav
{
    public partial class frmVolumeOfCylinderJav : Form
    {
        public frmVolumeOfCylinderJav()
        {
            InitializeComponent();
        }
        //Function: CalculateVolume
        //Input: double usersRadius, usersHeight
        //Output: volume
        //Description: This function takes the user's radius and height then calculates them and returns the double
        private double CalculateVolume(double usersRadius, double usersHeight)
        {
            //declare volume variable as double
            double volume;

            //calculate volume
            volume = Math.PI * (Math.Pow(usersRadius, 2)) * usersHeight;

            //return the volume
            return volume;

        }
        private void frmVolumeOfCylinderJav_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //declare local variables
            double radius, height, volume;

            //assign variables a value from textbox
            height = Double.Parse(txtEnterHeight.Text);
            radius = Double.Parse(txtEnterRadius.Text);

            //call the CalculateVolume function
            volume = CalculateVolume(radius, height);

            //round to volume to nearest hundredth
            volume = Math.Round(volume, 2);

            //display a messagebox with the answer
            MessageBox.Show("The volume of this cylinder is " + volume);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //close the program
            this.Close();
        }
    }
}
