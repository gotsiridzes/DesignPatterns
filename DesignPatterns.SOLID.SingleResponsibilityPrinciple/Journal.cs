using System;
using System.Collections.Generic;
using System.IO;

namespace DesignPatterns.SOLID.SingleResponsibilityPrinciple
{
    /// <summary>
    /// ინახავს ჟურნალის ჩანაწერებს და მასთან მუშაობის მეთოდებს: ჩაწერა, წაშლა
    /// </summary>
    public class Journal
    {
        private readonly List<string> entries = new List<string>();
        private static int count = 0;

        public int AddEntry(string entry)
        {
            entries.Add($"{++count}: {entry}");
            return count;
        }

        public void RemoveEntry(int index)
        {
            entries.RemoveAt(index);
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, entries);
        }

        // ქვემოთ მოყვანილი მეთოდებით ამ კლასს ვაძლევთ იმაზე მეტ პასუხისმგებლობას ვიდრე საჭიროა
        // ახლა არა მარტო ინფორმაციის შენახვა, არამედ მისი მენეჯმენტიც უწევს: ფაილად შენახვა, ჩატვირთვა (ფაილიდან, ლინკიდან) ...
        // ეს არღვევს SOLID-ის Single Responsibility Principle-ს
        public void Save(string fileName)
        {
            File.WriteAllText(fileName, ToString());
        }

        public Journal Load(string fileName)
        {
            throw new NotImplementedException();
        }

        public Journal Load(Uri uri)
        {
            throw new NotImplementedException();
        }
    }
}
