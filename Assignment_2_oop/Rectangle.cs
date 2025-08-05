using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_oop
{
    internal struct Rectangle
    {
        private double width;
        private double height;

        public double Width
        {
            get 
            { 
                return width; 
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Error: Width cannot be negative");
                }
                else
                {
                    width = value;
                }
            }
        }

        public double Height
        {
            get 
            { 
                return height; 
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Error: Height cannot be negative");
                }
                else
                {
                    height = value;
                }
            }
        }

        public double Area
        {
            get { 
                return width * height; 
            }
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Rectangle Info:");
            Console.WriteLine($"Width: {width}");
            Console.WriteLine($"Height: {height}");
            Console.WriteLine($"Area: {Area}");
        }
    }
}
