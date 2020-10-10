using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.SOLID.OpenClosedPrinciple.Specification
{
    public interface ISpecification<T>
    {
        bool IsSatisfied(T t);
    }
}
