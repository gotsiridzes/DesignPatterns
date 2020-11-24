using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Factories.AbstractFactory
{
    public class CoffeFactory : IHotDrinkFactory
    {
        public IHotDrink Prepare(int amount)
        {
            Console.WriteLine("Boiling water, putting coffe in a mug.");
            return new Coffe();
        }
    }
}
