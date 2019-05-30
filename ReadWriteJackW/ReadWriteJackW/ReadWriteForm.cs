using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadWriteJackW
{
    public partial class frmReadWrite : Form
    {
        public frmReadWrite()
        {
            InitializeComponent();
        }

        private bool StringsAreEqual(string case1, string case2)
        {
            //Creating boolean variable
            bool isEqual;

            //Determines whether the two strings are equal in length
            if (case1.Length == case2.Length)
            {
                //Converting strings to upper case
                case1 = case1.ToUpper();
                case2 = case2.ToUpper();

                if (case1 == case2)
                {
                    //If both strings are equal to each other the boolean variable is true 
                    isEqual = true;
                }
                else
                {
                    //If both strings are not equal to each other the boolean variable is false
                    isEqual = false;
                }
            }
            else
            {
                //If the length is not equal the boolean variable is false
                isEqual = false;
            }
            //Returns the boolean variable
            return isEqual;

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //Reads all lines in input file
            string[] lines = System.IO.File.ReadAllLines(@"input.txt");

            //Creates a character array
            char[] charSeperators = new char[] {' ', '\t' };

            //creates output string
            string output = "";

            //Parses through each string and determines whether the two strings in the input file at a similar location are equal
            foreach (string line in lines)
            {
                string[] words = line.Split(charSeperators, StringSplitOptions.RemoveEmptyEntries);

                if (StringsAreEqual(words[0], words[1]) == true)
                {
                    output = output + "True\r\n";

                }
                else
                {
                    output = output + "False\r\n";
                }
            }

            //Creates the output file 
            System.IO.File.WriteAllText(@"output.txt", output);

            //Display output label
            this.lblOutput.Show();

        }
    }
}
