using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Factories.AbstractFactory
{
    public class HotDrinkMachine
    {
        public enum AvaliableDrink
        {
            Coffe, 
            Tea
        }

        private Dictionary<AvaliableDrink, IHotDrinkFactory> factories = new Dictionary<AvaliableDrink, IHotDrinkFactory>();

        public HotDrinkMachine()
        {
            foreach (AvaliableDrink drink in Enum.GetValues(typeof(AvaliableDrink)))
            {
                var factory = (IHotDrinkFactory)Activator.CreateInstance(
                    Type.GetType("DesignPatterns.Creational.Factory.AbstractFactory" + Enum.GetName(typeof(AvaliableDrink), drink) + "Factory"));

                factories.Add(drink, factory);
            }
        }

        public IHotDrink MakeDrink(AvaliableDrink drink, int amount)
        {
            return factories[drink].Prepare(amount);
        }
    }
}
