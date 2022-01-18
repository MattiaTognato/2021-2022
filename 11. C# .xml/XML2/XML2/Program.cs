using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XML2
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            XmlWriter writer = XmlWriter.Create("file.xml", settings);
            writer.WriteStartDocument();

            writer.WriteStartElement("Students");

            writer.WriteStartElement("Student");
            writer.WriteStartElement("Nome");
            writer.WriteString("Olivia");
            writer.WriteEndElement();
            writer.WriteStartElement("Paese");
            writer.WriteString("Vicenza");
            writer.WriteEndElement();
            writer.WriteEndElement();

            writer.WriteStartElement("Student");
            writer.WriteStartElement("Nome");
            writer.WriteString("Laura");
            writer.WriteEndElement();
            writer.WriteStartElement("Paese");
            writer.WriteString("Padova");
            writer.WriteEndElement();
            writer.WriteEndElement();

            writer.WriteStartElement("Student");
            writer.WriteStartElement("Nome");
            writer.WriteString("Martina");
            writer.WriteEndElement();
            writer.WriteStartElement("Paese");
            writer.WriteString("Venezia");
            writer.WriteEndElement();
            writer.WriteEndElement();

            writer.WriteStartElement("Student");
            writer.WriteStartElement("Nome");
            writer.WriteString("Paolo");
            writer.WriteEndElement();
            writer.WriteStartElement("Paese");
            writer.WriteString("Trento");
            writer.WriteEndElement();
            writer.WriteEndElement();

            writer.WriteStartElement("Student");
            writer.WriteStartElement("Nome");
            writer.WriteString("Monica");
            writer.WriteEndElement();
            writer.WriteStartElement("Paese");
            writer.WriteString("Verona");
            writer.WriteEndElement();
            writer.WriteEndElement();

            writer.WriteEndElement();
            
            writer.WriteEndDocument();
            writer.Close();
        }
    }
}
