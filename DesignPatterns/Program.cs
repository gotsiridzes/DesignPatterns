﻿using DesignPatterns.Builder;
using DesignPatterns.Creational.Builder.FacetedBuilder;
using DesignPatterns.Creational.Builder.FluentBuulder.Employee;
using DesignPatterns.Creational.Factories;
using DesignPatterns.SOLID.DependencyInversionPrinciple;
using DesignPatterns.SOLID.InterfaceSegregationPrinciple;
using DesignPatterns.SOLID.LiskovSubstitutionPrinciple;
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
            #region SOLID
            SingleResponsibilityPrinciple();
            OpenClosedPrinciple();
            LiskovSubstitutionPrinciple();
            InterfaceSegregationPrinciple();
            DependencyInversionPrinciple();
            #endregion

            BuilderPattern();

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

        private static void OpenClosedPrinciple()
        {
            Console.WriteLine("Open Closed Principle");
            Product[] products = GetProducts();

            Console.WriteLine("Violates OCP");
            var filter = new ProductFilter();

            Console.WriteLine("Blue Items");
            foreach (var prod in filter.FilterByColor(products, Color.Blue))
                Console.WriteLine("--- {0}", prod);

            Console.WriteLine("Large Items");
            foreach (var prod in filter.FilterBySize(products, Size.Large))
                Console.WriteLine("--- {0}", prod);

            Console.WriteLine("\nDoes not violate OCP\n");
            //არ არღვევს ocp-s

            var bf = new BetterFilter();
            Console.WriteLine("Green Products");
            foreach (var prod in bf.Filter(products, new ColorSpecification(Color.Green)))
                Console.WriteLine("---  {0}", prod);

            Console.WriteLine("---Small Products---");
            foreach (var prod in bf.Filter(products, new SizeSpecification(Size.Small)))
                Console.WriteLine("--- {0}", prod);

            Console.WriteLine("Large And Blue Items");
            foreach (var prod in bf.Filter(products,
                new AndSpecification<Product>(
                    new ColorSpecification(Color.Blue),
                    new SizeSpecification(Size.Large)
                    )))
                Console.WriteLine("--- {0}", prod);

            Console.WriteLine("Medium Or Large Items");
            foreach (var prod in bf.Filter(products,
                new OrSpecification<Product>(
                    new SizeSpecification(Size.Medium),
                    new SizeSpecification(Size.Large))))
                Console.WriteLine("--- {0}", prod);


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

        private static void LiskovSubstitutionPrinciple()
        {
            Console.WriteLine("Liskov Substitution Principle");
            Rectangle rc = new Rectangle();
            Console.WriteLine("Area of rectangle is {0}", Area(rc));
            Rectangle rc2 = new Rectangle(10,20);
            Console.WriteLine("Area of rectangle is {0}", Area(rc2));

            Square sq = new Square { Width = 4 };
            Console.WriteLine("Area of sauqre is {0}", Area(sq));

            Rectangle sq2 = new Square();
            sq2.Width = 5;
            Console.WriteLine("Area of sauqre2 is {0}", Area(sq2));

            Console.WriteLine("\n-----\n");
        }

        private static int Area(Rectangle rc)
        {
            return rc.Width * rc.Height;
        }

        private static void InterfaceSegregationPrinciple()
        {
            Console.WriteLine("Interface Segregation Principle");

            Document d = new Document("Test Document", "Interface Segregation testing");

            MultiFunctionPrinter mfp = new MultiFunctionPrinter(new Printer(), new Scanner());

            mfp.Print(d);

            Printer p = new Printer();

            p.Print(d);
            Scanner s = new Scanner();

            s.Scan(d);
            Console.WriteLine();
        }

        private static void DependencyInversionPrinciple()
        {
            Console.WriteLine("Dependency Inversion Principle");
            // Dependency Inversion Principle
            // States that high level parts of a system should not depend on low level parts of the system directly.
            // Both should depend on some kind of abstraction

            Person p = new Person("Gela");

            Person c1 = new Person("Gelas shvili pirveli");
            Person c2 = new Person("Gelas shvili meore");

            Relationships rels = new Relationships();
            rels.AddRelation(p, c1);
            rels.AddRelation(p, c2);

            var research = new Research(rels);
        }

        private static void BuilderPattern()
        {
            HtmlBuilder hb = new HtmlBuilder("ul");
            hb.AddChild("li", "Hello World from ul li");

            Console.WriteLine(hb);

            hb = new HtmlBuilder("p");
            hb.AddChild("a", "Hello world from paragraph");
            hb.AddChild("a", "Hello world from paragraph2");
            hb.AddChild("li", "li tag").AddChild("li", "chaining in builder");
            Console.WriteLine(hb);

            //var builder = new PersonJobBuilder();
            //builder.Called("Saba");
            //.WorksAs

            var emp = Employee
                .New
                .WorksAs("Developer")
                .Called("Saba")
                .Build();

            Console.WriteLine(emp);


            var sb = new StudentBuilder();
            Student student = sb
                .Studies.At("TSU")
                        .On("Exact and natural sciences")
                .Is.Called("Saba");

            Console.WriteLine();

        }

        private static void FactoryMethod()
        {
            //var point = Point().NewCartesianPoint(5,10);
            //var point = PointFactory.NewCartesianPoint(10,20);
            var point = Point.Factory.NewPolarPoint(1, Math.PI);

            var origin = Point.Origin2;
        }
    }
}
