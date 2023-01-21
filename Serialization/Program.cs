using System;
using BL;
using OrderMemory;

namespace Serialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //XmlSerializer xmlSerializer = new XmlSerializer(typeof(Company[]));
            //var path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName,"config.xml");

            //using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            //{
            //    xmlSerializer.Serialize(fs, list);
            //    Console.WriteLine("Object has been serialized");
            //}
            CompanyRepository cr = new CompanyRepository();
            Company cc = cr.Get(1);
            Console.WriteLine(cc);

            Console.ReadLine();
            Console.WriteLine("Hello World!");
        }
    }
}
