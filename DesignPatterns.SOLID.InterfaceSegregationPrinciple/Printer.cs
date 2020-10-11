using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.SOLID.InterfaceSegregationPrinciple
{
    public class Printer : IPrinter
    {
        public void Print(Document d)
        {
            Console.WriteLine(d);
        }
    }
}
