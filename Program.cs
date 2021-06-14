using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XMLReaderLinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"C:\Users\marco\OneDrive\Escritorio\XMLTest.xml";

            XElement StoreXML = XElement.Load(filepath);

            var beers = from e in StoreXML.Element("beers").Elements("beer") orderby e.Value select e;


            foreach (var Neeritem in beers)
            {
                Console.WriteLine($" { Neeritem.Value } {Neeritem.Attribute("style").Value}");
            }
            Console.ReadLine();
        }
    }
}
