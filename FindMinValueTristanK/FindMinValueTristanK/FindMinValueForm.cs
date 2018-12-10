using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindMinValueTristanK
{
    public partial class frmFindMinValue : Form
    {

        //Declare global random number generator
        Random randomNumberGenerator;

        public frmFindMinValue()
        {
            InitializeComponent();
            //Create random object
            randomNumberGenerator = new Random();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Declare local variables and constants
            const int MAX_ARRAY_SIZE = 10;
            const int MAX_RANDOM_NUMBER = 500;
            int[] arrayOfIntegers = new int[MAX_ARRAY_SIZE];
            int counter, randomNumber, minValue;

            //Clear the listbox
            this.lstValues.Items.Clear();

            //Populating the array and listbox
            for (counter = 0; counter < MAX_ARRAY_SIZE; counter++)
            {
                //Generate a new random number between 1 and MAX_RANDOM_NUMBER
                randomNumber = randomNumberGenerator.Next(1, MAX_RANDOM_NUMBER + 1);

                //Assign the random number to the cell at position "counter" in the array
                arrayOfIntegers[counter] = randomNumber;

                //Add the random number to the listbox
                this.lstValues.Items.Add(randomNumber);

                //Refresh the form to display the new item in the listbox
                this.Refresh();
            }

            //Set the min value
            minValue = GetMinValue(arrayOfIntegers);

            //Display minValue in a label
            this.lblMinValue.Text = "The min value is: " + minValue;
        }

        private int GetMinValue (int[] tmpArrayOfIntegers)
        {
            int counter, tmpMinValue = 501;

            //Finding the smallest number in the array
            for(counter = 0; counter < tmpArrayOfIntegers.Length; counter++)
            {
                if(tmpArrayOfIntegers[counter] < tmpMinValue)
                {
                    tmpMinValue = tmpArrayOfIntegers[counter];
                }
            }
            return tmpMinValue;
        }
    }
}
