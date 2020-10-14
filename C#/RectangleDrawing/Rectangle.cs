using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace RectangleDrawing
{
    class Rectangle
    {
        // Set Shape Parameters
        private int height;
        private int width;

        // Default constructor
        public Rectangle()
        {
        }

        // Constructor with height and width parameters
        public Rectangle(int height,int width)
        {
            Height = height;
            Width = width;
        }

        // Property Accessors
        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }
        public int Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }

        // Method to print the characters in the shape of a rectangle

        public void draw()
        {
            if (validateParameters(height,width) != false)
            {
                //
                int horizontalWidth = width - 2;
                int veritcalHeight = height - 2;

                // Print top row
                Write("+");
                for (int i = 0; i < horizontalWidth; i++)
                {
                    Write("-");
                }
                WriteLine('+');

                // Print middle row
                for (int n = 0; n < veritcalHeight; n++)
                {
                    Write("|");
                    for (int i = 0; i < horizontalWidth; i++)
                    {
                        Write(" ");
                    }
                    WriteLine('|');
                }


                // Print bottom row
                Write("+");
                for (int i = 0; i < horizontalWidth; i++)
                {
                    Write("-");
                }
                WriteLine('+');
            }
        }

        private bool validateParameters(int h,int w)
        {
            bool validParams = false;
            if (h < 2)
            {
                WriteLine("Invalid height. Please enter a height of at least 2.");
                validParams = false;
            }
            else if (w < 2)
            {
                WriteLine("Invalid width. Please enter a width of at least 2.");
                validParams = false;
            }
            else
            {
                validParams = true;
            }

            return validParams;
        }
    }
}
