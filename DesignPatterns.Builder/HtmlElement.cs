using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder
{
    public class HtmlElement
    {
        public string Name { get; set; }
        public string Text { get; set; }
        public List<HtmlElement> Elements { get; set; } = new List<HtmlElement>();
        private int indentSize = 2;
        
        public HtmlElement() { }

        public HtmlElement(string name, string text)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Text = text ?? throw new ArgumentNullException(nameof(text));
        }

        private string ToStringImpl(int indent)
        {
            StringBuilder sb = new StringBuilder();
            string i = new string(' ', indentSize * indent);

            sb.AppendLine($"{i}<{Name}>");

            if (!string.IsNullOrEmpty(Text))
            {
                sb.Append(' ', indentSize * (indent + 1));
                sb.AppendLine($"{Text}");
            }

            foreach (var e in Elements)
                sb.Append(e.ToStringImpl(indent + 1));
            
            sb.AppendLine($"{i}</{Name}>");

            return sb.ToString();
        }

        public override string ToString()
        {
            return ToStringImpl(0);
        }
    }
}
