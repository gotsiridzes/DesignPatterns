using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.SOLID.OpenClosedPrinciple.Specification
{
    public class SizeSpecification : ISpecification<Product>
    {
        public Size Size { get; set; }

        public SizeSpecification(Size size)
        {
            Size = size;
        }

        public bool IsSatisfied(Product t)
        {
            return t.Size == Size;
        }
    }
}
