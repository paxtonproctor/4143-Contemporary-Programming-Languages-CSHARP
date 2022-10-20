// Fig. 10.6: Circle2.cs
// Circle2 inherits from class Point2 and overrides key members.
using System;
using System.Security.Policy;

namespace AbstractShapesLibrary
{
    // Parallelogram inherits from class Point
    public class TrapezoidLib : QuadrilateralLib
    {
        PointLib P1;
        PointLib P2;
        PointLib P3;
        PointLib P4;

        private double basea;
        private double baseb;
        private double height;
        private double sidec;
        private double sided;

        // default constructor
        public TrapezoidLib()
        {
            // implicit call to Point constructor occurs here
        }

        // constructor
        public TrapezoidLib(int xValue, int yValue, int x2Value, int y2Value
            , int x3Value, int y3Value, int x4Value, int y4Value
            , int baseaValue, int basebValue, int heightValue
            , int sidecValue, int sidedvalue)
        {
            P1 = new PointLib(xValue, yValue);
            P2 = new PointLib(x2Value, y2Value);
            P3 = new PointLib(x3Value, y3Value);
            P4 = new PointLib(x4Value, y4Value);
            BaseA = baseaValue;
            BaseB = basebValue;
            SideC = sidecValue;
            SideD = sidedvalue;
            Height = heightValue;
        }

        // property Base
        public double BaseA
        {
            get
            {
                return basea;
            }

            set
            {
                // ensure non-negative Base value
                if (value >= 0)
                    basea = value;
            }
        }

        // property Base 2
        public double BaseB
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

        public double Height
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

        public double SideC
        {
            get
            {
                return sidec;
            }

            set
            {
                // ensure non-negative Side value
                if (value >= 0)
                    sidec = value;
            }
        }

        public double SideD
        {
            get
            {
                return sided;
            }

            set
            {
                // ensure non-negative Side value
                if (value >= 0)
                    sided = value;
            }
        }

        // calculate Parallelogram area
        public override double Area()
        {
            return (((BaseA + BaseB) / 2) * Height);
        }

        // calculate Parallelogram area
        public override double Perimeter()
        {
            return BaseA + BaseB + SideC + SideD;
        }

        // return string representation of Trapezoid object
        public override string ToString()
        {
            return "P1 = " + P1 + "; P2 = " + P2 + "; P3 = " + P3 + "; P4 = " + P4;
        }

        // override property Name from class Quadrilateral
        public override string Name
        {
            get
            {
                return "Trapezoid";
            }
        }

    } // end class Quadrilateral
}
