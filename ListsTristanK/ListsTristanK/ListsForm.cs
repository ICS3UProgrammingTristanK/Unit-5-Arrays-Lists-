/*
 * Created by: Tristan Kalabric
 * Created on: December 5, 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #37 - Find Max Value
 * This program calculates the average of all the numbers the user enters in a text box and displays it to them
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

namespace ListsTristanK
{
    public partial class frmLists : Form
    {
        //Create a list
        List<int> myListOfIntegers = new List<int>();

        //Declare global variable
        int numberOfEntries = 0;

        public frmLists()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {

            //Declare local variables
            int userMark = -1;

            //Convert the value in the textbox to an integer
            try
            {
                userMark = int.Parse(txtMark.Text);
            }
            //If the user did not enter a valid number, write the error to the command line
            catch (Exception parseError)
            {
                Console.WriteLine("An error occurred: '{0}'", parseError);
            }

            //Check if the user entered a number between 0 and 100
            if ((userMark >= 0) && (userMark <= 100))
            {
                //Add the mark to the listbox
                this.lstNumbers.Items.Add(userMark);

                //Add the mark to the list
                myListOfIntegers.Add(userMark);

                //Increment numberOfEntries
                numberOfEntries = numberOfEntries + 1;
            }

            //Otherwise, display an error
            else
            {
                MessageBox.Show("Please enter a number between 0 and 100.", "Invalid Number");
            }

        }

        private int CalculateAverage(ref int total)
        {
            //Declare variables
            int userAverage;
            int userTotal;

            //Get the userTotal
            userTotal = myListOfIntegers.Sum();

            //Calculate the average
            userAverage = userTotal / numberOfEntries;

            //Return the userAverage
            return userAverage;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //declare variables
            int total = 0;
            int average;

            //Get the average
            average = this.CalculateAverage(ref total);

            //Display average to user
            lblAverage.Text = "Average: " + average;
        }
    }
}
