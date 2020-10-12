using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder
{
    public class HtmlBuilder
    {
        public HtmlElement Root { get; set; } = new HtmlElement();
        public string RootName { get; }

        public HtmlBuilder(string rootName)
        {

            RootName = rootName ?? throw new ArgumentNullException(nameof(rootName));
            Root.Name = RootName;
        }

        public void AddChild(string childName, string childText)
        {
            HtmlElement elem = new HtmlElement(childName, childText);
            Root.Elements.Add(elem);
        }

        public override string ToString()
        {
            return Root.ToString();
        }

        public void Clear()
        {
            Root = new HtmlElement 
            { 
                Name = RootName 
            };
        }
    }
}
