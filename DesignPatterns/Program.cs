using DesignPatterns.SOLID.SingleResponsibilityPrinciple;
using System;
using System.Diagnostics;

namespace DesignPatterns
{

    class Program
    {
        static void Main(string[] args)
        {
            SingleResponsibilityPrinciple();

        }

        private static void SingleResponsibilityPrinciple()
        {
            Journal j = new Journal();

            j.AddEntry("I fixed a bug in software");
            j.AddEntry("I am implementing design patterns in c#");

            Console.WriteLine(j);

            Persistence p = new Persistence();
            string FileName = "C:\\TestFile.txt";
            
            p.Save(j, FileName, true);
        }
    }
}
