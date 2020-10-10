using System;
using System.IO;

namespace DesignPatterns.SOLID.SingleResponsibilityPrinciple
{
    /// <summary>
    /// უზრუნველყოფს Journal ან სხვა ობიექტის სხვადასხვა პასუხისმგებლობიებს შესრულებას (TODO უკეთესი ვარიანტის მოფიქრებაც შეიძლება)
    /// </summary>
    public class Persistence
    {
        public void Save(Journal j, string fileName, bool overwrite = false)
        {
            if (overwrite || File.Exists(fileName))
                File.WriteAllText(fileName, j.ToString());
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
