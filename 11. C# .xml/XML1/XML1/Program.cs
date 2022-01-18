using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XML1
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            XmlWriter writer = XmlWriter.Create("file.xml", settings);
            writer.WriteStartDocument();

            writer.WriteComment("Commento di prova");
            writer.WriteComment("file inserito nella directory dell'eseguibile");

            writer.WriteStartElement("Studente");

            writer.WriteStartElement("Persona1");
            writer.WriteStartElement("Nome");
            writer.WriteString("Antonella");
            writer.WriteEndElement();
            writer.WriteStartElement("Indirizzo");
            writer.WriteString("Vicenza");
            writer.WriteEndElement();
            writer.WriteEndElement();

            writer.WriteStartElement("Persona2");
            writer.WriteStartElement("Nome");
            writer.WriteString("Pietro");
            writer.WriteEndElement();
            writer.WriteStartElement("Indirizzo");
            writer.WriteString("Cavazzale");
            writer.WriteEndElement();
            writer.WriteEndElement();

            char[] ch = { 'a', 'r', 'c' };
            writer.WriteStartElement("Char");
            writer.WriteChars(ch, 0, ch.Length);
            writer.WriteEndElement();

            writer.WriteEndDocument();
            writer.Close();
        }
    }
}
