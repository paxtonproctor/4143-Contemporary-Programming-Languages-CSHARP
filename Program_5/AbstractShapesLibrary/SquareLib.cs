using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractShapesLibrary
{
    // Square inherits from class Point
    public class SquareLib : RectangleLib
    {
        PointLib P1;
        PointLib P2;

        private double side;

        // default constructor
        public SquareLib()
        {
            // implicit call to Point constructor occurs here
        }

        // constructor
        public SquareLib(int xValue, int yValue,
            int x2Value, int y2Value, int sideValue)
        {
            P1 = new PointLib(xValue, yValue);
            P2 = new PointLib(x2Value, y2Value);
            side = sideValue;
        }

        // property Side
        public double Side
        {
            get
            {
                return side;
            }

            set
            {
                // ensure non-negative Side value
                if (value >= 0)
                    side = value;
            }
        }

        // calculate Square area
        public override double Area()
        {
            return Side * Side;
        }

        // calculate Square perimeter
        public override double Perimeter()
        {
            return (4 *Side);
        }

        // return string representation of Square object
        public override string ToString()
        {
            return "P1 = " + P1 + "; P2 = " + P2;
        }

        // override property Name from class Quadrilateral
        public override string Name
        {
            get
            {
                return "Square";
            }
        }

    } // end class Quadrilateral
}
