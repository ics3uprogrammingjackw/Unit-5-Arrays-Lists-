/*
 * Created by: Jack Wright 
 * Created on: 30-04-2019
 * Created for: ICS3U Programming
 * Daily Assignment – Day #38 - Find Min Value
 * This program finds the min value of all the numbers in an array
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
    public partial class frmMinArray : Form
    {
        public frmMinArray()
        {
            InitializeComponent();
        }

        private int GetMinValue(int[] tmpArrayOfIntegers)
        {
            //declaring variables and constants
            int tmpMinValue = 501;
            int counter = 0;
            

            foreach (double arrayValue in tmpArrayOfIntegers)
            {
                
                //If the current value in the array is less than the current minimum value 
                if (tmpArrayOfIntegers[counter] < tmpMinValue)
                {
                    //Sets the current min value to the current index if it is less than the last min value
                    tmpMinValue = tmpArrayOfIntegers[counter];
                }

                //Increment the counter 
                counter++;
            }

            //return the min value 
            return tmpMinValue;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Declaring constants and variables
            const int MAX_ARRAY_SIZE = 10;
            const int MAX_RANDOM_NUMBER = 500;
            int[] arrayOfInt = new int[MAX_ARRAY_SIZE];
            int counter, randomNumber, minValue;
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

            //call the GetMinValue function
            minValue = GetMinValue(arrayOfInt);

            //Display the min value
            lblMinValue.Text = "The min value is: " + minValue;

        }

        private void frmMinArray_Load(object sender, EventArgs e)
        {

        }
    }
}
