using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.SOLID.DependencyInversionPrinciple
{
    public class Research
    {
        //public Research(Relationships relationships)
        //{
        //    var relations = relationships.Relations;
        //    foreach (var item in relations.Where(x => x.Item1.Name == "Gela" && x.Item2 == Relationship.Parent))
        //        Console.WriteLine($"Gelas yavs shvili {item.Item3.Name}");
        //}
        public Research(IRelationshipBrowser browser)
        {
            foreach (var p in browser.FindAllChildrenOf("Gela"))
            {
                Console.WriteLine($"gelas shvilebi: {p.Name}");
            }
        }
    }
}
