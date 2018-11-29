/*
 * Created by: Tristan Kalabric
 * Created on: november 29, 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #36 - Introduction to Arrays
 * This program generates 10 random numbers between 1 and 10 and calculates the average of all the numbers.
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

namespace ArrayAverageTristanK
{
    public partial class frmArrayAverage : Form
    {
        //Declare global variables and constants
        const int MAX_ARRAY_SIZE = 10;
        int[] arrayOfNumbers = new int[MAX_ARRAY_SIZE];

        public frmArrayAverage()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Declare local variables
            int randomNumber;
            int counter;
            Random randomNumberGenerator = new Random();

            //Clear list box
            this.lstNumbers.Items.Clear();

            for (counter = 0; counter < MAX_ARRAY_SIZE; counter++)
            {
                //Generate a new random number between 1 and the MAX_ARRAY_SIZE
                randomNumber = randomNumberGenerator.Next(1, MAX_ARRAY_SIZE + 1);

                //Assign the random number to the cell at position "counter" in the array
                arrayOfNumbers[counter] = randomNumber;

                //Add the random number to the list
                this.lstNumbers.Items.Add(randomNumber);

                //Refresh the form to display the new item in the list box
                this.Refresh();
            }
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            //Declare local variables
            double average = 0;
            double sum = 0;
            int counter;

            //Calculate the sum of all the values in the array
            for (counter = 0; counter < arrayOfNumbers.Length; counter++)
            {
                sum = sum + arrayOfNumbers[counter];
            }
            //Calculate the average of the values int the array
            average = sum / arrayOfNumbers.Length;

            //Display the average in the label
            this.lblAverage.Text = "Average: " + average;
        }
    }
}
