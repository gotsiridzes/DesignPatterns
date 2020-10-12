using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.SOLID.DependencyInversionPrinciple
{
    public interface IRelationshipBrowser
    {
        IEnumerable<Person> FindAllChildrenOf(string parentName);
    }
}
