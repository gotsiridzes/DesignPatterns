using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Factories.AbstractFactory
{
    public class Tea : IHotDrink
    {
        public void Consume()
        {
            Console.WriteLine("Drinking Tea ...");
        }
    }
}
