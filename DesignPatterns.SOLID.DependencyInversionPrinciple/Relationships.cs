using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.SOLID.DependencyInversionPrinciple
{
    public class Relationships : IRelationshipBrowser
    {
        private List<(Person, Relationship, Person)> relations = new List<(Person, Relationship, Person)>();

        //public List<(Person, Relationship, Person)> Relations
        //{
        //    get 
        //    { 
        //        return relations;
        //    }
        //}

        // low level api
        public void AddRelation(Person parent, Person child)
        {
            relations.Add((parent, Relationship.Parent, child));
            relations.Add((child, Relationship.Child, parent));
        }

        public IEnumerable<Person> FindAllChildrenOf(string parentName)
        {
            return relations.Where(x => x.Item1.Name == parentName && x.Item2 == Relationship.Parent).Select(r => r.Item3);
        }
    }
}
