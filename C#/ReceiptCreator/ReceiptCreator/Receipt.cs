using System;
using System.Collections.Generic;
using System.Text;

namespace ReceiptCreator
{
    class Receipt
    {
        // Set members
        private int receiptNumber;
        private DateTime receiptDate;
        private int customerNumber;
        private string customerName;
        private string customerAddress;
        private string customerPhone;
        private int itemNumber;
        private string itemDescription;
        private double itemPrice;
        private int quantity;

        // Default constructor
        public Receipt()
        {
        }

        // Property accessors
        #region Property Accessors
        public int ReceiptNumber
        {
            get
            {
                return receiptNumber;
            }
            set
            {
                receiptNumber = value;
            }
        }
        public DateTime ReceiptDate
        {
            get
            {
                return receiptDate;
            }
            set
            {
                receiptDate = value;
            }
        }
        public int CustomerNumber
        {
            get
            {
                return customerNumber;
            }
            set
            {
                customerNumber = value;
            }
        }
        public string CustomerName
        {
            get
            {
                return customerName;
            }
            set
            {
                customerName = value;
            }
        }
        public string CustomerAddress
        {
            get
            {
                return customerAddress;
            }
            set
            {
                customerAddress = value;
            }
        }
        public string CustomerPhone
        {
            get
            {
                return customerPhone;
            }
            set
            {
                customerPhone = value;
            }
        }
        public int ItemNumber
        {
            get
            {
                return itemNumber;
            }
            set
            {
                itemNumber = value;
            }
        }
        public string ItemDescription
        {
            get
            {
                return itemDescription;
            }
            set
            {
                itemDescription = value;
            }
        }
        public double ItemPrice
        {
            get
            {
                return itemPrice;
            }
            set
            {
                itemPrice = value;
            }
        }
        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }
        #endregion

        // Calculate cost from the item price and quantity
        public double CalculateCost(double price, int quantity)
        {
            double quantityAsDouble = (double)quantity;
            double totalCost = price * quantityAsDouble;
            double dollarAmmount = Math.Round(totalCost, 2);
            return dollarAmmount;
        }

        // Override ToString() method
        public override string ToString()
        {
            return "\t Customer Information" +
                "\n\nCustomer Name: " + customerName +
                "\nCustomer Number: " + customerNumber +
                "\nCustomer Address: " + customerAddress +
                "\nCustomer Phone: " + customerPhone +
                "\n\nTotal Cost: $" + CalculateCost(itemPrice, quantity);
        }
    }
}
