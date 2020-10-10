using DesignPatterns.SOLID.OpenClosedPrinciple;
using DesignPatterns.SOLID.OpenClosedPrinciple.Specification;
using DesignPatterns.SOLID.SingleResponsibilityPrinciple;
using System;
using System.Diagnostics;
using System.Linq;

namespace DesignPatterns
{

    class Program
    {
        static void Main(string[] args)
        {
            SingleResponsibilityPrinciple();
            OpenClosedPrinciple();
        }

        private static void OpenClosedPrinciple()
        {
            Console.WriteLine("Open Closed Principle");
            Product[] products = GetProducts();

            Console.WriteLine("Violates OCP");
            var filter = new ProductFilter();

            Console.WriteLine("---Blue Items---");
            foreach (var prod in filter.FilterByColor(products, Color.Blue))
                Console.WriteLine("--- --- {0}", prod);

            Console.WriteLine("---Large Items---");
            foreach (var prod in filter.FilterBySize(products, Size.Large))
                Console.WriteLine("--- --- {0}", prod);

            Console.WriteLine("\nDoes not violate OCP\n");
            //არ არღვევს ocp-s

            var bf = new BetterFilter();
            Console.WriteLine("---Green Products---");
            foreach (var prod in bf.Filter(products, new ColorSpecification(Color.Green)))
                Console.WriteLine("--- --- {0}", prod);

            Console.WriteLine("---Small Products---");
            foreach (var prod in bf.Filter(products, new SizeSpecification(Size.Small)))
                Console.WriteLine("--- --- {0}", prod);

            Console.WriteLine("---Large Blue Items---");
            foreach (var prod in bf.Filter(products,
                new AndSpecification<Product>(
                    new ColorSpecification(Color.Blue),
                    new SizeSpecification(Size.Large)
                    )))
                Console.WriteLine("--- --- {0}", prod);

            Console.WriteLine();
        }

        private static Product[] GetProducts()
        {
            Product apple = new Product("Apple", Color.Red, Size.Small);
            Product apple2 = new Product("Apple", Color.Red, Size.Small);
            Product car = new Product("Car", Color.Blue, Size.Medium);
            Product truck = new Product("Truck", Color.Blue, Size.Large);
            Product helicopter = new Product("Helicopter", Color.Green, Size.Large);
            Product helicopter2 = new Product("Helicopter2", Color.Blue, Size.Large);

            Product[] products = { apple, apple2, car, truck, helicopter, helicopter2 };
            return products;
        }

        private static void SingleResponsibilityPrinciple()
        {
            Console.WriteLine("Single Responsibility Principle");

            Journal j = new Journal();

            j.AddEntry("I fixed a bug in software");
            j.AddEntry("I am implementing design patterns in c#");

            Console.WriteLine(j);

            Persistence p = new Persistence();
            string FileName = "C:\\TestFile.txt";
            
            p.Save(j, FileName, true);
            Console.WriteLine();
        }
    }
}
