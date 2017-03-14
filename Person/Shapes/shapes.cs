using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Square : Shape
    {
        private int mySide;

        public Square(int side, string id) : base(id)
        {
            mySide = side;
        }

        public override double Area
        {
            get
            {
                // Given the side, return the area of a square:
                return mySide * mySide;
            }
        }
    }

    public class Circle : Shape
    {
        private int myRadius;

        public Circle(int radius, string id) : base(id)
        {
            myRadius = radius;
        }

        public override double Area
        {
            get
            {
                // Given the radius, return the area of a circle:
                return myRadius * myRadius * System.Math.PI;
            }
        }
    }

    public class Rectangle : Shape
    {
        private int myWidth;
        private int myHeight;

        public Rectangle(int width, int height, string id) : base(id)
        {
            myWidth = width;
            myHeight = height;
        }

        public override double Area
        {
            get
            {
                // Given the width and height, return the area of a rectangle:
                return myWidth * myHeight;
            }
        }
    }
}
