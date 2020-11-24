using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Factories.AbstractFactory
{
    public class HotDrinkMachine
    {
        //public enum AvaliableDrink
        //{
        //    Coffe, 
        //    Tea
        //}

        //private Dictionary<AvaliableDrink, IHotDrinkFactory> factories = new Dictionary<AvaliableDrink, IHotDrinkFactory>();

        //public HotDrinkMachine()
        //{
        //    foreach (AvaliableDrink drink in Enum.GetValues(typeof(AvaliableDrink)))
        //    {
        //        var factory = (IHotDrinkFactory)Activator.CreateInstance(
        //            Type.GetType("DesignPatterns.Creational.Factory.AbstractFactory" + Enum.GetName(typeof(AvaliableDrink), drink) + "Factory"));

        //        factories.Add(drink, factory);
        //    }
        //}

        //public IHotDrink MakeDrink(AvaliableDrink drink, int amount)
        //{
        //    return factories[drink].Prepare(amount);
        //}

        private List<Tuple<string, IHotDrinkFactory>> factories = new List<Tuple<string, IHotDrinkFactory>>(); 

        public HotDrinkMachine()
        {
            foreach (var item in typeof(HotDrinkMachine).Assembly.GetTypes())
                if (typeof(IHotDrinkFactory).IsAssignableFrom(item) && !item.IsInterface)
                    factories.Add(Tuple.Create(item.Name.Replace("Factory", string.Empty), (IHotDrinkFactory)Activator.CreateInstance(item)));
        }

        public IHotDrink MakeDrink()
        {
            Console.WriteLine("Avaliable drinks");

            for (int i = 0; i < factories.Count; i++)
            {
                Console.WriteLine($"{i} : {factories[i].Item1}");
            }

            while (true)
            {
                string s;
                if ((s = Console.ReadLine()) != null
                    && int.TryParse(s, out int i)
                    && i >= 0
                    && i < factories.Count)
                {
                    Console.WriteLine("Specify Amount: {}");
                    s = Console.ReadLine();

                    if (s != null
                        && int.TryParse(s, out int amount)
                        && amount > 0)
                    {
                        return factories[i].Item2.Prepare(amount);
                    }

                    Console.WriteLine("Wrong input");
                }

            }

        }
    }
}
