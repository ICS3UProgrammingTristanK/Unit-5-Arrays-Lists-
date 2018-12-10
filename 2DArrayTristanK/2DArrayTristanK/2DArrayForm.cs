using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2DArrayTristanK
{
    public partial class frm2DArray : Form
    {
        public frm2DArray()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //Declare local variables
            int width;
            int length;
            Random randomNumberGenerator = new Random();
            int aRandomNumber;
            string aPieceOfText = null;
            int widthCounter = 0;
            int lengthCounter;

            //Get the desired width and length from the user
            width = Convert.ToInt16(this.nudWidth.Value);
            length = Convert.ToInt16(this.nudLength.Value);

            //Declare the array with the desired width and length
            int[,] a2DArray = new int[width, length];

            //Loop through each element in the width
            for(lengthCounter = 0; widthCounter < width; widthCounter++)
            {
                //Loop through each element in the length
                for(lengthCounter = 0; lengthCounter < length; lengthCounter++)
                {
                    //Get a random number between 0 and 9
                    aRandomNumber = randomNumberGenerator.Next(0, 9 + 1);

                    //Insert the random number into the array and the current width and length
                    a2DArray[widthCounter, lengthCounter] = aRandomNumber;

                    //Add the random number to the string of array numbers
                    aPieceOfText = aPieceOfText + " " + aRandomNumber;
                }
                //Add a line breack to the end of the line to show a new row in the string
                aPieceOfText = aPieceOfText + "\r" + "\n";
            }
            //Insert the string into the textbox
            this.txtArray.Text = aPieceOfText;
        }
    }
}
