using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.SOLID.InterfaceSegregationPrinciple
{
    public interface IScanner
    {
        /// <summary>
        /// სკანირება
        /// </summary>
        /// <param name="d"></param>
        void Scan(Document d);
    }
}
