using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XML3
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlTextReader reader = new XmlTextReader("file.xml");
            int commenti = 0;
            int elementi = 0;
            int dichiarazioni = 0;

            reader.Read();
            while (reader.Read())
            {
                XmlNodeType nType = reader.NodeType;
                if (nType == XmlNodeType.XmlDeclaration)
                {
                    Console.WriteLine("Declaration:" + reader.Name.ToString());
                    dichiarazioni += 1;
                }
                if (nType == XmlNodeType.Comment)
                 {
                    Console.WriteLine("Comment:" + reader.Value.ToString());
                    commenti += 1;
                }
                if (nType == XmlNodeType.Element)
                {
                    Console.WriteLine("Element:" + reader.Name.ToString());
                    elementi += 1;
                }
            }
            Console.WriteLine("\nTotal Comments:" + commenti.ToString());
            Console.WriteLine("Total Elements:" + elementi.ToString());
            Console.WriteLine("Total Declaration:" + dichiarazioni.ToString());
            Console.ReadKey();
        }
    }
}
