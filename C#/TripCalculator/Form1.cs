/*Info
 * Programmer: Charlie Beals
 * Date: 11/21/2020
 * Purpose: Calculate MPG for trip data
 * Class: CITP 180
 * Assignment: Ch 9 - Ex 5
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

namespace TripCalculator
{
    public partial class FormTripCalculator : Form
    {
        public FormTripCalculator()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Clear all values
            txtDestination.Text = "";
            txtGallons.Text = "";
            txtMiles.Text = "";

            // Hide output
            lblOutput.Visible = false;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Check if input is valid
            double numMiles;
            double numGallons;
            bool validMiles = double.TryParse(txtMiles.Text, out numMiles);
            bool validGallons = double.TryParse(txtGallons.Text, out numGallons);

            // If input is valid, calculate and display MPG
            if (validMiles == true && validGallons == true && numGallons > 0 && numMiles > 0)
            {
                double mpg = numMiles / numGallons;

                mpg = Math.Round(mpg, 1);

                string mpgString = mpg.ToString();

                // Set a default value for the destination if none was given
                string destinationString;
                if (txtDestination.Text == "")
                {
                    destinationString = "your destination";
                }
                else
                {
                    destinationString = txtDestination.Text;
                }

                lblOutput.Text = "Fuel effiency for your trip to " + destinationString + " is " + mpgString + " MPG.";
                lblOutput.Visible = true;
            }
            // If input is invalid, display error message
            else
            {
                lblOutput.Text = "Invalid values entered, please try again";
                lblOutput.Visible = true;
            }
        }
    }
}
