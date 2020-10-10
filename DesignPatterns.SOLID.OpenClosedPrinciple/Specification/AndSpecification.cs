using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.SOLID.OpenClosedPrinciple.Specification
{
    public class AndSpecification<T> : ISpecification<T> 
    {
        public ISpecification<T> First { get; set; }
        public ISpecification<T> Second { get; set; }

        public AndSpecification(ISpecification<T> first, ISpecification<T> second)
        {
            First = first ?? throw new ArgumentNullException(nameof(first));
            Second = second ?? throw new ArgumentNullException(nameof(second));
        }

        public bool IsSatisfied(T t)
        {
            return First.IsSatisfied(t) && Second.IsSatisfied(t);
        }
    }
}
