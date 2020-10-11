using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.SOLID.LiskovSubstitutionPrinciple
{
    public class Square : Rectangle
    {
        //public new int Width
        //{
        //    set
        //    {
        //        base.Width = base.Height = value;
        //    }
        //}

        //public new int Height
        //{
        //    set
        //    {
        //        base.Height = base.Width = value;
        //    }
        //}

        public override int Width 
        { 
            set
            {
                base.Width = base.Height = value;
            } 
        }

        public override int Height
        {
            set
            {
                base.Height = base.Width = value;
            }
        }
    }
}
