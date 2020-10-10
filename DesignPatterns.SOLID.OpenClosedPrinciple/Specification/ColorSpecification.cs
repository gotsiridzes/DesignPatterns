using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.SOLID.OpenClosedPrinciple.Specification
{
    public class ColorSpecification : ISpecification<Product>
    {
        public Color Color { get; set; }

        public ColorSpecification(Color color)
        {
            Color = color;
        }

        public bool IsSatisfied(Product p)
        {
            return p.Color == Color;
        }
    }
}
