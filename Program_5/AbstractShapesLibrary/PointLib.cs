// Fig. 10.5: Point2.cs
// Point2 inherits from abstract class Shape and represents
// an x-y coordinate pair.
using System;

namespace AbstractShapesLibrary
{
    // Point inherits from abstract class Quadrilateral
    public class PointLib : QuadrilateralLib
    {
        private int x, y; // Point coordinates

        // default constructor
        public PointLib()
        {
            // implicit call to Object constructor occurs here
        }

        // constructor
        public PointLib(int xValue, int yValue)
        {
            X = xValue;
            Y = yValue;
        }

        // propertyX
        public int X
        {
            get
            {
                return x;
            }

            set
            {
                x = value; // no validation needed
            }
        }

        // property Y
        public int Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value; // no validation needed
            }
        }

        // return string representation of Point object
        public override string ToString()
        {
            return "[" + X + ", " + Y + "]";
        }

        // implement abstract property Name of class Quadrilateral
        public override string Name
        {
            get
            {
                return "Point";
            }
        }

    } // end class Point
}
