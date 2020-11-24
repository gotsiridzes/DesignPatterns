using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Factories.AbstractFactory
{
    public class Coffe : IHotDrink
    {
        public void Consume()
        {
            Console.WriteLine("Drink Coffe ...");
        }
    }
}
