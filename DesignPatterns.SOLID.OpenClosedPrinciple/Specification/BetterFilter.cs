using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.SOLID.OpenClosedPrinciple.Specification
{
    public class BetterFilter : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> spec)
        {
            foreach (var item in items)
                if (spec.IsSatisfied(item))
                    yield return item;
        }
    }
}
