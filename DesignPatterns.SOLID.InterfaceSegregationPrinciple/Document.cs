using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.SOLID.InterfaceSegregationPrinciple
{
    public class Document
    {
        public string Name { get; set; }
        public string Text { get; set; }

        public Document(string name, string text)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Text = text ?? throw new ArgumentNullException(nameof(text));
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}\n{2} - {3}", nameof(Name), Name, nameof(Text), Text);
        }
    }
}
