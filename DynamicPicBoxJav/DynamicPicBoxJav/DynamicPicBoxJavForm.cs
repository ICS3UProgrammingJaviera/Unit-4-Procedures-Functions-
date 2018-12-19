using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace DynamicPicBoxJav
{
    public partial class frmDynamicPicBoxJav : Form
    {
        public frmDynamicPicBoxJav()
        {
            InitializeComponent();
        }
        //Procedure:
        //Input:
        //Output:
        //Desc:
        private void GeneratePictureBoxes()
        {
            //generate these puicture boxes on these coordinates on the form
            GeneratePictureBox(61, 78);
            GeneratePictureBox(464, 78);
            GeneratePictureBox(61, 358);
            GeneratePictureBox(464, 358);
        }
        //Procedure:
        //Input:
        //Output:
        //Desc:
        private void PictureBox_Click(object sender, EventArgs e)
        {
            //cast sender object in picturebox
            PictureBox tmpPicMan = (PictureBox)sender;
            //write message to ocnsole to check when picture box was clicked
            Console.WriteLine("Picture box (" + tmpPicMan.Location.X + "," + tmpPicMan.Location.Y + "( was clicked");

            //declare contants and variables
            const byte MAX_FRAMES = 10;
            int pictureFrameCounter = 1;

            //continue loop while frame counter is less than the max that there is to display
            while (pictureFrameCounter < MAX_FRAMES + 1)
            {
                if (pictureFrameCounter == 1)
                {
                    tmpPicMan.Image = Properties.Resources.walk1;
                }
                else if (pictureFrameCounter == 2)
                {
                    tmpPicMan.Image = Properties.Resources.walk2;
                }
                else if (pictureFrameCounter == 3)
                {
                    tmpPicMan.Image = Properties.Resources.walk3;
                }
                else if (pictureFrameCounter == 4)
                {
                    tmpPicMan.Image = Properties.Resources.walk4;
                }
                else if (pictureFrameCounter == 5)
                {
                    tmpPicMan.Image = Properties.Resources.walk5;
                }
                else if (pictureFrameCounter == 6)
                {
                    tmpPicMan.Image = Properties.Resources.walk6;
                }
                else if (pictureFrameCounter == 7)
                {
                    tmpPicMan.Image = Properties.Resources.walk7;
                }
                else if (pictureFrameCounter == 8)
                {
                    tmpPicMan.Image = Properties.Resources.walk8;
                }
                else if (pictureFrameCounter == 9)
                {
                    tmpPicMan.Image = Properties.Resources.walk9;
                }
                else if (pictureFrameCounter == 10)
                {
                    tmpPicMan.Image = Properties.Resources.walk10;
                }
            }
        }
        //Procedure:
        //Input:
        //Output:
        //Desc:
        private void GeneratePictureBox(int x, int y)
        {
            //dymically generate a new picture box and a new point at the given location (x, y)
            PictureBox tmpPicMan = new PictureBox();
            Point pntPic = new System.Drawing.Point(x, y);

            //set locaton of picturebox
            tmpPicMan.Location = pntPic;

            //assign omage to picture box
            tmpPicMan.Image = Properties.Resources.walk1;

            //set picture box mode to stretch size
            tmpPicMan.SizeMode = PictureBoxSizeMode.StretchImage;

            //make picturebox width and height to be same as the image
            tmpPicMan.ClientSize = new Size(Properties.Resources.walk1.Width, Properties.Resources.walk1.Height);

            tmpPicMan.Click += new System.EventHandler(PictureBox_Click);
;
            //add picturebox to form
            this.Controls.Add(tmpPicMan);
        }
        private void frmDynamicPicBoxJav_Load(object sender, EventArgs e)
        {
            //hide this label
            this.lblInstructons.Hide();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //show this labe;
            this.lblInstructons.Show();
            //call this function to generate the 4 picture boxes
            GeneratePictureBoxes();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
