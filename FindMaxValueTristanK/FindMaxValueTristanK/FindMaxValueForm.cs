/*
 * Created by: Tristan Kalabric
 * Created on: December 3, 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #37 - Find Max Value
 * This program generates 10 random numbers from 1 to 500, then finds the biggest number and displays it in a label
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

namespace FindMaxValueTristanK
{
    public partial class frmFindMaxValue : Form
    {
        //Declare global random number generator
        Random randomNumberGenerator;

        public frmFindMaxValue()
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
            int counter, randomNumber, maxValue;
            

            //Clear listbox
            this.lstValue.Items.Clear();

            //Populating the array and listbox
            for (counter = 0; counter < MAX_ARRAY_SIZE; counter++)
            {
                //Generate a new random number between 1 and MAX_RANDOM_NUMBER
                randomNumber = randomNumberGenerator.Next(1, MAX_RANDOM_NUMBER + 1);

                //Assign the random number to the cell at position "counter" in the array
                arrayOfIntegers[counter] = randomNumber;

                //Add the random number to the listbox
                this.lstValue.Items.Add(randomNumber);

                //Refresh the form to display the new item in the listbox
                this.Refresh();

            }

            // Set the max value
            maxValue = this.GetMaxValue(arrayOfIntegers);

            //Display maxValue in a label
            this.lblMaxValue.Text = "The max value is: " + maxValue;
        }

        private int GetMaxValue(int[] tmpArrayOfIntegers)
        {
            int counter, tmpMaxValue = -1;

            //Finding the biggest number in the array
            for(counter = 0; counter < tmpArrayOfIntegers.Length; counter++)
            {
                if(tmpArrayOfIntegers[counter] > tmpMaxValue)
                {
                    tmpMaxValue = tmpArrayOfIntegers[counter];
                }
            }

            return tmpMaxValue;
        }
    }
}
