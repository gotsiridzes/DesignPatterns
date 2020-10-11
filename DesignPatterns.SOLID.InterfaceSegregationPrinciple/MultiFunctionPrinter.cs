using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.SOLID.InterfaceSegregationPrinciple
{
    //public class MultiFunctionPrinter : IMachine
    //{
    //    // ამ შემთხვევაში გამოვიყენებდით IMachine ინტერფეისს მაგრამ
    //    // თუ გვჭირდება მხოლოდ რომ მოწყობილობას ჰქონდეს მხოლოდ პრინტერის ფუნქციონალი
    //    // ან პრინტ და სკან ფუნქციონალი, მაშინ გამოუსადეგარი ხდება IMachine ინტერფეისი
    //    public void Print(Document d)
    //    {
    //        //
    //    }

    //    public void Scan(Document d)
    //    {
    //        //
    //    }
    //    public void Fax(Document d)
    //    {
    //        //
    //    }
    //}

    public class MultiFunctionPrinter : IMultiFunctionDevice
    {
        public IPrinter Printer { get; set; }
        public IScanner Scanner { get; set; }

        public MultiFunctionPrinter(IPrinter printer, IScanner scanner)
        {
            Printer = printer ?? throw new ArgumentNullException(nameof(printer));
            Scanner = scanner ?? throw new ArgumentNullException(nameof(scanner));
        }

        //decorator pattern
        public void Scan(Document d)
        {
            Scanner.Scan(d);
        }

        public void Print(Document d)
        {
            Printer.Print(d);
        }
    }
}
