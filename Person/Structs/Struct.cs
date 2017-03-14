﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    struct SimpleStruct
    {
        private int xval;
        public int X
        {
            get
            {
                return xval;
            }
            set
            {
                if (value < 100)
                    xval = value;
            }
        }

        public void Display()
        {
            Console.WriteLine("The stored value is: {0}", xval);
        }
    }

    class TestClass
    {
        //public static void Main()
        //{
        //    SimpleStruct ss = new SimpleStruct();
        //    ss.X = 5;
        //    ss.Display();
        //}
    }
}
