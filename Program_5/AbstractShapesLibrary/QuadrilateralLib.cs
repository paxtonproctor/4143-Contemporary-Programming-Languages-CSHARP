// Fig. 10.4: Shape.cs
// Demonstrate a shape hierarchy using an abstract base class.
using System;

namespace AbstractShapesLibrary
{
    public abstract class QuadrilateralLib
    {
        // return Quadrilateral's area
        public virtual double Area()
        {
            return 0;
        }

        // return Quadrilateral's volume
        public virtual double Perimeter()
        {
            return 0;
        }

        // return Quadrilateral's name
        public abstract string Name
        {
            get;
        }
    }
}
