using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Shape
    {
        private string myId;

        public Shape(string s)
        {
            Id = s;   // calling the set accessor of the Id property
        }

        public string Id
        {
            get
            {
                return myId;
            }

            set
            {
                myId = value;
            }
        }

        // Area is a read-only property - only a get accessor is needed:
        public abstract double Area
        {
            get;
        }

        public override string ToString()
        {
            return Id + " Area = " + string.Format("{0:F2}", Area);
        }
    }
}
