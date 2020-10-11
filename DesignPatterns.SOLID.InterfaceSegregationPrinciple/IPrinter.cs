using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.SOLID.InterfaceSegregationPrinciple
{
    public interface IPrinter
    {
        /// <summary>
        /// ბეჭდვა
        /// </summary>
        /// <param name="d"></param>
        void Print(Document d);
    }
}
