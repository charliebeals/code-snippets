using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using static System.Console;
using Microsoft.VisualBasic;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Initialize arrays
            double[] array1 = newDoubleArray();
            double[] array2 = newDoubleArray();
            double[] array3 = multiplyArrays(array1, array2);

            string outputMessage = "";
            // Display contents of array1
            outputMessage += "Array #1\n\n";
            foreach(double value in array1)
            {
                outputMessage += value + "\n";
            }
            // Display contents of array2
            outputMessage += "Array #2\n\n";
            foreach (double value in array2)
            {
                outputMessage += value + "\n";
            }
            // Display contents of array3
            outputMessage += "Array #3\n\n";
            foreach (double value in array3)
            {
                outputMessage += value + "\n";
            }
            // Show message box
            MessageBox.Show(outputMessage);
        }

        static double[] newDoubleArray()
        {
            // Get length of array from user
            int length = PromptForInt("length of array");

            // Initialize array
            double[] myArray = new double[length];

            // Allow user to enter values
            string inValue;
            for (int i = 0; i < myArray.Length; i++)
            {
                Write("Enter value{0}: ", i + 1);

                // Confirm value is type double
                inValue = Interaction.InputBox("Input value");
                if (double.TryParse(inValue, out myArray[i]) == false)
                {
                    WriteLine("Invalid data entered, 0 stored");
                    MessageBox.Show("Invalid data entered, 0 stored");
                }
            }

            return myArray;
        }
        public static double PromptForDouble(string key)
        {
            double value = 0;
            bool enterAgain = true;
            while (enterAgain == true)
            {
                string inValue;
                Write("Please enter " + key + ": ");
                inValue = ReadLine();
                if (double.TryParse(inValue, out value) == false)
                {
                    WriteLine("invalid double value");
                    enterAgain = true;
                }
                else
                {
                    enterAgain = false;
                }
            }
            return value;
        }
        public static int PromptForInt(string key)
        {
            int value = 0;
            bool enterAgain = true;
            while (enterAgain == true)
            {
                string inValue;
                inValue = Interaction.InputBox("Please enter " + key);
                if (int.TryParse(inValue, out value) == false)
                {
                    WriteLine("invalid int value");
                    MessageBox.Show("Invalid data entered, try again");
                    enterAgain = true;
                }
                else
                {
                    enterAgain = false;
                }
            }
            return value;
        }
        static double[] multiplyArrays(double[] array1,double[] array2)
        {
            // Initialize array to return
            double[] returnArray = new double[0];

            // Get length of both input arrays
            int a1Length = array1.Length;
            int a2Length = array2.Length;

            // If arrays are the same length, multiply all values into new array and return
            if (a1Length == a2Length)
            {
                // Set new array length to either array
                returnArray = new double[a1Length];
                // loop through values of arrays, multiplying and adding to the returnArray
                for (int i = 0; i < returnArray.Length; i++)
                {
                    WriteLine("Value: " + i + " in array1 is " + array1[i]);
                    WriteLine("Value: " + i + " in array2 is " + array1[i]);
                    double multipliedValue = array1[i] * array2[i];
                    WriteLine("Multiplied value is " + multipliedValue);
                    returnArray[i] = multipliedValue;
                }
            }
            else if (a1Length > a2Length)
            {
                // Set new array length to array 1
                returnArray = new double[a1Length];
                // loop through values of arrays, multiplying and adding to the returnArray
                for (int i = 0; i < returnArray.Length; i++)
                {
                    // Print value of larger array, always present
                    WriteLine("Value: " + i + " in larger array is " + array1[i]);

                    // Check if value in smaller array exists. If not, set to 1.
                    // Check if value in smaller array exists. If not, set to 1.
                    try
                    {
                        if (array2[i] != null)
                        {
                            WriteLine("Value: " + i + " in smaller array is " + array2[i]);
                            double multipliedValue = array1[i] * array2[i];
                            WriteLine("Multiplied value is " + multipliedValue);
                            returnArray[i] = multipliedValue;
                        }
                    }
                    catch (System.IndexOutOfRangeException)
                    {
                        WriteLine("Value doesn't exist in smaller array. Setting result to 1.");
                        WriteLine("Multiplied value is " + array1[i]);
                        returnArray[i] = array1[i];
                    }
                }
            }
            else if (a1Length < a2Length)
            {
                // Set new array length to array 2
                returnArray = new double[a2Length];
                // loop through values of arrays, multiplying and adding to the returnArray
                for (int i = 0; i < returnArray.Length; i++)
                {
                    // Print value of larger array, always present
                    WriteLine("Value: " + i + " in larger array is " + array2[i]);

                    // Check if value in smaller array exists. If not, set to 1.
                    try
                    {
                        if (array1[i] != null)
                        {
                            WriteLine("Value: " + i + " in smaller array is " + array1[i]);
                            double multipliedValue = array1[i] * array2[i];
                            WriteLine("Multiplied value is " + multipliedValue);
                            returnArray[i] = multipliedValue;
                        }
                    }
                    catch (System.IndexOutOfRangeException)
                    {
                        WriteLine("Value doesn't exist in smaller array. Setting result to 1.");
                        WriteLine("Multiplied value is " + array2[i]);
                        returnArray[i] = array2[i];
                    }
                }
            }

            return returnArray;
        }
    }
}
