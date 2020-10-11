using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.SOLID.InterfaceSegregationPrinciple
{
    public interface IMultiFunctionDevice : IScanner, IPrinter
    {
        // თუ გვინდა რომ მოწყობილობას ჰქონდეს როგორც პრინტერის, ასევე სკანერის ფუნქციონალი
        // მაშინ შეგვიძლია ეს ინტერფეისები კიდევ ერთ დიდ ინტერფეისში გავაერთიანოთ IMultiFunctionDevice
    }
}
