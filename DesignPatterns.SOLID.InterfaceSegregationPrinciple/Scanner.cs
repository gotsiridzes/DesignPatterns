using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.SOLID.InterfaceSegregationPrinciple
{
    public class Scanner : IScanner
    {
        public void Scan(Document d)
        {
            Console.WriteLine("Scanning Document...\n{0}", d);
        }
    }
}
