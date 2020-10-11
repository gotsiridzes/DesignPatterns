using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.SOLID.InterfaceSegregationPrinciple
{
    public interface IMachine
    {
        // ეს ინტერფეისი უზრუნველყოფს რამდენიმე ფუნქციის შესრულებას
        // ბეჭდვა, სკანირება, ფაქსის გაგზავნა ...
        // ასეთ შემთხვევაში უნდა მოხდეს ინტერფეისის კიდევ პატარა ნაწილებად დაყოფა
        // მაგალითად IPrinter, IScanner, IFaxMachine ...
        void Print(Document d);
        void Scan(Document d);
        void Fax(Document d);
    }
}
