using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractShapesLibrary
{
    // Parallelogram inherits from class Point
    public class ParallelogramLib : TrapezoidLib
    {
        PointLib P1;
        PointLib P2;
        PointLib P3;

        private double baseb;
        private double height;
        private double sidea;

        // default constructor
        public ParallelogramLib()
        {
            // implicit call to Point constructor occurs here
        }

        // constructor
        public ParallelogramLib(int xValue, int yValue, int x2Value, int y2Value
            , int x3Value, int y3Value, int basebValue
            , int sideaValue, int heightValue)
        {
            P1 = new PointLib(xValue, yValue);
            P2 = new PointLib(x2Value, y2Value);
            P3 = new PointLib(x3Value, y3Value);
            BaseB1 = basebValue;
            SideA = sideaValue;
            Height1 = heightValue;
        }

        // property Base
        public double BaseB1
        {
            get
            {
                return baseb;
            }

            set
            {
                // ensure non-negative Base value
                if (value >= 0)
                    baseb = value;
            }
        }

        public double Height1
        {
            get
            {
                return height;
            }

            set
            {
                // ensure non-negative Height value
                if (value >= 0)
                    height = value;
            }
        }

        public double SideA
        {
            get
            {
                return sidea;
            }

            set
            {
                // ensure non-negative sidea value
                if (value >= 0)
                    sidea = value;
            }
        }

        // calculate Parallelogram area
        public override double Area()
        {
            return BaseB1 * Height1;
        }

        // calculate Parallelogram perimeter
        public override double Perimeter()
        {
            return (2 * (BaseB1 + SideA));
        }

        // return string representation of Parallelogram object
        public override string ToString()
        {
            return "P1 = " + P1 + "; P2 = " + P2 + "; P3 = " + P3;
        }

        // override property Name from class Quadrilateral
        public override string Name
        {
            get
            {
                return "Parallelogram";
            }
        }

    } // end class Quadrilateral
}
