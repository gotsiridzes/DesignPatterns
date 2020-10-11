using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.SOLID.InterfaceSegregationPrinciple
{
    public class OldPrinter : IMachine
    {
        // აქ აღარ გვადგება IMachine ინტერფეისი
        // რადგანაც შეიძლება ძველ პრინტერს არ ჰქონდეს ფაქსის და სკანირების ფუნქცია
        // და კლასში ვინახავთ ისეთ კოდს, რაც არაა საჭირო და ვერასდროს გამოვიყენებთ
        public void Fax(Document d)
        {
            throw new NotImplementedException();
        }

        public void Print(Document d)
        {
            // implement
        }

        public void Scan(Document d)
        {
            throw new NotImplementedException();
        }
    }
}
