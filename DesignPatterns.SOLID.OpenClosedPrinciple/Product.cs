using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.SOLID.OpenClosedPrinciple
{
    public class Product
    {
        public string Name { get; set; }
        public Color Color { get; set; }
        public Size Size { get; set; }

        public Product(string name, Color color, Size size)
        {
            if (name is null)
                throw new ArgumentNullException(nameof(name));

            Name = name;
            Color = color;
            Size = size;
        }

        public override string ToString()
        {
            return string.Format("Name: {0}, Color: {1}, Size: {2}", Name, Color, Size);
        }
    }

    public enum Color
    {
        Red,
        Green,
        Blue
    }

    public enum Size
    {
        Small,
        Medium,
        Large
    }
}
