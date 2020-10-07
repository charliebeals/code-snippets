using System;
using static System.Console;

namespace ReceiptCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Welcome to the Receipt Creator");

            // Create instance of Receipt object
            Receipt thisReceipt = new Receipt();
            thisReceipt.ReceiptNumber = PromptForInt("the receipt number");
            thisReceipt.ReceiptDate = PromptForDateTime("the date of purchase");
            thisReceipt.CustomerNumber = PromptForInt("the customer's id number");
            thisReceipt.CustomerName = PromptForString("the customer's name");
            thisReceipt.CustomerAddress = PromptForString("the customer's address");
            thisReceipt.CustomerPhone = PromptForString("the customer's phone number");
            thisReceipt.ItemNumber = PromptForInt("the item number");
            thisReceipt.ItemDescription = PromptForString("the item description");
            thisReceipt.ItemPrice = PromptForDouble("the item price");
            thisReceipt.Quantity = PromptForInt("the quantity of the item purchased");

            // Call output method
            WriteLine(thisReceipt);
        }

        // Input methods with value checking
        public static int PromptForInt(string key)
        {
            int value = 0;
            bool enterAgain = true;
            while (enterAgain == true)
            {
                string inValue;
                Write("Please enter " + key + ": ");
                inValue = ReadLine();
                if (int.TryParse(inValue, out value) == false)
                {
                    WriteLine("invalid interger value");
                    enterAgain = true;
                }
                else
                {
                    enterAgain = false;
                }
            }
            return value;
        }
        public static string PromptForString(string key)
        {
            Write("Please enter " + key + ": ");
            string value = ReadLine();
            return value;
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
        public static DateTime PromptForDateTime(string key)
        {
            DateTime value = DateTime.Now;
            bool enterAgain = true;
            while (enterAgain == true)
            {
                string inValue;
                Write("Please enter " + key + ": ");
                inValue = ReadLine();
                if (DateTime.TryParse(inValue, out value) == false)
                {
                    WriteLine("invalid DateTime value");
                    enterAgain = true;
                }
                else
                {
                    enterAgain = false;
                }
            }
            return value;
        }
    }
}
