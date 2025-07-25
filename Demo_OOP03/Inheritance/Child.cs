using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_OOP03.Inheritance
{
    public class Child:Parent//,Car => multiple inheritance not appplicable
    {
 

        //public int X { get; set; }
        //public int Y { get; set; }
        public int Z { get; set; }

        public Child(int x, int y, int z):base(x,y)
        {
            ////X = x;
            ////Y = y;
            Z = z;
        }

        ////to use override=> the method must be
                              //non private + virtual
                              //ovrride for method with the signature(identity)
        public override int product()
        {
            return X * Y * Z;
        }

        ////masking by new 

        //public new int product()
        //{
        //    return X * Y * Z;
        //}
    }
}
