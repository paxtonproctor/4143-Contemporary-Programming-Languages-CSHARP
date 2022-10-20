using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractShapesLibrary
{
    // Rectangle inherits from class Point
    public class RectangleLib : ParallelogramLib
    {
        PointLib P1;
        PointLib P2;
        PointLib P3;

        private double length;
        private double width;

        // default constructor
        public RectangleLib()
        {
            // implicit call to Point constructor occurs here
        }

        // constructor
        public RectangleLib(int xValue, int yValue, int x2Value, int y2Value
            , int x3Value, int y3Value, int lengthValue
            , int widthValue)
        {
            P1 = new PointLib(xValue, yValue);
            P2 = new PointLib(x2Value, y2Value);
            P3 = new PointLib(x3Value, y3Value);
            Length = lengthValue;
            Width = widthValue;
        }

        // property Length
        public double Length
        {
            get
            {
                return length;
            }

            set
            {
                // ensure non-negative Length value
                if (value >= 0)
                    length = value;
            }
        }

        public double Width
        {
            get
            {
                return width;
            }

            set
            {
                // ensure non-negative Width value
                if (value >= 0)
                    width = value;
            }
        }

        // calculate Parallelogram area
        public override double Area()
        {
            return Length * Width;
        }

        // calculate Rectangle Perimeter
        public override double Perimeter()
        {
            return (2 * (Length + Width));
        }

        // return string representation of Rectangle object
        public override string ToString()
        {
            return "P1 = " + P1 + "; P2 = " + P2 + "; P3 = " + P3;
        }

        // override property Name from class Quadrilateral
        public override string Name
        {
            get
            {
                return "Rectangle";
            }
        }

    } // end class Quadrilateral
}
