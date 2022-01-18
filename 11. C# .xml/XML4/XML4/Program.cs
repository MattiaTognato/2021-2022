using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XML4
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlTextReader reader = new XmlTextReader("file.xml");
            reader.Read();
            while (reader.Read())
            {
                XmlNodeType nType = reader.NodeType;
                if (nType == XmlNodeType.Element && reader.Name == "Nome")
                {
                    Console.WriteLine("Contenuto:" + reader.ReadString());
                }
            }
            Console.ReadKey();
        }
    }
}
