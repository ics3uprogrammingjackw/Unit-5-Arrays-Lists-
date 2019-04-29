/*
 * Created by: Jack Wright 
 * Created on: 26-04-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #37 - Find Max Value
 * This program finds the max value of all the numbers in an array
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

namespace MaxArrayJackW
{
    public partial class frmMaxArray : Form
    {
        public frmMaxArray()
        {
            InitializeComponent();
        }

        private int GetMaxValue(int[] tmpArrayOfIntegers)
        {
            //declaring variables and constants
            int tmpMaxValue = 0;
            int counter;
            const int MAX_ARRAY_SIZE = 10;
            

            for (counter = 0; counter < MAX_ARRAY_SIZE; counter++)
            {

                if (tmpArrayOfIntegers[counter] > tmpMaxValue)
                {
                    //Sets the current max value to the current index if it is greater than the last max value
                    tmpMaxValue = tmpArrayOfIntegers[counter];
                }
            }

            //return the max value 
            return tmpMaxValue;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Declaring constants and variables
            const int MAX_ARRAY_SIZE = 10;
            const int MAX_RANDOM_NUMBER = 500;
            int[] arrayOfInt = new int[MAX_ARRAY_SIZE];
            int counter, randomNumber, maxValue;
            Random randomNumberGenerator = new Random();

            //Clears the listbox
            lstNumbers.Items.Clear();


            for (counter = 0; counter < MAX_ARRAY_SIZE; counter++)
            {
                //generate a random number
                randomNumber = randomNumberGenerator.Next(1, MAX_RANDOM_NUMBER + 1);

                //Setting the current index of the array to the generated number
                arrayOfInt[counter] = randomNumber;

                //Add the number to the listbox
                this.lstNumbers.Items.Add(randomNumber);

                //refresh the form
                this.Refresh();
                
            }

            //call the GetMaxValue function
            maxValue = GetMaxValue(arrayOfInt);

            //Display the max value
            lblMaxValue.Text = "The max value is: " + maxValue;

        }
    }
}
